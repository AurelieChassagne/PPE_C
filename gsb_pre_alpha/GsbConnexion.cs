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
            if (ConnexionValideLogin() == false)
            {
                lblRep.Text = "Votre login est incorrect";
            }
            else if (ConnexionValideMdp() == false)
            {
                lblRep.Text = "Votre mdp est incorrect";
            }
            else
            {
                GsbAccueil frm = new GsbAccueil();
                frm.Show();
            }
        }
        /// <summary>
        /// Verifie si le login existe
        /// </summary>
        /// <returns>vrai si la base de donnée contient se login</returns>
        private bool ConnexionValideLogin()
        {
            bool rep = false;
            List<Gestionnaire> LesGestionnaire = DAOGestionnaire.ChargerGestionnaire();
            for (int i = 0; i < LesGestionnaire.Count(); i++)
            {
                if (LesGestionnaire[i].GetLogin() == txtLogin.Text)
                {
                    rep = true;
                }
            }
            return rep;
        }
        /// <summary>
        /// Permet de vérifier que le mot de passe existe
        /// </summary>
        /// <returns>vrai si la base de données contient se login</returns>
        private bool ConnexionValideMdp()
        {
            bool rep = false;
            List<Gestionnaire> LesGestionnaire = DAOGestionnaire.ChargerGestionnaire();
            for (int i = 0; i < LesGestionnaire.Count(); i++)
            {
                if (LesGestionnaire[i].GetMdp() == txtMdp.Text)
                {
                    rep = true;
                }
            }
            return rep;
        }
    }
}
