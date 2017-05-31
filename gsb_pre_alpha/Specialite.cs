using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_praticiens
{
    class Specialite 
    {
        private int id;
        private String nom;

        public Specialite(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }
    

    #region Methode BDD
    //Méthode permettant de charger la liste d'objet Specialite
    public static List<Specialite> chargerSpecialite()
    {
        return DaoSpecialite.chargerSpecialite();
    }
    //envoie d'objet
    public static Boolean CreerSpecialite(Specialite spe)
    {
        return DaoSpecialite.CreerSpecialite(spe);
    }

    public static Boolean SupprimerSpecialite(Specialite spe)
    {
        return DaoSpecialite.SupprimerSpecialite(spe);
    }

    public static Boolean ModifierSpecialite(Specialite spe)
    {
        return DaoSpecialite.ModifierSpecialite(spe);
    }

    #endregion
}
}