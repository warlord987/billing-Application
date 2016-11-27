using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace billing
{
    class ClassDatabaseConnection
    {
        private SqlConnection Con;
        private SqlCommand Command;
        private SqlDataAdapter DataAd;
        private DataTable DataTb;
        public ClassDatabaseConnection()
        {
            Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\data\BillingDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();
        }  
        public void SqlQuery(string QueryText)
        {
            Command = new SqlCommand(QueryText,Con);
        }
        public DataTable ExecuteQuery()
        {
            DataAd = new SqlDataAdapter(Command);
            DataTb = new DataTable();
            DataAd.Fill(DataTb);
            return DataTb;
        }
        public void ExecutNonQuery()
        {
            Command.ExecuteNonQuery();
        }
        public void DatabaseConnectionClose()
        {
            Con.Close();
        }
    }
}
