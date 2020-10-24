using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMP_Gestion_V01
{
    public partial class FormApplication : Form
    {
        internal bool fermeture { get; private set; }
        public FormApplication()
        {
            InitializeComponent();
        }

        private void FormApplication_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Init var :
            string message = "Confirmez vous la fermeture de l'application ?";
            string titre = "Confirmer la fermeture ?";
            //MessageBox :
            DialogResult result = MessageBox.Show(message, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            fermeture = true;
            //Action on Btn1 or Btn2
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                fermeture = false;
            }
            
        }

        private void FormApplication_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
