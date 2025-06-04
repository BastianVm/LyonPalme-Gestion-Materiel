using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using LyonPalme.Models; // ✅ On appelle la couche métier (pas DataAccess)

namespace LyonPalmeForms
{
    public partial class ConnexionForms : MaterialForm
    {


        public ConnexionForms()
        {
            InitializeComponent();
        }

        private void ConnexionForms_Load(object sender, EventArgs e)
        {
        }

        private void MMLTextBox_id_Click(object sender, EventArgs e)
        {
            MMLTextBox_id.Clear();
        }

        private void MMLTextBox_mdp_Click(object sender, EventArgs e)
        {
            MMLTextBox_mdp.Clear();
        }

        private void MButton_annuler_Click(object sender, EventArgs e)
        {
            MMLTextBox_mdp.Clear();
            MMLTextBox_id.Clear();
        }

        private void MButton_connexion_Click(object sender, EventArgs e)
        {
            string login = MMLTextBox_id.Text.Trim();
            string password = MMLTextBox_mdp.Text.Trim();

            var membre = MembreModel.Authentifier(login, password); // ✅ Appelle la couche métier

            if (membre != null)
            {
                MessageBox.Show("✅ Connexion réussie !", "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Main mainForm = new Main(); // Tu peux lui passer l’objet membre si besoin
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("❌ Identifiants incorrects.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
