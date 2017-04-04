using gsb_pre_alpha;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicationGSB
{
    class DAOProduit
    {

        private static DAOFactory connexion = new DAOFactory();

        /// <summary>
        /// Permet de charger tout les produits de la base de données
        /// </summary>
        /// <returns>une liste de type Produit</returns>
        public static List<Produit> chargerProduit()
        {
            List<Produit> LesProduits = new List<Produit>();

            try
            {
                SqlDataReader reader;
                reader = connexion.execRead("Select prod.ref,prod.nom, prod.dosage,prod.prix, "
                    + "prod.contreIndication,prod.effetTherapeutique,prod.idFamille FROM "
                    + "Produit prod INNER JOIN Famille fam ON fam.id = prod.idFamille");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Produit p = new Produit(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                            reader.GetDouble(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6));
                        LesProduits.Add(p);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return LesProduits;
        }
        /// <summary>
        /// Permet d'ajouter un produit dans la table produit
        /// </summary>
        /// <param name="prod">donne un Produit en paramètre</param>
        public static void CreerProduit(Produit prod)
        {
            try
            {
                connexion.execWrite($"INSERT INTO Produit values('{prod.GetNom()}','"
                    + $"{prod.GetDosage()}','{prod.Getprix()}','{prod.GetContreIndic()}','{prod.GetEfets()}','"
                    + $"{prod.GetIdFamille()}');");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// Permet de supprimer un produit dans la table produit
        /// </summary>
        /// <param name="prod">donne un Produit en paramètre</param>
        public static void SupprimerProduit(Produit prod)
        {
            try
            {
                connexion.execWrite("DELETE FROM Produit WHERE ref = " + prod.GetReference() + "");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// Permet de modifier un produit dans la table produit
        /// </summary>
        /// <param name="prod">donne un Produit en paramètre</param>
        public static void ModifierProduit(Produit prod)
        {
            try
            {
                connexion.execWrite($"UPDATE Produit SET nom = '{prod.GetNom()}', dosage = '"
                    + $"{prod.GetDosage()}', prix = '{prod.Getprix()}', contreIndication = '{prod.GetContreIndic()}', "
                    + $"effetTherapeutique = '{ prod.GetEfets()}', idFamille = '{prod.GetIdFamille()}' WHERE ref = '"
                    + prod.GetReference() + "';");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// Permet de remplir dans les texte boxe toute les information du produit
        /// </summary>
        /// <param name="Nom">donne le nom du produit ou on veut les informations</param>
        /// <returns></returns>
        public static Produit RemplirInfoMed(String Nom)
        {

            try
            {
                SqlDataReader reader;
                reader = connexion.execRead("Select prod.ref,prod.nom, prod.dosage,prod.prix, "
                    + "prod.contreIndication,prod.effetTherapeutique,prod.idFamille FROM "
                    + $"Produit prod where prod.nom ='{Nom}';");
                reader.Read();
                Produit LeProduit = new Produit(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                    reader.GetDouble(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6));

                reader.Close();
                return LeProduit;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                Produit ProdError = new Produit(0, "ERREUR", "ERREUR", 0, "ERREUR", "ERREUR", 0);

                return ProdError;
            }
        }
        /// <summary>
        /// Permet de trouver un produit par rapport à un morceau de nom
        /// </summary>
        /// <param name="nom">nom que l'on cherche</param>
        /// <returns>une liste de produit correspondant au nom donnée en paramètre</returns>
        public static List<Produit> RechercherProduit(String nom)
        {
            List<Produit> LesProduits = new List<Produit>();
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead($"select * from Produit where nom LIKE'%{nom}%'");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Produit LeProduit = new Produit(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                            reader.GetDouble(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6));
                        LesProduits.Add(LeProduit);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return LesProduits;
        }

    }
}
