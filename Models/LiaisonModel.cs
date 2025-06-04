using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LyonPalme.Models
{
    /// <summary>
    /// Auteur : [Rouis Kalifa].
    /// Date de création : [18/12/2024].
    /// Classe liaison entre Prêt et Matériel.
    /// </summary>
    public class LiaisonModel
    {
        #region Properties

        /// <summary>
        /// Identifiant du matériel.
        /// </summary>
        public int IdMateriel { get; set; }

        /// <summary>
        /// Identifiant du prêt.
        /// </summary>
        public int IdPret { get; set; }

        /// <summary>
        /// Référence vers le matériel.
        /// </summary>
        public StockMaterielModel Materiel { get; set; }

        /// <summary>
        /// Référence vers le prêt.
        /// </summary>
        public PretMaterielModel Pret { get; set; }

        #endregion
    }
}
