using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CPA_Project.Connect_DB
{
    public class Contexto : IDisposable
    {
        public Contexto()
        {
            ConnectionDb = new SqlConnection(ConfigurationManager.ConnectionStrings["BancoCPA"].ConnectionString);
            ConnectionDb.Open();
        }

        public SqlConnection ConnectionDb { get; private set; }

        public void ComandoNonQuery(string strQuery)
        {
            var cmd = new SqlCommand(strQuery, ConnectionDb);
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader ComandoDataReader(string strQuery)
        {
            var cmd = new SqlCommand(strQuery, ConnectionDb);
            return cmd.ExecuteReader();
        }

        public void Dispose()
        {
            if (ConnectionDb.State.Equals(ConnectionState.Open))
                ConnectionDb.Close();
        }
    }
}
