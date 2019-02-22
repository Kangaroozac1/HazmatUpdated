using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Hazmat
{
    public class SQL
    {

        string connectionstring = "Server=tcp:hazmat.database.windows.net,1433;Initial Catalog=HazmatDB;Persist Security Info=False;User ID=Student1;Password=HazmatTeam1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=0;";


        private DataTable Select(String query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Connection.Open();

                    SqlDataAdapter da = new SqlDataAdapter(command);

                    da.Fill(dataTable);

                    command.Connection.Close();
                }
            }
            catch (Exception e)
            {
                return null;
            }

            return dataTable;
        }

    }
}
