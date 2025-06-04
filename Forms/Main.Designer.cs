namespace LyonPalmeForms
{
    partial class Main
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btn_materielprêté = new MaterialSkin.Controls.MaterialButton();
            this.btn_visualstock = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelidMain = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btn_materielprêté);
            this.materialCard1.Controls.Add(this.btn_visualstock);
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Controls.Add(this.LabelidMain);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1299, 629);
            this.materialCard1.TabIndex = 6;
            // 
            // btn_materielprêté
            // 
            this.btn_materielprêté.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_materielprêté.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_materielprêté.Depth = 0;
            this.btn_materielprêté.HighEmphasis = true;
            this.btn_materielprêté.Icon = null;
            this.btn_materielprêté.Location = new System.Drawing.Point(853, 289);
            this.btn_materielprêté.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_materielprêté.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_materielprêté.Name = "btn_materielprêté";
            this.btn_materielprêté.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_materielprêté.Size = new System.Drawing.Size(181, 36);
            this.btn_materielprêté.TabIndex = 6;
            this.btn_materielprêté.Text = "Liste matériel prêté";
            this.btn_materielprêté.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_materielprêté.UseAccentColor = false;
            this.btn_materielprêté.UseVisualStyleBackColor = true;
            this.btn_materielprêté.Click += new System.EventHandler(this.btn_materielprêté_Click);
            // 
            // btn_visualstock
            // 
            this.btn_visualstock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_visualstock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_visualstock.Depth = 0;
            this.btn_visualstock.HighEmphasis = true;
            this.btn_visualstock.Icon = null;
            this.btn_visualstock.Location = new System.Drawing.Point(854, 215);
            this.btn_visualstock.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_visualstock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_visualstock.Name = "btn_visualstock";
            this.btn_visualstock.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_visualstock.Size = new System.Drawing.Size(172, 36);
            this.btn_visualstock.TabIndex = 5;
            this.btn_visualstock.Text = "Visualiser le stock";
            this.btn_visualstock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_visualstock.UseAccentColor = false;
            this.btn_visualstock.UseVisualStyleBackColor = true;
            this.btn_visualstock.Click += new System.EventHandler(this.btn_visualstock_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LyonPalmeForms.Properties.Resources.LyonPalme;
            this.pictureBox1.Location = new System.Drawing.Point(0, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 627);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LabelidMain
            // 
            this.LabelidMain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LabelidMain.Depth = 0;
            this.LabelidMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelidMain.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelidMain.Location = new System.Drawing.Point(852, 150);
            this.LabelidMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelidMain.Name = "LabelidMain";
            this.LabelidMain.Size = new System.Drawing.Size(217, 35);
            this.LabelidMain.TabIndex = 2;
            this.LabelidMain.Text = "Que voulez-vous faire ?";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 827);
            this.Controls.Add(this.materialCard1);
            this.MinimumSize = new System.Drawing.Size(1333, 827);
            this.Name = "Main";
            this.Text = "Main";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel LabelidMain;
        private MaterialSkin.Controls.MaterialButton btn_visualstock;
        private MaterialSkin.Controls.MaterialButton btn_materielprêté;
    }
}
