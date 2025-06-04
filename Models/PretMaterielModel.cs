using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LyonPalmeForms.DataAccess; // 👈 Ajout du bon using

namespace LyonPalme.Models
{
    /// <summary>
    /// Modélise un prêt de matériel.
    /// </summary>
    public class PretMaterielModel
    {
        public int IdPret { get; set; }
        public int IdMembre { get; set; }
        public int IdMateriel { get; set; }
        public DateTime DatePret { get; set; }
        public DateTime DateRetour { get; set; }
        public string EtatPret { get; set; }
        public string EtatRetour { get; set; }

        public void Enregistrer()
        {
            DBInterface.CreerPretMateriel(
                IdMembre, IdMateriel, DatePret, DateRetour, EtatPret, EtatRetour
            );
        }

        // ✅ Appelé par la couche présentation
        public static List<PretMaterielModel> Lister()
        {
            return DBInterface.ListerPrets();
        }

        public static void Retourner(int idPret, string etatRetour)
        {
            DBInterface.RetournerMateriel(idPret, etatRetour);
        }
    }
}
