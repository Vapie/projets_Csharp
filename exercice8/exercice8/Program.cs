using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace exercice8
{
    class Program
    {
        static void Main(string[] args)
        {
            EventLog myLog = new EventLog();
           
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLfocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

                string sql = "SELECT Id,LIBELLE,QUANTITE FROM LISTECOURSES";
                //Create a SqlCommand object.
                SqlCommand requeteSQL = new SqlCommand(sql, conn);
                //Create a DataTable object and open connexion
                DataTable dataTable = new DataTable();
                conn.Open();
                //Run the command by using SqlDataReader.
                SqlDataReader rdr = requeteSQL.ExecuteReader();
                //Load the data from SqlDataReader into the data table.
                dataTable.Load(rdr);
                //Display the data from the datatable
                foreach (DataRow row in dataTable.Rows)
                {

#if DEBUG
                    Console.WriteLine("ingrédient : {0}, quantité {1}, Id {2} ", row["LIBELLE"], row["QUANTITE"], row["Id"]);
#else
                Console.WriteLine("ingrédient : {0}, quantité {1}", row["LIBELLE"], row["QUANTITE"]);
#endif

                    // à compléter
                }
                //Close the SqlDataReader and connexion
                rdr.Close();
                conn.Close();
            }
            catch
            {
               

                // Write an informational entry to the event log.
                myLog.WriteEntry("ça marche bof en vrai");
            }
        }
    }
}
