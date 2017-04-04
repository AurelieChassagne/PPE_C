using applicationGSB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine(e);
            }
            return LesGestionnaires;
        }
    }
}
