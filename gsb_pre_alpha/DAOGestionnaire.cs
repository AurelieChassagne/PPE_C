using applicationGSB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsb_pre_alpha
{
    class DAOGestionnaire
    {
        private static DAOFactory connexion = new DAOFactory();
        /// <summary>
        /// Permet de charger tout les gestionnaire de la base de données
        /// </summary>
        /// <returns>une liste de type gestionnaire</returns>
        public static List<Gestionnaire> ChargerGestionnaire()
        {
            List<Gestionnaire> LesGestionnaires = new List<Gestionnaire>();
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead($"select * from Gestionnaire ");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Gestionnaire LeGestionnaire = new Gestionnaire(reader.GetString(0), reader.GetString(1));
                        LesGestionnaires.Add(LeGestionnaire);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Impossible de charger les gestionnaire de la base de données : " + e, "Erreur lors du chargement des données", MessageBoxButtons.OK);
            }
            return LesGestionnaires;
        }

        public static bool VerificationLoginMdp(string login, string mdp)
        {
            bool result = false;
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead($"select * from Gestionnaire where login = '{login}' and mdp = '{mdp}'");
                if (reader.HasRows == true)
                {
                    result = true;
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return result;
        }
    }
}
