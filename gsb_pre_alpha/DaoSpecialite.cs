using gsb_pre_alpha;
using PreparationBaseDeDonne;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicationGSB
{
    class DaoSpecialite 
    {

        private static DAOFactory connexion = new DAOFactory();

        public DaoSpecialite() { }

        //Méthode permettant de créer une liste d'objet Specialite contenant les données de la base de données
        public static List<Specialite> chargerSpecialite()
        {
            List<Specialite> lesSpecialites = new List<Specialite>();

            try
            {
                SqlDataReader reader;
                reader = connexion.execRead("SELECT id, nom FROM Specialite");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Specialite m = new Specialite(reader.GetInt32(0), reader.GetString(1));
                        lesSpecialites.Add(m);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return lesSpecialites;

        }

        public static Boolean CreerSpecialite(Specialite spe)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Specialite SELECT id, nom) VALUES ('" + spe.Id + "', '" + spe.Nom + "');");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }

        public static Boolean SupprimerSpecialite(Specialite spe)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("DELETE FROM Specialite WHERE Id = " + spe.Id + "");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }

        public static Boolean ModifierSpecialite(Specialite spe)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Specialite SET Id = '" + spe.Id + "', Nom = '" + spe.Nom +"';");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }


        /// <summary>
        /// Permet de retrouver l'objet spécialite avec son id
        /// </summary>
        /// <param name="idSpe">Passe en paramètre un Produit</param>
        /// <returns>Retourne une Famille par rapport à l'identifiant famille du produit</returns>
        public static Specialite RechercherSpecialiteParId(int idSpe)
        {
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead($"select * from Specialite spe where id = {idSpe}");
                reader.Read();
                Specialite LaSpecialite = new Specialite(reader.GetInt32(0), reader.GetString(1));
                reader.Close();
                return LaSpecialite;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        /// <summary>
        /// Permet de retrouver l'objet spécialite avec un nom
        /// </summary>
        /// <param name="nomSpe">donne un nom pour trouver l'identifiant correspondant</param>
        /// <returns>Retourne une famille par rapport au nom donnée</returns>
        public static Specialite RechercherSpecialiteParNom(string nomSpe)
        {
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead($"select * from Specialite where nom = '{nomSpe}'");
                reader.Read();
                Specialite LaSpecialite = new Specialite(reader.GetInt32(0), reader.GetString(1));
                reader.Close();
                return LaSpecialite;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }


    }
}
