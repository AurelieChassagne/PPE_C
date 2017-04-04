using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicationGSB
{
    class Produit
    {
        #region Variables privées
        private int reference;
        private string nom;
        private string dosage;
        private double prix;
        private string contreIndication;
        private string effetTherapeutique;
        private int idFamille;
        #endregion

        #region Constructeur
        public Produit(int uneRef, string unNom, string unDosage, double unPrix,
            string uneContreIndication, string unEffet, int unIdFamille)
        {
            this.reference = uneRef;
            this.nom = unNom;
            this.dosage = unDosage;
            this.prix = unPrix;
            this.contreIndication = uneContreIndication;
            this.effetTherapeutique = unEffet;
            this.idFamille = unIdFamille;
        }

        public Produit(int uneRef)
        {
            this.reference = uneRef;
        }

        public Produit(string unNom, string unDosage, double unPrix,
            string uneContreIndication, string unEffet, int unIdFamille)
        {
            this.nom = unNom;
            this.dosage = unDosage;
            this.prix = unPrix;
            this.contreIndication = uneContreIndication;
            this.effetTherapeutique = unEffet;
            this.idFamille = unIdFamille;
        }
        #endregion
        public int GetReference()
        {
            return this.reference;
        }
        public String GetNom()
        {
            return this.nom;
        }
        public int GetIdFamille()
        {
            return this.idFamille;
        }
        public String GetEfets()
        {
            return this.effetTherapeutique;
        }
        public String GetContreIndic()
        {
            return this.contreIndication;
        }
        public String GetDosage()
        {
            return this.dosage;
        }
        public double Getprix()
        {
            return this.prix;
        }
    }
}
