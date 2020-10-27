using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MCMP_Gestion_V01
{
    public partial class FormApplication : Form
    {
        /// <summary>
        /// Constantes : But pédagogique
        //TODO : Multi-Langues
        /// </summary>
        #region Constantes :
        private const string MESS_FR = "Confirmer vous la fermeture de l'application ?";
        private const string TITLE_FR = "Confirmer la fermerture ?";
        #endregion

        internal bool fermeture { get; private set; }
        
        public FormApplication()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Avant fermeture de l'application / Demander confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormApplication_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox :
            DialogResult result = MessageBox.Show(MESS_FR, TITLE_FR, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            fermeture = true;
            //Action on Btn1 or Btn2
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                fermeture = false;
            }
            
        }
        /// <summary>
        /// Bouton Quitter l'application :
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ParamQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cda35bd2DataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            String query = "select * from ACT";
            MySqlCommand mySqlCommand = new MySqlCommand(query);
        }

        private void FormApplication_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'cda35_bd2DataSet1.ACT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.aCTTableAdapter.Fill(this.cda35_bd2DataSet1.ACT);

        }
    }
}
