using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicationGSB
{
    class Secteur
    {

        #region Variables privées
        private int id;
        private string nom;
        #endregion

        #region Constructeur
        public Secteur(int unId, string unNom)
        {
            this.id = unId;
            this.nom = unNom;
        }

        public Secteur(string unNom)
        {
            this.nom = unNom;
        }

        public Secteur(int unId)
        {
            this.id = unId;
        }
        #endregion

        #region Getters & Setters
        public int GetId()
        {
            return this.id;
        }
        public String GetNom()
        {
            return this.nom;
        }
        #endregion
    }
}
