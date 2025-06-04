using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using System.Data;
using LyonPalmeForms.DataAccess;
using LyonPalme.Models;

namespace LyonPalmeForms
{
    public partial class ListeMatPrêt : MaterialForm
    {
        public ListeMatPrêt()
        {
            InitializeComponent();
            ChargerPretsEnCours(); // Chargement des prêts à l'ouverture
        }

        private void btn_retourmp_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Charge tous les prêts non retournés (étatRetour NULL ou vide).
        /// </summary>
        private void ChargerPretsEnCours()
        {
            try
            {
                Tableau_Prêt.Items.Clear(); // Vider la liste

                var prets = PretMaterielModel.Lister(); // ✅ Appel à la couche métier

                foreach (var pret in prets)
                {
                    // ❗ On filtre : que les prêts non retournés ou en cours
                    if (string.IsNullOrWhiteSpace(pret.EtatRetour) || pret.EtatRetour == "En cours" || pret.EtatRetour == "N/A")
                    {
                        ListViewItem item = new ListViewItem(pret.IdPret.ToString());
                        item.SubItems.Add(pret.IdMembre.ToString());
                        item.SubItems.Add(pret.IdMateriel.ToString());
                        item.SubItems.Add(pret.DatePret.ToString("yyyy-MM-dd"));
                        item.SubItems.Add(pret.DateRetour.ToString("yyyy-MM-dd"));
                        item.SubItems.Add(pret.EtatPret);
                        item.SubItems.Add(string.IsNullOrWhiteSpace(pret.EtatRetour) ? "En cours" : pret.EtatRetour);

                        Tableau_Prêt.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des prêts en cours : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Récupération du matériel : met à jour l’état retour et incrémente le stock
        /// </summary>
        private void btn_recupmat_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TB_IDPrêt.Text) || string.IsNullOrWhiteSpace(TB_EtatRetour.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                    return;
                }

                int idPret = int.Parse(TB_IDPrêt.Text);
                string etatRetour = TB_EtatRetour.Text.Trim();

                PretMaterielModel.Retourner(idPret, etatRetour); // ✅ appel via la couche métier

                MessageBox.Show("Matériel bien récupéré !");
                ChargerPretsEnCours(); // Rechargement automatique
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}
