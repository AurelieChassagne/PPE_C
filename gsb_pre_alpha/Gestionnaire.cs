using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsb_pre_alpha
{
    class Gestionnaire
    {
        #region Variables privées
        private string login;
        private string mdp;
        #endregion

        #region Constructeur
        public Gestionnaire(string unLogin, string unMdp)
        {
            this.login = unLogin;
            this.mdp = unMdp;
        }
        
        #endregion
        public string GetLogin()
        {
            return this.login;
        }
        public String GetMdp()
        {
            return this.mdp;
        }
    }
}
