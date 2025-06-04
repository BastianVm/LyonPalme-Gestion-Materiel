using System;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using LyonPalmeForms.Tools;

namespace LyonPalmeForms.DataAccess
{
    /// <summary>
    /// Gère la connexion à la base de données avec un singleton.
    /// </summary>
    public class Connection
    {
        private static SqlConnection sqlConnection = null;
        private static Connection instance;

        /// <summary>
        /// Constructeur privé pour empêcher la création multiple.
        /// </summary>
        private Connection() { }

        public SqlConnection GetConnection()
        {
            string connectionString;
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["sqlserver_lyonpalme"].ConnectionString;
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

            }
            catch (SqlException)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("Connection : erreur de connexion au serveur", w);
                }
            }
            return sqlConnection;
        }


        public static Connection getInstance()
        {
            if (Connection.instance == null)
                Connection.instance = new Connection();
            return Connection.instance;
        }

        /// <summary>
        /// Ouvre une connexion SQL et la retourne.
        /// </summary>
        /// <returns>SqlConnection ouverte</returns>

    }
}

