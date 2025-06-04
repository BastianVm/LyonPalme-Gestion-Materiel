using LyonPalmeForms.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyonPalme.Models
{
    public class StockMaterielModel
    {
        public int IdMateriel { get; set; }
        public string Libelle { get; set; }
        public string Marque { get; set; }
        public int QteTotale { get; set; }
        public int QteDisponible { get; set; }
        public string Taille { get; set; }      // Pour combinaison
        public string Epaisseur { get; set; }   // Pour combinaison (ex. : "3.0 mm")
        public string Pointure { get; set; }    // Pour monopalme

        // 🔁 Méthode statique appelée par la Form
        public static List<StockMaterielModel> GetStock()
        {
            return DBInterface.GetStockMateriel(); // 👈 Seule la couche métier parle à DBInterface
        }

        public static void Ajouter(string libelle, string marque, int qteTotale, int qteDisponible,
                           string typeMateriel, int? pointure, string taille, float? epaisseur)
        {
            DBInterface.AjouterMateriel(libelle, marque, qteTotale, qteDisponible, typeMateriel, pointure, taille, epaisseur);
        }
    }

}
