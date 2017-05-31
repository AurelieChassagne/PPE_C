using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_praticiens
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
                reader = DAOFactory.execRead("SELECT id, nom FROM Specialite");
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
                DAOFactory.execWrite("INSERT INTO Specialite SELECT id, nom) VALUES ('" + spe.Id + "', '" + spe.Nom + "');");
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
                DAOFactory.execWrite("DELETE FROM Specialite WHERE Id = " + spe.Id + "");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return false;
        }

        public static Boolean ModifierSpecialite(Specialite spe)
        {
            Boolean test = false;
            try
            {
                DAOFactory.execWrite("UPDATE Specialite SET Id = '" + spe.Id + "', Nom = '" + spe.Nom +"';");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return false;
        }

    }
}
