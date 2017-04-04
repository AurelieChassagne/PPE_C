using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicationGSB
{
    class Famille
    {

        #region Variables privées
        private int id;
        private string nom;
        #endregion

        #region Constructeur
        public Famille(int unId, string unNom)
        {
            this.id = unId;
            this.nom = unNom;
        }

        public Famille(string unNom)
        {
            this.nom = unNom;
        }

        public Famille(int unId)
        {
            this.id = unId;
        }
        #endregion


        public int GetId()
        {
            return this.id;
        }
        public String GetNom()
        {
            return this.nom;
        }
    }
}
