using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicationGSB
{
    class Praticiens
    {

        private int code;
        private string raisonSocial;
        private string adresse;
        private string tel;
        private string contactNom;
        private string contactMail;
        private int idSpecialite;
        private double coefNotoriete;
        private double coefConfiance;
        private int v;

        public int Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public string RaisonSocial
        {
            get
            {
                return raisonSocial;
            }

            set
            {
                raisonSocial = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string Tel
        {
            get
            {
                return tel;
            }

            set
            {
                tel = value;
            }
        }

        public string ContactNom
        {
            get
            {
                return contactNom;
            }

            set
            {
                contactNom = value;
            }
        }

        public string ContactMail
        {
            get
            {
                return contactMail;
            }

            set
            {
                contactMail = value;
            }
        }

        public int IdSpecialite
        {
            get
            {
                return idSpecialite;
            }

            set
            {
                idSpecialite = value;
            }
        }

        public double CoefNotoriete
        {
            get
            {
                return coefNotoriete;
            }

            set
            {
                coefNotoriete = value;
            }
        }

        public double CoefConfiance
        {
            get
            {
                return coefConfiance;
            }

            set
            {
                coefConfiance = value;
            }
        }

        public Praticiens(int code, string raisonSocial, string adresse, string tel, string contactNom,
         string contactMail, int idSpecialite, double coefNotoriete, double coefConfiance)
        {
            this.code = code;
            this.raisonSocial = raisonSocial;
            this.adresse = adresse;
            this.tel = tel;
            this.contactNom = contactNom;
            this.contactMail = contactMail;
            this.idSpecialite = idSpecialite;
            this.coefNotoriete = coefNotoriete;
            this.coefConfiance = coefConfiance;
        }

       



        #region Methode BDD
        //Méthode permettant de charger la liste d'objet médicament
        public static List<Praticiens> chargerPraticiens()
        {
            return DaoPraticiens.chargerPraticiens();
        }
        //envoie d'objet
        public static Boolean creerPraticiens(Praticiens prat)
        {
            return DaoPraticiens.CreerPraticiens(prat);
        }

        public static Boolean SupprimerPraticiens(Praticiens prat)
        {
            return DaoPraticiens.SupprimerPraticiens(prat);
        }

        public static Boolean ModifierPraticiens(Praticiens prat)
        {
            return DaoPraticiens.ModifierPraticiens(prat);
        }
    }
    #endregion
}

