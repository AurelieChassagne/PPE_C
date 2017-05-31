using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsb_pre_alpha
{
    public partial class GSBConnexion : Form
    {
        public GSBConnexion()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Permet de verifier si le login, le mots de passe existe dans la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnection_Click(object sender, EventArgs e)
        {
            if(DAOGestionnaire.VerificationLoginMdp(txtLogin.Text, txtMdp.Text) == false)
            {
                lblRep.Text = "Votre login ou mot de passe est incorrect";
            }
            else
            {
                GsbAccueil frm = new GsbAccueil();
                frm.Show();
            }
        }
    }
}
