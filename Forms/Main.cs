using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyonPalmeForms
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_visualstock_Click(object sender, EventArgs e)
        {
            //Ouverture de la page de visualisation du stock
            StockMateriel mainForm = new StockMateriel();
            mainForm.Show();
            //cacher la page main après avoir cliqué
            this.Hide();
        }

        private void btn_materielprêté_Click(object sender, EventArgs e)
        {
            //Ouverture page liste mat prêté
            ListeMatPrêt mainForm = new ListeMatPrêt();
            mainForm.Show();
            //cacher la page main après avoir cliqué
            this.Hide();
        }
    }
}
