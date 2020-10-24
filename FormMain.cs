using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMP_Gestion_V01
{
    public partial class FormMain : Form
    {
        public bool charge = false;
        public FormMain()
        {
            InitializeComponent();
        }
        
        private void Chargement()
        {
            progressBar_Chargement.Step = 1;
            progressBar_Chargement.Value = 0;
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50);
                progressBar_Chargement.PerformStep();
            }
            if (progressBar_Chargement.Value == progressBar_Chargement.Maximum)
            {
                charge = true;
            }
        }
        private void Ok()
        {
            if (charge == true)
            {
                this.Opacity = 0;
            }
        }

        private void button_Launch_Click(object sender, EventArgs e)
        {
            Chargement();
            Ok();
            FormApplication formApplication = new FormApplication();
            formApplication.ShowDialog();
            if (formApplication.fermeture == true)
            {
                this.Opacity = 100;
            }
        }

        private void button_Fermeture_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
