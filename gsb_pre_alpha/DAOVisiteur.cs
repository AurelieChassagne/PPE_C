using gsb_pre_alpha;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicationGSB
{
    class DAOVisiteur
    {

        private static DAOFactory connexion = new DAOFactory();

        /// <summary>
        /// Permet de charger tout les visiteurs de la base
        /// </summary>
        /// <returns>une liste de type Visiteur</returns>
        public static List<Visiteur> chargerVisiteurs()
        {
            List<Visiteur> LesVisiteurs = new List<Visiteur>();


            try
            {
                
                SqlDataReader reader;
                reader = connexion.execRead("Select visi.id, visi.nom, visi.prenom, visi.type," 
                    +" visi.adresse, visi.cp, visi.ville, visi.login, visi.motdepasse,"
                    + " visi.dateEmbauche, secteur.nom FROM Visiteur visi INNER JOIN Secteur sec ON sec.id = visi.idSecteur");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Visiteur v = new Visiteur(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                            reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8),
                            reader.GetString(9), reader.GetInt32(10));

                        LesVisiteurs.Add(v);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Une erreur s'est produite lors du chargement des données : " + e);
            }
            return LesVisiteurs;
        }



        /// <summary>
        /// Permet d'ajouter un visiteur dans la base
        /// </summary>
        /// <param name="visi">Le visiteur à ajouter</param>
        public static void CreerVisiteur(Visiteur visi)
        {
            try
            {
                connexion.execWrite($"INSERT INTO Visiteur values('{visi.getId()}','"
                    + $"{visi.getType()}','{visi.getNom()}','{visi.getPrenom()}','{visi.getLogin()}','{visi.getMotDePasse()}','{visi.getAdresse()}','{visi.getCP()}','{visi.getVille()}','"
                    + $"{visi.getIdSecteur()}');");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Une erreur s'est produite lors de l'insertion des données : " + e);
            }
        }


        /// <summary>
        /// Permet de supprimer un visiteur de la base
        /// </summary>
        /// <param name="visi">Le visiteur à supprimer</param>
        public static void SupprimerVisiteur(Visiteur visi)
        {
            try
            {
                connexion.execWrite("DELETE FROM Visiteur WHERE id = " + visi.getId() + "");
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
