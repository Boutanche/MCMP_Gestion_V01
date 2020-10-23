namespace MCMP_Gestion_V01
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.AccessibleDescription = "Logo du MCMP";
            this.pictureBox_Logo.AccessibleName = "Logo MCMP";
            this.pictureBox_Logo.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.pictureBox_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Logo.BackgroundImage = global::MCMP_Gestion_V01.Properties.Resources.logo;
            this.pictureBox_Logo.Image = global::MCMP_Gestion_V01.Properties.Resources.logo;
            this.pictureBox_Logo.Location = new System.Drawing.Point(12, 183);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(173, 47);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MCMP_Gestion_V01.Properties.Resources.contact_form_500x470;
            this.ClientSize = new System.Drawing.Size(500, 470);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCMP Gestion (v 0.1)";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Logo;
    }
}

