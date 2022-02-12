using System;
using System.Data.SqlClient;
using System.Configuration;


namespace DbManager
{
    public class DbTableManager
    {
        
        public static bool SaveResultsApp(string FullPath) //function that collects all the result paths and puts it into the database
        {
            SqlConnection SqCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
            SqlCommand SqCom = new SqlCommand($"insert SearchResultTable values ('{FullPath}')", SqCon);

            try
            {
                SqCon.Open();
                SqCom.ExecuteNonQuery();
                SqCon.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
