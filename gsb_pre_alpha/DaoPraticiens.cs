using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_praticiens
{
    class DaoPraticiens
    {
        private static DAOFactory connexion = new DAOFactory();

        public DaoPraticiens() { }

        //Méthode permettant de créer une liste d'objet Praticiens contenant les données de la base de données
        public static List<Praticiens> chargerPraticiens()
        {
            List<Praticiens> lesPraticiens = new List<Praticiens>();

            try
            {
                SqlDataReader reader;
                reader = DAOFactory.execRead("SELECT Code, RaisonSociale, Adresse, Telephone, ContactNom, ContactAdressseMail, idSpecialite, CoefficientNotoriete, Coefficientconfiance FROM Praticiens");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Praticiens m = new Praticiens(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8));
                        lesPraticiens.Add(m);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return lesPraticiens;

        }

        public static Boolean CreerPraticiens(Praticiens prat)
        {
            Boolean test = false;
            try
            {
                DAOFactory.execWrite("INSERT INTO Praticiens SELECT Code, RaisonSociale, Adresse, Telephone, ContactNom, ContactAdressseMail, idSpecialite, CoefficientNotoriete, Coefficientconfiance) VALUES ('" + prat.Code + "', '" + prat.RaisonSocial + "', '" + prat.Adresse
                    + "', '" + prat.Tel + "', '" + prat.ContactNom + "', '" + prat.ContactMail + "', '" + prat.IdSpecialite + "', '" + prat.CoefNotoriete + "', '" + prat.CoefConfiance + "');");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }

        public static Boolean SupprimerPraticiens(Praticiens prat)
        {
            Boolean test = false;
            try
            {
                DAOFactory.execWrite("DELETE FROM Praticiens WHERE Code = " + prat.Code + "");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return false;
        }

        public static Boolean ModifierPraticiens(Praticiens prat)
        {
            Boolean test = false;
            try
            {
                DAOFactory.execWrite("UPDATE Praticiens SET Code = '" + prat.Code + "', RaisonSociale = '" + prat.RaisonSocial + "', Adresse = '" +
                    prat.Adresse + "', Telephone = '" + prat.Tel + "', ContactNom = '" + prat.ContactNom + "', ContactAdressseMail = '" + prat.ContactMail +
                    "', idSpecialite = '" + prat.IdSpecialite + "', CoefficientNotoriete ='" + prat.CoefNotoriete + "', CoefficientConfiance ='" + prat.CoefConfiance + "'  WHERE Code = '" + prat.Code + "';");
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
