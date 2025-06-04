using LyonPalmeForms.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LyonPalme.Models
{
    /// <summary>
    /// Représente un membre de LyonPalme.
    /// </summary>
    public class MembreModel
    {
        public int IdMembre { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        /// <summary>
        /// Méthode métier pour authentifier un membre.
        /// </summary>
        /// <param name="login">Nom d'utilisateur</param>
        /// <param name="mdp">Mot de passe</param>
        /// <returns>MembreModel si connexion OK, sinon null</returns>
        public static MembreModel Authentifier(string login, string mdp)
        {
            return DBInterface.AuthentifierMembre(login, mdp);
        }
    }
}

