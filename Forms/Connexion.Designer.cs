namespace LyonPalmeForms
{
    partial class ConnexionForms
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnexionForms));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.MMLTextBox_mdp = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.MLabel_mdp = new MaterialSkin.Controls.MaterialLabel();
            this.MMLTextBox_id = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.LogoLP = new System.Windows.Forms.PictureBox();
            this.MaterialLabelid = new MaterialSkin.Controls.MaterialLabel();
            this.MButton_annuler = new MaterialSkin.Controls.MaterialButton();
            this.MButton_connexion = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoLP)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.MMLTextBox_mdp);
            this.materialCard1.Controls.Add(this.MLabel_mdp);
            this.materialCard1.Controls.Add(this.MMLTextBox_id);
            this.materialCard1.Controls.Add(this.LogoLP);
            this.materialCard1.Controls.Add(this.MaterialLabelid);
            this.materialCard1.Controls.Add(this.MButton_annuler);
            this.materialCard1.Controls.Add(this.MButton_connexion);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(75, 135);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1189, 627);
            this.materialCard1.TabIndex = 0;
            // 
            // MMLTextBox_mdp
            // 
            this.MMLTextBox_mdp.AnimateReadOnly = false;
            this.MMLTextBox_mdp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MMLTextBox_mdp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MMLTextBox_mdp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MMLTextBox_mdp.Depth = 0;
            this.MMLTextBox_mdp.HideSelection = true;
            this.MMLTextBox_mdp.Location = new System.Drawing.Point(736, 280);
            this.MMLTextBox_mdp.MaxLength = 32767;
            this.MMLTextBox_mdp.MouseState = MaterialSkin.MouseState.OUT;
            this.MMLTextBox_mdp.Name = "MMLTextBox_mdp";
            this.MMLTextBox_mdp.PasswordChar = '*';
            this.MMLTextBox_mdp.ReadOnly = false;
            this.MMLTextBox_mdp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MMLTextBox_mdp.SelectedText = "";
            this.MMLTextBox_mdp.SelectionLength = 0;
            this.MMLTextBox_mdp.SelectionStart = 0;
            this.MMLTextBox_mdp.ShortcutsEnabled = true;
            this.MMLTextBox_mdp.Size = new System.Drawing.Size(306, 49);
            this.MMLTextBox_mdp.TabIndex = 7;
            this.MMLTextBox_mdp.TabStop = false;
            this.MMLTextBox_mdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MMLTextBox_mdp.UseSystemPasswordChar = false;
            this.MMLTextBox_mdp.Click += new System.EventHandler(this.MMLTextBox_mdp_Click);
            // 
            // MLabel_mdp
            // 
            this.MLabel_mdp.Depth = 0;
            this.MLabel_mdp.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MLabel_mdp.Location = new System.Drawing.Point(737, 246);
            this.MLabel_mdp.MouseState = MaterialSkin.MouseState.HOVER;
            this.MLabel_mdp.Name = "MLabel_mdp";
            this.MLabel_mdp.Size = new System.Drawing.Size(139, 31);
            this.MLabel_mdp.TabIndex = 6;
            this.MLabel_mdp.Text = "Mot de passe :";
            // 
            // MMLTextBox_id
            // 
            this.MMLTextBox_id.AnimateReadOnly = false;
            this.MMLTextBox_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MMLTextBox_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MMLTextBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MMLTextBox_id.Depth = 0;
            this.MMLTextBox_id.HideSelection = true;
            this.MMLTextBox_id.Location = new System.Drawing.Point(736, 173);
            this.MMLTextBox_id.MaxLength = 32767;
            this.MMLTextBox_id.MouseState = MaterialSkin.MouseState.OUT;
            this.MMLTextBox_id.Name = "MMLTextBox_id";
            this.MMLTextBox_id.PasswordChar = '\0';
            this.MMLTextBox_id.ReadOnly = false;
            this.MMLTextBox_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MMLTextBox_id.SelectedText = "";
            this.MMLTextBox_id.SelectionLength = 0;
            this.MMLTextBox_id.SelectionStart = 0;
            this.MMLTextBox_id.ShortcutsEnabled = true;
            this.MMLTextBox_id.Size = new System.Drawing.Size(306, 49);
            this.MMLTextBox_id.TabIndex = 5;
            this.MMLTextBox_id.TabStop = false;
            this.MMLTextBox_id.Text = "Idantifiant";
            this.MMLTextBox_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MMLTextBox_id.UseSystemPasswordChar = false;
            this.MMLTextBox_id.Click += new System.EventHandler(this.MMLTextBox_id_Click);
            // 
            // LogoLP
            // 
            this.LogoLP.Image = global::LyonPalmeForms.Properties.Resources.LyonPalme;
            this.LogoLP.Location = new System.Drawing.Point(0, 0);
            this.LogoLP.Name = "LogoLP";
            this.LogoLP.Size = new System.Drawing.Size(626, 627);
            this.LogoLP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoLP.TabIndex = 4;
            this.LogoLP.TabStop = false;
            // 
            // MaterialLabelid
            // 
            this.MaterialLabelid.Depth = 0;
            this.MaterialLabelid.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaterialLabelid.Location = new System.Drawing.Point(737, 139);
            this.MaterialLabelid.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialLabelid.Name = "MaterialLabelid";
            this.MaterialLabelid.Size = new System.Drawing.Size(139, 31);
            this.MaterialLabelid.TabIndex = 2;
            this.MaterialLabelid.Text = "Identifiant :";
            // 
            // MButton_annuler
            // 
            this.MButton_annuler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MButton_annuler.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MButton_annuler.Depth = 0;
            this.MButton_annuler.HighEmphasis = true;
            this.MButton_annuler.Icon = null;
            this.MButton_annuler.Location = new System.Drawing.Point(736, 369);
            this.MButton_annuler.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MButton_annuler.MouseState = MaterialSkin.MouseState.HOVER;
            this.MButton_annuler.Name = "MButton_annuler";
            this.MButton_annuler.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MButton_annuler.Size = new System.Drawing.Size(87, 36);
            this.MButton_annuler.TabIndex = 1;
            this.MButton_annuler.Text = "Annuler";
            this.MButton_annuler.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MButton_annuler.UseAccentColor = false;
            this.MButton_annuler.UseVisualStyleBackColor = true;
            this.MButton_annuler.Click += new System.EventHandler(this.MButton_annuler_Click);
            // 
            // MButton_connexion
            // 
            this.MButton_connexion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MButton_connexion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MButton_connexion.Depth = 0;
            this.MButton_connexion.HighEmphasis = true;
            this.MButton_connexion.Icon = null;
            this.MButton_connexion.Location = new System.Drawing.Point(937, 369);
            this.MButton_connexion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MButton_connexion.MouseState = MaterialSkin.MouseState.HOVER;
            this.MButton_connexion.Name = "MButton_connexion";
            this.MButton_connexion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MButton_connexion.Size = new System.Drawing.Size(105, 36);
            this.MButton_connexion.TabIndex = 0;
            this.MButton_connexion.Text = "Connexion";
            this.MButton_connexion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MButton_connexion.UseAccentColor = false;
            this.MButton_connexion.UseVisualStyleBackColor = true;
            this.MButton_connexion.Click += new System.EventHandler(this.MButton_connexion_Click);
            // 
            // ConnexionForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1333, 827);
            this.Controls.Add(this.materialCard1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1333, 827);
            this.Name = "ConnexionForms";
            this.Text = "Connexion à LyonPalme";
            this.Load += new System.EventHandler(this.ConnexionForms_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoLP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton MButton_connexion;
        private MaterialSkin.Controls.MaterialLabel MaterialLabelid;
        private MaterialSkin.Controls.MaterialButton MButton_annuler;
        private System.Windows.Forms.PictureBox LogoLP;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 MMLTextBox_id;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 MMLTextBox_mdp;
        private MaterialSkin.Controls.MaterialLabel MLabel_mdp;
    }
}

