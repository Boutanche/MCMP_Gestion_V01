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
            this.label_Chargement = new System.Windows.Forms.Label();
            this.progressBar_Chargement = new System.Windows.Forms.ProgressBar();
            this.button_Launch = new System.Windows.Forms.Button();
            this.button_Fermeture = new System.Windows.Forms.Button();
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
            // label_Chargement
            // 
            this.label_Chargement.AccessibleDescription = "Chargement";
            this.label_Chargement.AccessibleName = "Chargement";
            this.label_Chargement.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.label_Chargement.AutoSize = true;
            this.label_Chargement.BackColor = System.Drawing.Color.Transparent;
            this.label_Chargement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Chargement.ForeColor = System.Drawing.Color.White;
            this.label_Chargement.Location = new System.Drawing.Point(12, 244);
            this.label_Chargement.Name = "label_Chargement";
            this.label_Chargement.Size = new System.Drawing.Size(105, 20);
            this.label_Chargement.TabIndex = 1;
            this.label_Chargement.Text = "Chargement :";
            // 
            // progressBar_Chargement
            // 
            this.progressBar_Chargement.ForeColor = System.Drawing.Color.Red;
            this.progressBar_Chargement.Location = new System.Drawing.Point(15, 443);
            this.progressBar_Chargement.Name = "progressBar_Chargement";
            this.progressBar_Chargement.Size = new System.Drawing.Size(471, 10);
            this.progressBar_Chargement.Step = 1;
            this.progressBar_Chargement.TabIndex = 2;
            // 
            // button_Launch
            // 
            this.button_Launch.AccessibleDescription = "Boutton Lancement";
            this.button_Launch.AccessibleName = "Lancer l\'application";
            this.button_Launch.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.button_Launch.AutoSize = true;
            this.button_Launch.BackColor = System.Drawing.Color.Lime;
            this.button_Launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Launch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Launch.ForeColor = System.Drawing.Color.Transparent;
            this.button_Launch.Location = new System.Drawing.Point(130, 12);
            this.button_Launch.Name = "button_Launch";
            this.button_Launch.Size = new System.Drawing.Size(117, 31);
            this.button_Launch.TabIndex = 3;
            this.button_Launch.Text = "Commencer";
            this.button_Launch.UseVisualStyleBackColor = false;
            this.button_Launch.Click += new System.EventHandler(this.button_Launch_Click);
            // 
            // button_Fermeture
            // 
            this.button_Fermeture.AccessibleDescription = "Boutton Fermeture";
            this.button_Fermeture.AccessibleName = "Fermer l\'application";
            this.button_Fermeture.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.button_Fermeture.AutoSize = true;
            this.button_Fermeture.BackColor = System.Drawing.Color.Red;
            this.button_Fermeture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Fermeture.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Fermeture.ForeColor = System.Drawing.Color.Transparent;
            this.button_Fermeture.Location = new System.Drawing.Point(253, 12);
            this.button_Fermeture.Name = "button_Fermeture";
            this.button_Fermeture.Size = new System.Drawing.Size(117, 31);
            this.button_Fermeture.TabIndex = 4;
            this.button_Fermeture.Text = "Fermer";
            this.button_Fermeture.UseVisualStyleBackColor = false;
            this.button_Fermeture.Click += new System.EventHandler(this.button_Fermeture_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = global::MCMP_Gestion_V01.Properties.Resources.contact_form_500x470;
            this.ClientSize = new System.Drawing.Size(500, 470);
            this.ControlBox = false;
            this.Controls.Add(this.button_Fermeture);
            this.Controls.Add(this.button_Launch);
            this.Controls.Add(this.progressBar_Chargement);
            this.Controls.Add(this.label_Chargement);
            this.Controls.Add(this.pictureBox_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCMP Gestion (v 0.1)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Label label_Chargement;
        private System.Windows.Forms.ProgressBar progressBar_Chargement;
        private System.Windows.Forms.Button button_Launch;
        private System.Windows.Forms.Button button_Fermeture;
    }
}

