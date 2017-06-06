using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicationGSB
{
    class Visiteur
    {
        #region Variables privées
        private int id;
        private string nom;
        private string prenom;
        private string type;
        private string login;
        private string mdp;
        private string adresse;
        private string cp;
        public string dateEmbauche;
        private string ville;
        private int idSecteur;


        #endregion

        #region Constructeur

        public Visiteur(int id, string nom, string prenom, string type, string adresse, string cp, string ville, string dateEmbauche, string login, string mdp, int idSecteur)
        {
            this.id = id;
            this.type = type;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.mdp = mdp;
            this.adresse = adresse;
            this.cp = cp;
            this.dateEmbauche = dateEmbauche;
            this.ville = ville;
            this.idSecteur = idSecteur;
           
        }
        #endregion

        #region Getters & Setters

        public int getId()
        {
            return this.id;
        }

        public string getType()
        {
            return this.type;
        }

        public string getNom()
        {
            return this.nom;
        }

        public string getPrenom()
        {
            return this.prenom;
        }

        public string getLogin()
        {
            return this.login;
        }

        public string getMotDePasse()
        {
            return this.mdp;
        }

        public string getAdresse()
        {
            return this.adresse;
        }

        public string getCP()
        {
            return this.cp;
        }

        public string getDateEmbauche()
        {
            return this.dateEmbauche;
        }

        public string getVille()
        {
            return this.ville;
        }

        public int getIdSecteur()
        {
            return this.idSecteur;
        }

        #endregion
    }
}