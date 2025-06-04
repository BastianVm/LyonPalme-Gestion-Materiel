namespace LyonPalmeForms
{
    partial class StockMateriel
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
            this.label_Libelle = new System.Windows.Forms.Label();
            this.label_pointure = new System.Windows.Forms.Label();
            this.label_marque = new System.Windows.Forms.Label();
            this.label_qteTotale = new System.Windows.Forms.Label();
            this.label_qteDisponible = new System.Windows.Forms.Label();
            this.label_taille = new System.Windows.Forms.Label();
            this.label_épaisseur = new System.Windows.Forms.Label();
            this.btn_AjoutMateriel = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_TypeMateriel = new System.Windows.Forms.ComboBox();
            this.TB_épaisseur = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.TB_taille = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.TB_Pointure = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.TB_QTED = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.TB_QTET = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.TB_Marque = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.TB_Libelle = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.label_id_Materiel = new System.Windows.Forms.Label();
            this.label_IDMembre = new System.Windows.Forms.Label();
            this.btn_ajoutpret = new MaterialSkin.Controls.MaterialButton();
            this.TB_IdMaterielPret = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.TB_IdMembre = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_EtatRetour = new System.Windows.Forms.ComboBox();
            this.comboBox_EtatPret = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_DateRetour = new System.Windows.Forms.Label();
            this.label_DatePrêt = new System.Windows.Forms.Label();
            this.DT_DateRetour = new System.Windows.Forms.DateTimePicker();
            this.DT_DatePret = new System.Windows.Forms.DateTimePicker();
            this.label_AjoutMat = new System.Windows.Forms.Label();
            this.label_AjoutPrêt = new System.Windows.Forms.Label();
            this.Tableau_StockMat = new System.Windows.Forms.ListView();
            this.idMateriel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.libelle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.marque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QTE_Totale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QTE_Disponible = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mono_Pointure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COM_taille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COM_épaisseur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tableau_Prêt = new System.Windows.Forms.ListView();
            this.ID_Prêt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idMembre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDMatériel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatePrêt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateRetour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Etat_Prêt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Etat_Retour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_stockmat = new System.Windows.Forms.Label();
            this.label_listeprêt = new System.Windows.Forms.Label();
            this.btn_Retour = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Libelle
            // 
            this.label_Libelle.AutoSize = true;
            this.label_Libelle.Location = new System.Drawing.Point(8, 43);
            this.label_Libelle.Name = "label_Libelle";
            this.label_Libelle.Size = new System.Drawing.Size(43, 13);
            this.label_Libelle.TabIndex = 3;
            this.label_Libelle.Text = "Libelle :";
            // 
            // label_pointure
            // 
            this.label_pointure.AutoSize = true;
            this.label_pointure.Location = new System.Drawing.Point(8, 190);
            this.label_pointure.Name = "label_pointure";
            this.label_pointure.Size = new System.Drawing.Size(155, 13);
            this.label_pointure.TabIndex = 5;
            this.label_pointure.Text = "Pointure (pour les monopalme) :";
            // 
            // label_marque
            // 
            this.label_marque.AutoSize = true;
            this.label_marque.Location = new System.Drawing.Point(8, 70);
            this.label_marque.Name = "label_marque";
            this.label_marque.Size = new System.Drawing.Size(49, 13);
            this.label_marque.TabIndex = 6;
            this.label_marque.Text = "Marque :";
            // 
            // label_qteTotale
            // 
            this.label_qteTotale.AutoSize = true;
            this.label_qteTotale.Location = new System.Drawing.Point(8, 97);
            this.label_qteTotale.Name = "label_qteTotale";
            this.label_qteTotale.Size = new System.Drawing.Size(86, 13);
            this.label_qteTotale.TabIndex = 7;
            this.label_qteTotale.Text = "Quantité Totale :";
            // 
            // label_qteDisponible
            // 
            this.label_qteDisponible.AutoSize = true;
            this.label_qteDisponible.Location = new System.Drawing.Point(8, 127);
            this.label_qteDisponible.Name = "label_qteDisponible";
            this.label_qteDisponible.Size = new System.Drawing.Size(105, 13);
            this.label_qteDisponible.TabIndex = 8;
            this.label_qteDisponible.Text = "Quantité Disponible :";
            // 
            // label_taille
            // 
            this.label_taille.AutoSize = true;
            this.label_taille.Location = new System.Drawing.Point(10, 218);
            this.label_taille.Name = "label_taille";
            this.label_taille.Size = new System.Drawing.Size(38, 13);
            this.label_taille.TabIndex = 9;
            this.label_taille.Text = "Taille :";
            // 
            // label_épaisseur
            // 
            this.label_épaisseur.AutoSize = true;
            this.label_épaisseur.Location = new System.Drawing.Point(4, 240);
            this.label_épaisseur.Name = "label_épaisseur";
            this.label_épaisseur.Size = new System.Drawing.Size(58, 13);
            this.label_épaisseur.TabIndex = 10;
            this.label_épaisseur.Text = "épaisseur :";
            // 
            // btn_AjoutMateriel
            // 
            this.btn_AjoutMateriel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_AjoutMateriel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_AjoutMateriel.Depth = 0;
            this.btn_AjoutMateriel.HighEmphasis = true;
            this.btn_AjoutMateriel.Icon = null;
            this.btn_AjoutMateriel.Location = new System.Drawing.Point(87, 275);
            this.btn_AjoutMateriel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_AjoutMateriel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_AjoutMateriel.Name = "btn_AjoutMateriel";
            this.btn_AjoutMateriel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_AjoutMateriel.Size = new System.Drawing.Size(93, 36);
            this.btn_AjoutMateriel.TabIndex = 11;
            this.btn_AjoutMateriel.Text = "Ajouter :";
            this.btn_AjoutMateriel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_AjoutMateriel.UseAccentColor = false;
            this.btn_AjoutMateriel.UseVisualStyleBackColor = true;
            this.btn_AjoutMateriel.Click += new System.EventHandler(this.btn_AjoutMateriel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.comboBox_TypeMateriel);
            this.panel1.Controls.Add(this.TB_épaisseur);
            this.panel1.Controls.Add(this.TB_taille);
            this.panel1.Controls.Add(this.TB_Pointure);
            this.panel1.Controls.Add(this.TB_QTED);
            this.panel1.Controls.Add(this.TB_QTET);
            this.panel1.Controls.Add(this.TB_Marque);
            this.panel1.Controls.Add(this.TB_Libelle);
            this.panel1.Controls.Add(this.btn_AjoutMateriel);
            this.panel1.Controls.Add(this.label_épaisseur);
            this.panel1.Controls.Add(this.label_taille);
            this.panel1.Controls.Add(this.label_Libelle);
            this.panel1.Controls.Add(this.label_pointure);
            this.panel1.Controls.Add(this.label_qteDisponible);
            this.panel1.Controls.Add(this.label_marque);
            this.panel1.Controls.Add(this.label_qteTotale);
            this.panel1.Location = new System.Drawing.Point(706, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 328);
            this.panel1.TabIndex = 12;
            // 
            // comboBox_TypeMateriel
            // 
            this.comboBox_TypeMateriel.FormattingEnabled = true;
            this.comboBox_TypeMateriel.Items.AddRange(new object[] {
            "Monopalme",
            "Combinaison"});
            this.comboBox_TypeMateriel.Location = new System.Drawing.Point(140, 153);
            this.comboBox_TypeMateriel.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_TypeMateriel.Name = "comboBox_TypeMateriel";
            this.comboBox_TypeMateriel.Size = new System.Drawing.Size(92, 21);
            this.comboBox_TypeMateriel.TabIndex = 14;
            this.comboBox_TypeMateriel.SelectedIndexChanged += new System.EventHandler(this.comboBox_TypeMateriel_SelectedIndexChanged_1);
            // 
            // TB_épaisseur
            // 
            this.TB_épaisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TB_épaisseur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_épaisseur.Depth = 0;
            this.TB_épaisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_épaisseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TB_épaisseur.Location = new System.Drawing.Point(65, 240);
            this.TB_épaisseur.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_épaisseur.Name = "TB_épaisseur";
            this.TB_épaisseur.Size = new System.Drawing.Size(70, 16);
            this.TB_épaisseur.TabIndex = 13;
            this.TB_épaisseur.Text = "";
            // 
            // TB_taille
            // 
            this.TB_taille.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TB_taille.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_taille.Depth = 0;
            this.TB_taille.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_taille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TB_taille.Location = new System.Drawing.Point(51, 214);
            this.TB_taille.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_taille.Name = "TB_taille";
            this.TB_taille.Size = new System.Drawing.Size(70, 16);
            this.TB_taille.TabIndex = 13;
            this.TB_taille.Text = "";
            // 
            // TB_Pointure
            // 
            this.TB_Pointure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TB_Pointure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Pointure.Depth = 0;
            this.TB_Pointure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_Pointure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TB_Pointure.Location = new System.Drawing.Point(161, 187);
            this.TB_Pointure.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_Pointure.Name = "TB_Pointure";
            this.TB_Pointure.Size = new System.Drawing.Size(70, 16);
            this.TB_Pointure.TabIndex = 13;
            this.TB_Pointure.Text = "";
            // 
            // TB_QTED
            // 
            this.TB_QTED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TB_QTED.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_QTED.Depth = 0;
            this.TB_QTED.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_QTED.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TB_QTED.Location = new System.Drawing.Point(114, 124);
            this.TB_QTED.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_QTED.Name = "TB_QTED";
            this.TB_QTED.Size = new System.Drawing.Size(70, 16);
            this.TB_QTED.TabIndex = 13;
            this.TB_QTED.Text = "";
            // 
            // TB_QTET
            // 
            this.TB_QTET.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TB_QTET.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_QTET.Depth = 0;
            this.TB_QTET.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_QTET.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TB_QTET.Location = new System.Drawing.Point(97, 95);
            this.TB_QTET.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_QTET.Name = "TB_QTET";
            this.TB_QTET.Size = new System.Drawing.Size(70, 16);
            this.TB_QTET.TabIndex = 13;
            this.TB_QTET.Text = "";
            // 
            // TB_Marque
            // 
            this.TB_Marque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TB_Marque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Marque.Depth = 0;
            this.TB_Marque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_Marque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TB_Marque.Location = new System.Drawing.Point(87, 67);
            this.TB_Marque.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_Marque.Name = "TB_Marque";
            this.TB_Marque.Size = new System.Drawing.Size(70, 16);
            this.TB_Marque.TabIndex = 13;
            this.TB_Marque.Text = "";
            // 
            // TB_Libelle
            // 
            this.TB_Libelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TB_Libelle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Libelle.Depth = 0;
            this.TB_Libelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_Libelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TB_Libelle.Location = new System.Drawing.Point(87, 43);
            this.TB_Libelle.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_Libelle.Name = "TB_Libelle";
            this.TB_Libelle.Size = new System.Drawing.Size(70, 16);
            this.TB_Libelle.TabIndex = 13;
            this.TB_Libelle.Text = "";
            // 
            // label_id_Materiel
            // 
            this.label_id_Materiel.AutoSize = true;
            this.label_id_Materiel.Location = new System.Drawing.Point(3, 80);
            this.label_id_Materiel.Name = "label_id_Materiel";
            this.label_id_Materiel.Size = new System.Drawing.Size(79, 13);
            this.label_id_Materiel.TabIndex = 2;
            this.label_id_Materiel.Text = "ID du Matériel :";
            // 
            // label_IDMembre
            // 
            this.label_IDMembre.AutoSize = true;
            this.label_IDMembre.Location = new System.Drawing.Point(8, 49);
            this.label_IDMembre.Name = "label_IDMembre";
            this.label_IDMembre.Size = new System.Drawing.Size(65, 13);
            this.label_IDMembre.TabIndex = 9;
            this.label_IDMembre.Text = "ID Membre :";
            // 
            // btn_ajoutpret
            // 
            this.btn_ajoutpret.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ajoutpret.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_ajoutpret.Depth = 0;
            this.btn_ajoutpret.HighEmphasis = true;
            this.btn_ajoutpret.Icon = null;
            this.btn_ajoutpret.Location = new System.Drawing.Point(103, 261);
            this.btn_ajoutpret.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ajoutpret.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ajoutpret.Name = "btn_ajoutpret";
            this.btn_ajoutpret.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_ajoutpret.Size = new System.Drawing.Size(93, 36);
            this.btn_ajoutpret.TabIndex = 11;
            this.btn_ajoutpret.Text = "Ajouter :";
            this.btn_ajoutpret.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_ajoutpret.UseAccentColor = false;
            this.btn_ajoutpret.UseVisualStyleBackColor = true;
            this.btn_ajoutpret.Click += new System.EventHandler(this.btn_ajoutpret_Click);
            // 
            // TB_IdMaterielPret
            // 
            this.TB_IdMaterielPret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TB_IdMaterielPret.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_IdMaterielPret.Depth = 0;
            this.TB_IdMaterielPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_IdMaterielPret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TB_IdMaterielPret.Location = new System.Drawing.Point(87, 79);
            this.TB_IdMaterielPret.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_IdMaterielPret.Name = "TB_IdMaterielPret";
            this.TB_IdMaterielPret.Size = new System.Drawing.Size(70, 16);
            this.TB_IdMaterielPret.TabIndex = 12;
            this.TB_IdMaterielPret.Text = "";
            // 
            // TB_IdMembre
            // 
            this.TB_IdMembre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TB_IdMembre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_IdMembre.Depth = 0;
            this.TB_IdMembre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TB_IdMembre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TB_IdMembre.Location = new System.Drawing.Point(87, 49);
            this.TB_IdMembre.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_IdMembre.Name = "TB_IdMembre";
            this.TB_IdMembre.Size = new System.Drawing.Size(70, 16);
            this.TB_IdMembre.TabIndex = 13;
            this.TB_IdMembre.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox_EtatRetour);
            this.panel2.Controls.Add(this.comboBox_EtatPret);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label_DateRetour);
            this.panel2.Controls.Add(this.label_DatePrêt);
            this.panel2.Controls.Add(this.DT_DateRetour);
            this.panel2.Controls.Add(this.DT_DatePret);
            this.panel2.Controls.Add(this.TB_IdMembre);
            this.panel2.Controls.Add(this.TB_IdMaterielPret);
            this.panel2.Controls.Add(this.btn_ajoutpret);
            this.panel2.Controls.Add(this.label_IDMembre);
            this.panel2.Controls.Add(this.label_id_Materiel);
            this.panel2.Location = new System.Drawing.Point(706, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 328);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Etat Retour";
            // 
            // comboBox_EtatRetour
            // 
            this.comboBox_EtatRetour.FormattingEnabled = true;
            this.comboBox_EtatRetour.Items.AddRange(new object[] {
            "En cours",
            "Neuf",
            "Bon État",
            "Abîmé"});
            this.comboBox_EtatRetour.Location = new System.Drawing.Point(82, 215);
            this.comboBox_EtatRetour.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_EtatRetour.Name = "comboBox_EtatRetour";
            this.comboBox_EtatRetour.Size = new System.Drawing.Size(92, 21);
            this.comboBox_EtatRetour.TabIndex = 20;
            // 
            // comboBox_EtatPret
            // 
            this.comboBox_EtatPret.FormattingEnabled = true;
            this.comboBox_EtatPret.Items.AddRange(new object[] {
            "Neuf",
            "Bon État",
            "Abîmé"});
            this.comboBox_EtatPret.Location = new System.Drawing.Point(82, 180);
            this.comboBox_EtatPret.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_EtatPret.Name = "comboBox_EtatPret";
            this.comboBox_EtatPret.Size = new System.Drawing.Size(92, 21);
            this.comboBox_EtatPret.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Etat Pret :";
            // 
            // label_DateRetour
            // 
            this.label_DateRetour.AutoSize = true;
            this.label_DateRetour.Location = new System.Drawing.Point(8, 153);
            this.label_DateRetour.Name = "label_DateRetour";
            this.label_DateRetour.Size = new System.Drawing.Size(71, 13);
            this.label_DateRetour.TabIndex = 17;
            this.label_DateRetour.Text = "Date Retour :";
            // 
            // label_DatePrêt
            // 
            this.label_DatePrêt.AutoSize = true;
            this.label_DatePrêt.Location = new System.Drawing.Point(8, 116);
            this.label_DatePrêt.Name = "label_DatePrêt";
            this.label_DatePrêt.Size = new System.Drawing.Size(58, 13);
            this.label_DatePrêt.TabIndex = 16;
            this.label_DatePrêt.Text = "Date Prêt :";
            // 
            // DT_DateRetour
            // 
            this.DT_DateRetour.Location = new System.Drawing.Point(82, 147);
            this.DT_DateRetour.Margin = new System.Windows.Forms.Padding(2);
            this.DT_DateRetour.Name = "DT_DateRetour";
            this.DT_DateRetour.Size = new System.Drawing.Size(172, 20);
            this.DT_DateRetour.TabIndex = 15;
            // 
            // DT_DatePret
            // 
            this.DT_DatePret.Location = new System.Drawing.Point(83, 110);
            this.DT_DatePret.Margin = new System.Windows.Forms.Padding(2);
            this.DT_DatePret.Name = "DT_DatePret";
            this.DT_DatePret.Size = new System.Drawing.Size(170, 20);
            this.DT_DatePret.TabIndex = 14;
            // 
            // label_AjoutMat
            // 
            this.label_AjoutMat.AutoSize = true;
            this.label_AjoutMat.Location = new System.Drawing.Point(763, 72);
            this.label_AjoutMat.Name = "label_AjoutMat";
            this.label_AjoutMat.Size = new System.Drawing.Size(144, 13);
            this.label_AjoutMat.TabIndex = 14;
            this.label_AjoutMat.Text = "Ajouter un matériel au stock :";
            // 
            // label_AjoutPrêt
            // 
            this.label_AjoutPrêt.AutoSize = true;
            this.label_AjoutPrêt.Location = new System.Drawing.Point(780, 460);
            this.label_AjoutPrêt.Name = "label_AjoutPrêt";
            this.label_AjoutPrêt.Size = new System.Drawing.Size(127, 13);
            this.label_AjoutPrêt.TabIndex = 15;
            this.label_AjoutPrêt.Text = "Ajouter un nouveau prêt :";
            // 
            // Tableau_StockMat
            // 
            this.Tableau_StockMat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idMateriel,
            this.libelle,
            this.marque,
            this.QTE_Totale,
            this.QTE_Disponible,
            this.Mono_Pointure,
            this.COM_taille,
            this.COM_épaisseur});
            this.Tableau_StockMat.GridLines = true;
            this.Tableau_StockMat.HideSelection = false;
            this.Tableau_StockMat.Location = new System.Drawing.Point(5, 94);
            this.Tableau_StockMat.Margin = new System.Windows.Forms.Padding(2);
            this.Tableau_StockMat.MultiSelect = false;
            this.Tableau_StockMat.Name = "Tableau_StockMat";
            this.Tableau_StockMat.Size = new System.Drawing.Size(660, 323);
            this.Tableau_StockMat.TabIndex = 16;
            this.Tableau_StockMat.UseCompatibleStateImageBehavior = false;
            this.Tableau_StockMat.View = System.Windows.Forms.View.Details;
            // 
            // idMateriel
            // 
            this.idMateriel.Text = "id Matériel";
            // 
            // libelle
            // 
            this.libelle.Text = "Libelle";
            this.libelle.Width = 68;
            // 
            // marque
            // 
            this.marque.Text = "Marque";
            this.marque.Width = 72;
            // 
            // QTE_Totale
            // 
            this.QTE_Totale.Text = "Quantité Totale";
            this.QTE_Totale.Width = 87;
            // 
            // QTE_Disponible
            // 
            this.QTE_Disponible.Text = "Quantité Disponible";
            this.QTE_Disponible.Width = 106;
            // 
            // Mono_Pointure
            // 
            this.Mono_Pointure.Text = "Pointure";
            // 
            // COM_taille
            // 
            this.COM_taille.Text = "Taille";
            // 
            // COM_épaisseur
            // 
            this.COM_épaisseur.Text = "épaisseur";
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
            this.Tableau_Prêt.Location = new System.Drawing.Point(5, 460);
            this.Tableau_Prêt.Margin = new System.Windows.Forms.Padding(2);
            this.Tableau_Prêt.MultiSelect = false;
            this.Tableau_Prêt.Name = "Tableau_Prêt";
            this.Tableau_Prêt.Size = new System.Drawing.Size(660, 348);
            this.Tableau_Prêt.TabIndex = 17;
            this.Tableau_Prêt.UseCompatibleStateImageBehavior = false;
            this.Tableau_Prêt.View = System.Windows.Forms.View.Details;
            // 
            // ID_Prêt
            // 
            this.ID_Prêt.Text = "ID Prêt";
            // 
            // idMembre
            // 
            this.idMembre.Text = "ID Membre";
            this.idMembre.Width = 91;
            // 
            // IDMatériel
            // 
            this.IDMatériel.Text = "ID Matériel";
            this.IDMatériel.Width = 89;
            // 
            // DatePrêt
            // 
            this.DatePrêt.Text = "Date Prêt";
            this.DatePrêt.Width = 100;
            // 
            // DateRetour
            // 
            this.DateRetour.Text = "Date Retour";
            this.DateRetour.Width = 109;
            // 
            // Etat_Prêt
            // 
            this.Etat_Prêt.Text = "Etat Prêt";
            this.Etat_Prêt.Width = 90;
            // 
            // Etat_Retour
            // 
            this.Etat_Retour.Text = "Etat Retour";
            this.Etat_Retour.Width = 116;
            // 
            // label_stockmat
            // 
            this.label_stockmat.AutoSize = true;
            this.label_stockmat.Location = new System.Drawing.Point(266, 72);
            this.label_stockmat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_stockmat.Name = "label_stockmat";
            this.label_stockmat.Size = new System.Drawing.Size(89, 13);
            this.label_stockmat.TabIndex = 18;
            this.label_stockmat.Text = "Stock du matériel";
            // 
            // label_listeprêt
            // 
            this.label_listeprêt.AutoSize = true;
            this.label_listeprêt.Location = new System.Drawing.Point(285, 440);
            this.label_listeprêt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_listeprêt.Name = "label_listeprêt";
            this.label_listeprêt.Size = new System.Drawing.Size(70, 13);
            this.label_listeprêt.TabIndex = 19;
            this.label_listeprêt.Text = "Liste des prêt";
            // 
            // btn_Retour
            // 
            this.btn_Retour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Retour.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Retour.Depth = 0;
            this.btn_Retour.HighEmphasis = true;
            this.btn_Retour.Icon = null;
            this.btn_Retour.Location = new System.Drawing.Point(1067, 70);
            this.btn_Retour.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Retour.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Retour.Name = "btn_Retour";
            this.btn_Retour.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Retour.Size = new System.Drawing.Size(259, 36);
            this.btn_Retour.TabIndex = 20;
            this.btn_Retour.Text = "Retourner au menu principale";
            this.btn_Retour.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Retour.UseAccentColor = false;
            this.btn_Retour.UseVisualStyleBackColor = true;
            this.btn_Retour.Click += new System.EventHandler(this.btn_Retour_Click);
            // 
            // StockMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1333, 827);
            this.Controls.Add(this.btn_Retour);
            this.Controls.Add(this.label_listeprêt);
            this.Controls.Add(this.label_stockmat);
            this.Controls.Add(this.Tableau_Prêt);
            this.Controls.Add(this.Tableau_StockMat);
            this.Controls.Add(this.label_AjoutPrêt);
            this.Controls.Add(this.label_AjoutMat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1333, 827);
            this.Name = "StockMateriel";
            this.Text = "Stock matériel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Libelle;
        private System.Windows.Forms.Label label_pointure;
        private System.Windows.Forms.Label label_marque;
        private System.Windows.Forms.Label label_qteTotale;
        private System.Windows.Forms.Label label_qteDisponible;
        private System.Windows.Forms.Label label_taille;
        private System.Windows.Forms.Label label_épaisseur;
        private MaterialSkin.Controls.MaterialButton btn_AjoutMateriel;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox TB_épaisseur;
        private MaterialSkin.Controls.MaterialMultiLineTextBox TB_taille;
        private MaterialSkin.Controls.MaterialMultiLineTextBox TB_Pointure;
        private MaterialSkin.Controls.MaterialMultiLineTextBox TB_QTED;
        private MaterialSkin.Controls.MaterialMultiLineTextBox TB_QTET;
        private MaterialSkin.Controls.MaterialMultiLineTextBox TB_Marque;
        private MaterialSkin.Controls.MaterialMultiLineTextBox TB_Libelle;
        private System.Windows.Forms.Label label_id_Materiel;
        private System.Windows.Forms.Label label_IDMembre;
        private MaterialSkin.Controls.MaterialButton btn_ajoutpret;
        private MaterialSkin.Controls.MaterialMultiLineTextBox TB_IdMaterielPret;
        private MaterialSkin.Controls.MaterialMultiLineTextBox TB_IdMembre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_DatePrêt;
        private System.Windows.Forms.DateTimePicker DT_DateRetour;
        private System.Windows.Forms.DateTimePicker DT_DatePret;
        private System.Windows.Forms.Label label_DateRetour;
        private System.Windows.Forms.Label label_AjoutMat;
        private System.Windows.Forms.Label label_AjoutPrêt;
        private System.Windows.Forms.ListView Tableau_StockMat;
        private System.Windows.Forms.ColumnHeader idMateriel;
        private System.Windows.Forms.ColumnHeader libelle;
        private System.Windows.Forms.ColumnHeader marque;
        private System.Windows.Forms.ColumnHeader QTE_Totale;
        private System.Windows.Forms.ColumnHeader QTE_Disponible;
        private System.Windows.Forms.ColumnHeader Mono_Pointure;
        private System.Windows.Forms.ColumnHeader COM_taille;
        private System.Windows.Forms.ColumnHeader COM_épaisseur;
        private System.Windows.Forms.ListView Tableau_Prêt;
        private System.Windows.Forms.ColumnHeader ID_Prêt;
        private System.Windows.Forms.ColumnHeader idMembre;
        private System.Windows.Forms.ColumnHeader IDMatériel;
        private System.Windows.Forms.ColumnHeader DatePrêt;
        private System.Windows.Forms.ColumnHeader DateRetour;
        private System.Windows.Forms.ColumnHeader Etat_Prêt;
        private System.Windows.Forms.ColumnHeader Etat_Retour;
        private System.Windows.Forms.Label label_stockmat;
        private System.Windows.Forms.Label label_listeprêt;
        private MaterialSkin.Controls.MaterialButton btn_Retour;
        private System.Windows.Forms.ComboBox comboBox_TypeMateriel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_EtatRetour;
        private System.Windows.Forms.ComboBox comboBox_EtatPret;
        private System.Windows.Forms.Label label1;
    }
}
