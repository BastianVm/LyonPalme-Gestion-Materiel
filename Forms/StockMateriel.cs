using LyonPalme.Models;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using LyonPalmeForms.DataAccess;
using System.Collections.Generic;

namespace LyonPalmeForms
{
    public partial class StockMateriel : MaterialForm
    {
        public StockMateriel()
        {
            InitializeComponent();
            ChargerStockMateriel(); // Charger les données dès l'ouverture
            ChargerListePrets();
        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide(); // Cacher la fenêtre actuelle
        }

        private void btn_AjoutMateriel_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérer les valeurs des champs
                string libelle = TB_Libelle.Text.Trim();
                string marque = TB_Marque.Text.Trim();
                int qteTotale = int.Parse(TB_QTET.Text);
                int qteDispo = int.Parse(TB_QTED.Text);
                string typeMateriel = comboBox_TypeMateriel.SelectedItem?.ToString();

                // ✅ Vérification logique
                if (qteDispo > qteTotale)
                {
                    MessageBox.Show("La quantité disponible ne peut pas être supérieure à la quantité totale.",
                                    "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string taille = null;
                int? pointure = null;
                float? epaisseur = null;

                // Vérification du type et récupération des valeurs spécifiques
                if (typeMateriel == "Monopalme")
                {
                    if (string.IsNullOrWhiteSpace(TB_Pointure.Text))
                    {
                        MessageBox.Show("Veuillez saisir une pointure pour la monopalme.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    pointure = int.Parse(TB_Pointure.Text);
                }
                else if (typeMateriel == "Combinaison")
                {
                    if (string.IsNullOrWhiteSpace(TB_taille.Text) || string.IsNullOrWhiteSpace(TB_épaisseur.Text))
                    {
                        MessageBox.Show("Veuillez saisir la taille et l'épaisseur pour la combinaison.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    taille = TB_taille.Text.Trim();
                    epaisseur = float.Parse(TB_épaisseur.Text); // ✅ ATTENTION : float.Parse, pas double
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un type de matériel valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Appel à la méthode de la couche d'accès aux données
                StockMaterielModel.Ajouter(libelle, marque, qteTotale, qteDispo, typeMateriel, pointure, taille, epaisseur);

                // Rechargement de l'affichage
                ChargerStockMateriel();

                MessageBox.Show("Matériel ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Merci de vérifier que toutes les valeurs numériques sont valides.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du matériel : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_TypeMateriel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            bool isMonopalme = comboBox_TypeMateriel.SelectedItem.ToString() == "Monopalme";

            // Activer/désactiver les champs selon le type
            TB_Pointure.Enabled = isMonopalme;
            TB_taille.Enabled = !isMonopalme;
            TB_épaisseur.Enabled = !isMonopalme;

            // Effacer les valeurs des champs désactivés
            if (isMonopalme)
            {
                TB_taille.Clear();
                TB_épaisseur.Clear();
            }
            else
            {
                TB_Pointure.Clear();
            }
        }

        private void ChargerStockMateriel()
        {
            try
            {
                Tableau_StockMat.Items.Clear(); // On vide d'abord

                // ✅ Appel à la couche métier, plus de lien direct avec DBInterface
                var stockList = StockMaterielModel.GetStock();

                foreach (var stock in stockList)
                {
                    ListViewItem item = new ListViewItem(stock.IdMateriel.ToString());
                    item.SubItems.Add(stock.Libelle);
                    item.SubItems.Add(stock.Marque);
                    item.SubItems.Add(stock.QteTotale.ToString());
                    item.SubItems.Add(stock.QteDisponible.ToString());
                    item.SubItems.Add(stock.Pointure);
                    item.SubItems.Add(stock.Taille);
                    item.SubItems.Add(stock.Epaisseur);

                    Tableau_StockMat.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement stock : " + ex.Message);
            }
        }

        private void ChargerListePrets()
        {
            try
            {
                Tableau_Prêt.Items.Clear(); // Vider la liste

                // ✅ Appel via la couche Métier (et non DBInterface directement)
                var prets = PretMaterielModel.Lister();

                foreach (var pret in prets)
                {
                    ListViewItem item = new ListViewItem(pret.IdPret.ToString());
                    item.SubItems.Add(pret.IdMembre.ToString());
                    item.SubItems.Add(pret.IdMateriel.ToString());
                    item.SubItems.Add(pret.DatePret.ToString("yyyy-MM-dd"));
                    item.SubItems.Add(pret.DateRetour.ToString("yyyy-MM-dd"));
                    item.SubItems.Add(pret.EtatPret);
                    item.SubItems.Add(pret.EtatRetour);

                    Tableau_Prêt.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des prêts : " + ex.Message);
            }
        }


        private void btn_ajoutpret_Click(object sender, EventArgs e)
        {
            try
            {
                PretMaterielModel pret = new PretMaterielModel
                {
                    IdMembre = int.Parse(TB_IdMembre.Text),
                    IdMateriel = int.Parse(TB_IdMaterielPret.Text),
                    DatePret = DT_DatePret.Value.Date,
                    DateRetour = DT_DateRetour.Value.Date,
                    EtatPret = comboBox_EtatPret.Text.Trim(),
                    EtatRetour = comboBox_EtatRetour.Text.Trim()
                };

                pret.Enregistrer(); // Appelle la couche métier → DBInterface → SQL
                ChargerStockMateriel();       // 🔄 Recharge le stock mis à jour
                // ✅ Recharge directement la liste des prêts dans la même fenêtre
                ChargerListePrets();

                MessageBox.Show("✅ Prêt enregistré !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Erreur lors de la création du prêt : " + ex.Message);
            }
        }
    }
}

