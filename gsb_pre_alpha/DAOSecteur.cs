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
    class DAOSecteur
    {
        private static DAOFactory connexion = new DAOFactory();

        /// <summary>
        /// Permet de charger dans une liste les 4 secteurs existants
        /// </summary>
        /// <returns>Une Liste de secteurs</returns>
        public static List<Secteur> chargerSecteurs()
        {
            List<Secteur> LesSecteurs = new List<Secteur>();

            try
            {
                SqlDataReader reader;
                reader = connexion.execRead("Select id, nom from Secteur");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Secteur s = new Secteur(reader.GetInt32(0), reader.GetString(1));
                        LesSecteurs.Add(s);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return LesSecteurs;
        }
        /// <summary>
        /// Permet de rechercher un secteur par rapport à l'id d'un secteur d'un visiteur
        /// </summary>
        /// <param name="prod">Un visiteur</param>
        /// <returns>Un secteur</returns>
        public static Secteur RechercherSecteurByVisiteur(Visiteur visi)
        {
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead($"select nom from Secteur where id = {visi.getIdSecteur()}");
                reader.Read();
                Secteur LeSecteur = new Secteur(reader.GetString(0));
                reader.Close();
                return LeSecteur;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        /// <summary>
        /// Permet de retrouver l'id d'un Secteur
        /// </summary>
        /// <param name="nom">Le nom du secteur</param>
        /// <returns>L'id du</returns>
        public static Secteur RechecherIdSecteurByNom(string nomSecteur)
        {
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead($"select id from Secteur where nom = '{nomSecteur}'");
                reader.Read();
                Secteur LeSecteur = new Secteur(reader.GetInt32(0));
                reader.Close();
                return LeSecteur;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        /// <summary>
        /// Permet d'obtenir les informations d'un secteur
        /// </summary>
        /// <param name="Nom">Nom d'un secteur</param>
        /// <returns>Un secteur</returns>
        public static Secteur RemplirInfosSecteur(String nomSecteur)
        {

            try
            {
                SqlDataReader reader;
                reader = connexion.execRead("Select id, nom FROM "
                    + $"Secteur where id ='{nomSecteur}';");
                reader.Read();
                Secteur LeSecteur = new Secteur(reader.GetInt32(0), reader.GetString(1));

                reader.Close();
                return LeSecteur;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                Secteur SecError = new Secteur(0, "ERREUR");

                return SecError;
            }
        }
        /// <summary>
        /// Permet de rechercher une famille par rapport à quelque lettre données
        /// </summary>
        /// <param name="nom">nom qui devrait correspondre à une famille</param>
        /// <returns>une liste de famille où le nom demandé correspond</returns>
        public static List<Famille> RechercherNomFamille(String nom)
        {
            List<Famille> LesFamilles = new List<Famille>();
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead($"select * from Famille where nom LIKE'%{nom}%'");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Famille LeFamille = new Famille(reader.GetInt32(0), reader.GetString(1));
                        LesFamilles.Add(LeFamille);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return LesFamilles;
        }
        /// <summary>
        /// Permet d'ajouter une famille dans la table famille
        /// </summary>
        /// <param name="fam">objet de type famille</param>
        public static void CreerFamille(Famille fam)
        {
            try
            {
                connexion.execWrite($"INSERT INTO Famille values('{fam.GetNom()}');");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// Permet de supprimer une famille de la table famille
        /// </summary>
        /// <param name="fam">objet de type famille</param>
        public static void SupprimerFamille(Famille fam)
        {
            try
            {
                connexion.execWrite($"DELETE FROM Famille WHERE id = " + fam.GetId() + "");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// Permet de modifier une famille de la table famille
        /// </summary>
        /// <param name="fam">objet de type famille</param>
        public static void ModifierFamille(Famille fam)
        {
            try
            {
                connexion.execWrite($"UPDATE Famille SET nom = '{fam.GetNom()}' WHERE id = '"
                    + fam.GetId() + "';");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
