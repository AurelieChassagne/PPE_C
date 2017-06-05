using gsb_pre_alpha;
using PreparationBaseDeDonne;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                MessageBox.Show("Impossible de charger toute les données par rapport à la famille : " + e, "Erreur de chargement des données", MessageBoxButtons.OK);
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
                MessageBox.Show("Impossible de rechercher une famille par rapport à " + prod.GetIdFamille() + " : " + e, "Erreur de recherche ", MessageBoxButtons.OK);
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
                MessageBox.Show("Impossible de retrouver l'identifiant de famille " + nom + " : " + e, "Erreur d'itentifiant famille", MessageBoxButtons.OK);
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
                MessageBox.Show("Impossile de remplir les informations de la famille " + Nom + " : " + e, "Erreur de donner", MessageBoxButtons.OK);
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
                MessageBox.Show("Impossible de rechercher la famille qui commence par " + nom + " : " + e, "Erreur de recherche", MessageBoxButtons.OK);
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
                MessageBox.Show("Impossible d'ajouter une famille : " + e, "Erreur d'ajout", MessageBoxButtons.OK);
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
                MessageBox.Show("Impossible de supprimer une famille : " + e, "Erreur de suppression", MessageBoxButtons.OK);
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
                MessageBox.Show("Impossible de modifier " + fam + " : " + e, "Erreur de modification", MessageBoxButtons.OK);
            }
        }
    }
}
