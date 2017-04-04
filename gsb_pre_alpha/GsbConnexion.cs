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

        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (ConnexionValideLogin() == false)
            {
                lblRep.Text = "Votre login est incorrecte";
            }
            else if (ConnexionValideMdp() == false)
            {
                lblRep.Text = "Votre mdp est incorrecte";
            }
            else
            {
                GsbAccueil frm = new GsbAccueil();
                frm.Show();
            }
        }

        private bool ConnexionValideLogin()
        {
            bool rep = false;
            List<Gestionnaire> LesGestionnaire = DAOGestionnaire.ChargerLogin();
            for (int i = 0; i < LesGestionnaire.Count(); i++)
            {
                if (LesGestionnaire[i].GetLogin() == txtLogin.Text)
                {
                    rep = true;
                }
            }
            return rep;
        }
        private bool ConnexionValideMdp()
        {
            bool rep = false;
            List<Gestionnaire> LesGestionnaire = DAOGestionnaire.ChargerLogin();
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
