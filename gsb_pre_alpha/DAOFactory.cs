using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace applicationGSB
{
    class DAOFactory
    {
        private static string dataSource = "172.17.21.33";
        private static string catalog = "gsb";
        private static string user = "admin";
        private static string password = "btssio-slam-2015";

        private SqlConnection sqlConnection;
        /// <summary>
        /// Connection à la base de données
        /// </summary>
        private void connection()
        {
            try
            {
                sqlConnection = new SqlConnection("Data Source=" + dataSource + "; Initial Catalog=" + catalog
                    + ";Persist Security Info=True;User ID=" + user + "; Password=" + password);
                sqlConnection.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Impossible de se connecter à la base de données : " + e, "Erreur de connection", MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// Déconnection de la base de données
        /// </summary>
        public void deconnection()
        {
            sqlConnection.Close();
        }
        /// <summary>
        /// Permet de lire dans la base de données
        /// </summary>
        /// <param name="requete">Se que l'on demande comme données</param>
        /// <returns>Retourne les resultats de la requête</returns>
        public SqlDataReader execRead(String requete)
        {
            this.connection();
            SqlCommand command = new SqlCommand(requete);
            command.Connection = sqlConnection;
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        /// <summary>
        /// Permet d'écrire dans la base de données
        /// </summary>
        /// <param name="requete">Se que l'on veut effectuer comme requte dans la base de données</param>
        public void execWrite(String requete)
        {
            this.connection();
            SqlCommand command = new SqlCommand(requete);
            command.Connection = sqlConnection;
            command.ExecuteNonQuery();
            deconnection();
        }
    }
}
