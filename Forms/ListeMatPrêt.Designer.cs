namespace LyonPalmeForms
{
    partial class ListeMatPrêt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tableau_Prêt = new System.Windows.Forms.ListView();
            this.ID_Prêt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idMembre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDMatériel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatePrêt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateRetour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Etat_Prêt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Etat_Retour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.TB_EtatRetour = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.TB_IDPrêt = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.btn_recupmat = new MaterialSkin.Controls.MaterialButton();
            this.label_EtatRetour = new System.Windows.Forms.Label();
            this.label_id_Prêt = new System.Windows.Forms.Label();
            this.btn_retourmp = new MaterialSkin.Controls.MaterialButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tableau_Prêt
            // 
            this.Tableau_Prêt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Prêt,
            this.idMembre,
            this.IDMatériel,
            this.DatePrêt,
            this.DateRetour,
            this.Etat_Prêt,
            this.Etat_Retour});
            this.Tableau_Prêt.GridLines = true;
            this.Tableau_Prêt.HideSelection = false;
            this.Tableau_Prêt.Location = new System.Drawing.Point(47, 96);
            this.Tableau_Prêt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tableau_Prêt.MultiSelect = false;
            this.Tableau_Prêt.Name = "Tableau_Prêt";
            this.Tableau_Prêt.Size = new System.Drawing.Size(1649, 456);
            this.Tableau_Prêt.TabIndex = 18;
            this.Tableau_Prêt.UseCompatibleStateImageBehavior = false;
            this.Tableau_Prêt.View = System.Windows.Forms.View.Details;
            // 
            // ID_Prêt
            // 
            this.ID_Prêt.Text = "ID Prêt";
            this.ID_Prêt.Width = 77;
            // 
            // idMembre
            // 
            this.idMembre.Text = "ID Membre";
            this.idMembre.Width = 90;
            // 
            // IDMatériel
            // 
            this.IDMatériel.Text = "ID Matériel";
            this.IDMatériel.Width = 83;
            // 
            // DatePrêt
            // 
            this.DatePrêt.Text = "Date Prêt";
            this.DatePrêt.Width = 207;
            // 
            // DateRetour
            // 
            this.DateRetour.Text = "Date Retour";
            this.DateRetour.Width = 224;
            // 
            // Etat_Prêt
            // 
            this.Etat_Prêt.Text = "Etat Prêt";
            this.Etat_Prêt.Width = 267;
            // 
            // Etat_Retour
            // 
            this.Etat_Retour.Text = "Etat Retour";
            this.Etat_Retour.Width = 239;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.TB_EtatRetour);
            this.panel2.Controls.Add(this.TB_IDPrêt);
            this.panel2.Controls.Add(this.btn_recupmat);
            this.panel2.Controls.Add(this.label_EtatRetour);
            this.panel2.Controls.Add(this.label_id_Prêt);
            this.panel2.Location = new System.Drawing.Point(703, 596);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 337);
            this.panel2.TabIndex = 19;
            // 
            // TB_EtatRetour
            // 
            this.TB_EtatRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TB_EtatRetour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_EtatRetour.Depth = 0;
            this.TB_EtatRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_EtatRetour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TB_EtatRetour.Location = new System.Drawing.Point(103, 100);
            this.TB_EtatRetour.Margin = new System.Windows.Forms.Padding(4);
            this.TB_EtatRetour.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_EtatRetour.Name = "TB_EtatRetour";
            this.TB_EtatRetour.Size = new System.Drawing.Size(292, 142);
            this.TB_EtatRetour.TabIndex = 13;
            this.TB_EtatRetour.Text = "";
            // 
            // TB_IDPrêt
            // 
            this.TB_IDPrêt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TB_IDPrêt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_IDPrêt.Depth = 0;
            this.TB_IDPrêt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_IDPrêt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TB_IDPrêt.Location = new System.Drawing.Point(117, 50);
            this.TB_IDPrêt.Margin = new System.Windows.Forms.Padding(4);
            this.TB_IDPrêt.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_IDPrêt.Name = "TB_IDPrêt";
            this.TB_IDPrêt.Size = new System.Drawing.Size(117, 32);
            this.TB_IDPrêt.TabIndex = 12;
            this.TB_IDPrêt.Text = "";
            // 
            // btn_recupmat
            // 
            this.btn_recupmat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_recupmat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_recupmat.Depth = 0;
            this.btn_recupmat.HighEmphasis = true;
            this.btn_recupmat.Icon = null;
            this.btn_recupmat.Location = new System.Drawing.Point(43, 267);
            this.btn_recupmat.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_recupmat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_recupmat.Name = "btn_recupmat";
            this.btn_recupmat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_recupmat.Size = new System.Drawing.Size(246, 36);
            this.btn_recupmat.TabIndex = 11;
            this.btn_recupmat.Text = " Récupéré le matériel prêté :";
            this.btn_recupmat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_recupmat.UseAccentColor = false;
            this.btn_recupmat.UseVisualStyleBackColor = true;
            this.btn_recupmat.Click += new System.EventHandler(this.btn_recupmat_Click);
            // 
            // label_EtatRetour
            // 
            this.label_EtatRetour.AutoSize = true;
            this.label_EtatRetour.Location = new System.Drawing.Point(9, 158);
            this.label_EtatRetour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_EtatRetour.Name = "label_EtatRetour";
            this.label_EtatRetour.Size = new System.Drawing.Size(79, 16);
            this.label_EtatRetour.TabIndex = 10;
            this.label_EtatRetour.Text = "Etat Retour :";
            // 
            // label_id_Prêt
            // 
            this.label_id_Prêt.AutoSize = true;
            this.label_id_Prêt.Location = new System.Drawing.Point(13, 55);
            this.label_id_Prêt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id_Prêt.Name = "label_id_Prêt";
            this.label_id_Prêt.Size = new System.Drawing.Size(71, 16);
            this.label_id_Prêt.TabIndex = 2;
            this.label_id_Prêt.Text = "ID du Prêt :";
            // 
            // btn_retourmp
            // 
            this.btn_retourmp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_retourmp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_retourmp.Depth = 0;
            this.btn_retourmp.HighEmphasis = true;
            this.btn_retourmp.Icon = null;
            this.btn_retourmp.Location = new System.Drawing.Point(1288, 725);
            this.btn_retourmp.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_retourmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_retourmp.Name = "btn_retourmp";
            this.btn_retourmp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_retourmp.Size = new System.Drawing.Size(270, 36);
            this.btn_retourmp.TabIndex = 20;
            this.btn_retourmp.Text = " Retourner au menu principale :";
            this.btn_retourmp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_retourmp.UseAccentColor = false;
            this.btn_retourmp.UseVisualStyleBackColor = true;
            this.btn_retourmp.Click += new System.EventHandler(this.btn_retourmp_Click);
            // 
            // ListeMatPrêt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1777, 1018);
            this.Controls.Add(this.btn_retourmp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Tableau_Prêt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1777, 1018);
            this.Name = "ListeMatPrêt";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "Liste matériel prêté";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Tableau_Prêt;
        private System.Windows.Forms.ColumnHeader ID_Prêt;
        private System.Windows.Forms.ColumnHeader idMembre;
        private System.Windows.Forms.ColumnHeader IDMatériel;
        private System.Windows.Forms.ColumnHeader DatePrêt;
        private System.Windows.Forms.ColumnHeader DateRetour;
        private System.Windows.Forms.ColumnHeader Etat_Prêt;
        private System.Windows.Forms.ColumnHeader Etat_Retour;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox TB_EtatRetour;
        private MaterialSkin.Controls.MaterialMultiLineTextBox TB_IDPrêt;
        private MaterialSkin.Controls.MaterialButton btn_recupmat;
        private System.Windows.Forms.Label label_EtatRetour;
        private System.Windows.Forms.Label label_id_Prêt;
        private MaterialSkin.Controls.MaterialButton btn_retourmp;
    }
}
