using gsb_pre_alpha;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicationGSB
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
                reader = connexion.execRead("SELECT Code, RaisonSociale, Adresse, Telephone, ContactNom, "
                + "ContactAdressseMail, idSpecialite, CoefficientNotoriete, Coefficientconfiance FROM Praticiens");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Praticiens m = new Praticiens(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), 
                        reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetInt32(7), 
                        reader.GetInt32(8));
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

        public static Boolean CreerPraticien(Praticiens prat)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Praticiens SELECT Code, RaisonSociale, Adresse, Telephone,"
                 + "ContactNom, ContactAdressseMail, idSpecialite, CoefficientNotoriete, Coefficientconfiance) VALUES ('" 
                 + prat.Code + "', '" + prat.RaisonSocial + "', '" + prat.Adresse + "', '" + prat.Tel + "', '" 
                 + prat.ContactNom + "', '" + prat.ContactMail + "', '" + prat.IdSpecialite + "', '" + prat.CoefNotoriete + "', '" 
                 + prat.CoefConfiance + "');");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }

        public static Boolean SupprimerPraticien(Praticiens prat)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("DELETE FROM Praticiens WHERE Code = " + prat.Code + "");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }

        public static Boolean ModifierPraticien(Praticiens prat)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Praticiens SET Code = '" + prat.Code + "', RaisonSociale = '" + prat.RaisonSocial +
                 "', Adresse = '" + prat.Adresse + "', Telephone = '" + prat.Tel + "', ContactNom = '" + prat.ContactNom +
                 "', ContactAdressseMail = '" + prat.ContactMail + "', idSpecialite = '" + prat.IdSpecialite + "', CoefficientNotoriete ='" 
                 + prat.CoefNotoriete + "', CoefficientConfiance ='" + prat.CoefConfiance + "'  WHERE Code = '" + prat.Code + "';");
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
        /// Permet de retrouver un praticient avec son code
        /// </summary>
        /// <param name="code">Passe en paramètre un code</param>
        /// <returns>Retourne un praticien par rapport à son code</returns>
        public static Praticiens RechercherPraticienParCode(int code)
        {
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead($"select * from Praticiens where code = {code}");
                reader.Read();
                Praticiens LePraticien = new Praticiens(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetInt32(7),
                        reader.GetInt32(8));
                reader.Close();
                return LePraticien;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }


        /// <summary>
        /// Permet de réccuperer une liste de praticiens d'une même spécialite gràce à un idSpecialite
        /// </summary>
        /// <param name="idSpe">Passe en paramètre un Produit</param>
        /// <returns>Retourne une Famille par rapport à l'identifiant famille du produit</returns>
        public static List<Praticiens> RechercherPraticienParIdSpe(int idSpe)
        {
            List<Praticiens> LesPraticiens= new List<Praticiens>();
            try
            {
                SqlDataReader reader;

                reader = connexion.execRead($"select * from Praticiens where idSpecialite = {idSpe}");
               
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Praticiens LePraticien = new Praticiens(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetInt32(7),
                        reader.GetInt32(8));
                        LesPraticiens.Add(LePraticien);
                    }
                }
                reader.Close();

                return LesPraticiens;
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
        public static Praticiens RechercherPraticienParNom(string nomPrat)
        {
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead($"select * from Praticiens where ContactNom = {nomPrat}");
                reader.Read();
                Praticiens LePraticien = new Praticiens(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetInt32(7),
                        reader.GetInt32(8));
                reader.Close();
                return LePraticien;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }


        /// <summary>
        /// Permet de réccuperer une liste de praticiens d'une même spécialite gràce à un nom
        /// </summary>
        /// <param name="idSpe">Passe en paramètre un nom</param>
        /// <returns>Retourne une liste de praticiens par rapport à un nom donné</returns>
        public static List<Praticiens> RechercherLesPraticiensParNom(string nomPrat)
        {
            List<Praticiens> LesPraticiens = new List<Praticiens>();
            try
            {
                SqlDataReader reader;

                reader = connexion.execRead($"select * from Praticiens where contactNom = {nomPrat}");

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Praticiens LePraticien = new Praticiens(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetInt32(7),
                        reader.GetInt32(8));
                        LesPraticiens.Add(LePraticien);
                    }
                }
                reader.Close();

                return LesPraticiens;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        


    }
}
