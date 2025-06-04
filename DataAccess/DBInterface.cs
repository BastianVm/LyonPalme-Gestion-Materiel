using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Windows.Forms;
using LyonPalmeForms.Tools;
using System.Data;
using LyonPalme.Models;
using System.Collections.Generic;

namespace LyonPalmeForms.DataAccess
{
    public static class DBInterface
    {
        // 🔐 Authentification
        public static MembreModel AuthentifierMembre(string login, string password)
        {
            MembreModel membre = null;
            SqlConnection cnx = Connection.getInstance().GetConnection(); // ✅ version prof
            SqlCommand cmd = new SqlCommand("lp_AuthentifierMembre", cnx)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", ComputeSHA512Hash(password));

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    membre = new MembreModel
                    {
                        IdMembre = reader.GetInt32(0),
                        Nom = reader.GetString(1),
                        Prenom = reader.GetString(2)
                    };
                    // ✅ Connexion réussie — écrire dans le log
                    using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                    {
                        Log.WriteLog($"DBInterface : l'utilisateur {login} vient de se connecter", w);
                    }
                }
                else
                {
                    // ❌ Connexion échouée — login invalide
                    using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                    {
                        Log.WriteLog($"DBInterface : identifiants de connexion invalide. Login :{login}", w);
                    }
                }
                reader.Close();
            }
            catch (InvalidOperationException)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("DBInterface : erreur SQL", w);
                }
            }

            return membre;
        }

        // 📦 Ajout de matériel
        public static void AjouterMateriel(string libelle, string marque, int qteTotale, int qteDisponible,
                                           string typeMateriel, int? pointure, string taille, float? epaisseur)
        {
            SqlConnection cnx = Connection.getInstance().GetConnection(); // ✅ version prof
            SqlCommand cmd = new SqlCommand("lp_AjouterMateriel", cnx)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@libelle", libelle);
            cmd.Parameters.AddWithValue("@marque", marque);
            cmd.Parameters.AddWithValue("@QteTotale", qteTotale);
            cmd.Parameters.AddWithValue("@QteDisponible", qteDisponible);
            cmd.Parameters.AddWithValue("@typeMateriel", typeMateriel);
            cmd.Parameters.AddWithValue("@pointure", pointure.HasValue ? (object)pointure.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@taille", !string.IsNullOrEmpty(taille) ? (object)taille : DBNull.Value);
            cmd.Parameters.AddWithValue("@epaisseur", epaisseur.HasValue ? (object)epaisseur.Value : DBNull.Value);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("Erreur ajout materielle : " + ex.Message, w);
                }
                throw;
            }
        }

        // 📄 Création d’un prêt
        public static void CreerPretMateriel(int idMembre, int idMateriel, DateTime datePret, DateTime dateRetour, string etatPret, string etatRetour)
        {
            SqlConnection cnx = Connection.getInstance().GetConnection(); // ✅ version prof
            SqlCommand cmd = new SqlCommand("lp_CreerPretMateriel", cnx)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@idMembre", idMembre);
            cmd.Parameters.AddWithValue("@idMateriel", idMateriel);
            cmd.Parameters.AddWithValue("@datePret", datePret);
            cmd.Parameters.AddWithValue("@dateRetour", dateRetour);
            cmd.Parameters.AddWithValue("@etatPret", etatPret);
            cmd.Parameters.AddWithValue("@etatRetour", etatRetour);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("Erreur creation pret materiel : " + ex.Message, w);
                }
                throw;
            }
        }

        public static List<PretMaterielModel> ListerPrets()
        {
            List<PretMaterielModel> liste = new List<PretMaterielModel>();
            SqlConnection cnx = Connection.getInstance().GetConnection();
            SqlCommand cmd = new SqlCommand("lp_ListerPrets", cnx)
            {
                CommandType = CommandType.StoredProcedure
            };

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PretMaterielModel pret = new PretMaterielModel
                    {
                        IdPret = reader.GetInt32(0),
                        IdMembre = reader.GetInt32(1),
                        IdMateriel = reader.GetInt32(2),
                        DatePret = reader.GetDateTime(3),
                        DateRetour = reader.GetDateTime(4),
                        EtatPret = reader.IsDBNull(5) ? "N/A" : reader.GetString(5),
                        EtatRetour = reader.IsDBNull(6) ? "N/A" : reader.GetString(6)
                    };

                    liste.Add(pret);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("Erreur sur lister les pret : " + ex.Message, w);
                }
                throw;
            }

            return liste;
        }

        public static void RetournerMateriel(int idPret, string etatRetour)
        {
            SqlConnection cnx = Connection.getInstance().GetConnection();
            SqlCommand cmd = new SqlCommand("lp_RetournerMateriel", cnx)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@idPret", idPret);
            cmd.Parameters.AddWithValue("@etatRetour", etatRetour);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("Erreur retour materielle : " + ex.Message, w);
                }
                throw;
            }
        }


        public static List<StockMaterielModel> GetStockMateriel()
        {
            List<StockMaterielModel> stockList = new List<StockMaterielModel>();

            SqlConnection cnx = Connection.getInstance().GetConnection();
            SqlCommand cmd = new SqlCommand("lp_GetStockMateriel", cnx)
            {
                CommandType = CommandType.StoredProcedure
            };

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    StockMaterielModel stock = new StockMaterielModel
                    {
                        IdMateriel = reader.GetInt32(reader.GetOrdinal("idMateriel")),
                        Libelle = reader.GetString(reader.GetOrdinal("libelle")),
                        Marque = reader.GetString(reader.GetOrdinal("marque")),
                        QteTotale = reader.GetInt32(reader.GetOrdinal("QteTotale")),
                        QteDisponible = reader.GetInt32(reader.GetOrdinal("QteDisponible")),
                        Pointure = reader["pointure"] != DBNull.Value ? reader["pointure"].ToString() : "N/A",
                        Taille = reader["taille"] != DBNull.Value ? reader["taille"].ToString() : "N/A",
                        Epaisseur = reader["epaisseur"] != DBNull.Value ? reader["epaisseur"].ToString() : "N/A"
                    };

                    stockList.Add(stock);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("Erreur pour avoir le stock : " + ex.Message, w);
                }
                throw;
            }

            return stockList;
        }


        public static string ComputeSHA512Hash(string input)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha512.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower(); // Hex string
            }
        }





    }
}

