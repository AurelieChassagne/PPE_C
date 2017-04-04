using gsb_pre_alpha;
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
    }
}
