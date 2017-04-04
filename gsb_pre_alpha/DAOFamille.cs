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
    class DAOFamille
    {
        private static DAOFactory connexion = new DAOFactory();

        /// <summary>
        /// Permet de charger dans une liste toute les données par rapport à la famille
        /// </summary>
        /// <returns>une liste de famille</returns>
        public static List<Famille> chargerFamille()
        {
            List<Famille> LesFamilles = new List<Famille>();

            try
            {
                SqlDataReader reader;
                reader = connexion.execRead("select id, nom from Famille");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Famille f = new Famille(reader.GetInt32(0), reader.GetString(1));
                        LesFamilles.Add(f);
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
        /// Permet de rechercher une famille par rapport à l'identifiant de famille d'un produit
        /// </summary>
        /// <param name="prod">Passe en paramètre un Produit</param>
        /// <returns>Retourne une Famille par rapport à l'identifiant famille du produit</returns>
        public static Famille RechercherFamille(Produit prod)
        {
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead($"select nom from Famille fam where id = {prod.GetIdFamille()}");
                reader.Read();
                Famille LaFamille = new Famille(reader.GetString(0));
                reader.Close();
                return LaFamille;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        /// <summary>
        /// Permet de retrouver l'identifiant d'une famille
        /// </summary>
        /// <param name="nom">donne un nom pour trouver l'identifiant correspondant</param>
        /// <returns>Retourne une famille par rapport au nom donnée</returns>
        public static Famille RechercherIdFamille(string nom)
        {
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead($"select id from Famille where nom = '{nom}'");
                reader.Read();
                Famille LaFamille = new Famille(reader.GetInt32(0));
                reader.Close();
                return LaFamille;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        /// <summary>
        /// Permet de donner les informations d'une famille
        /// </summary>
        /// <param name="Nom">nom d'une famille</param>
        /// <returns>Retourne une famille par rapport au nom donnée</returns>
        public static Famille RemplirInfoMed(String Nom)
        {

            try
            {
                SqlDataReader reader;
                reader = connexion.execRead("Select id, nom FROM "
                    + $"Famille where id ='{Nom}';");
                reader.Read();
                Famille LaFamille = new Famille(reader.GetInt32(0), reader.GetString(1));

                reader.Close();
                return LaFamille;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                Famille ProdError = new Famille(0, "ERREUR");

                return ProdError;
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
