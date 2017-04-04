using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicationGSB
{
    class DAOFactory
    {
        private static string dataSource = "172.17.21.33";
        private static string catalog = "gsb";
        private static string user = "admin";
        private static string password = "btssio-slam-2015";

        private SqlConnection sqlConnection;
        private void connection()
        {
            sqlConnection = new SqlConnection("Data Source=" + dataSource + "; Initial Catalog=" + catalog
                + ";Persist Security Info=True;User ID=" + user + "; Password=" + password);
            sqlConnection.Open();
        }

        public void deconnection()
        {
            sqlConnection.Close();
        }

        public SqlDataReader execRead(String requete)
        {
            this.connection();
            SqlCommand command = new SqlCommand(requete);
            command.Connection = sqlConnection;
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

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
