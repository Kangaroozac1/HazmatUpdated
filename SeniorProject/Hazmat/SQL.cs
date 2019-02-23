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


        private void Insert(String query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                }
            }
            catch (Exception e)
            {

            }
        }

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

        public void InsertUser(String UserID, String UserName, String UserPassword)
        {
            string query = "Insert into dbo.users (UserID, UserName, UserPassword) Values('" + UserID + "','" + UserName + "','" + UserPassword + "')";

            Insert(query);
        }

        public void InsertScanner(String ScannerID, String UserID, String ConnectString)
        {
            string query = "Insert into dbo.Scanners (ScannerID, UserID, ConnectString) Values('" + ScannerID + "','" + UserID + "','" + ConnectString + "')";

            Insert(query);
        }

        public void InsertObject(String ObjectID, String ScannerID, String UserID, String TransactionTime, String ObjectType, String ObjectWeight)
        {
            string query = "Insert into dbo.Objects (ObjectID, ScannerID, UserID, TransactionTime, ObjectType, ObjectWeight) Values('" + ObjectID + "','" + ScannerID + "','" + UserID + "','" + TransactionTime + "','" + ObjectType + "','" + ObjectWeight + "')";

            Insert(query);
        }

        public string UserCheck(String UserName, String Password)
        {
            string query = "Select * From dbo.users Where UserName = '" + UserName + "' And UserPassword = '" + Password + "'";

            DataTable dataTable = Select(query);

            if (dataTable.Rows.Count == 1)
                return dataTable.Rows[0].ItemArray[0].ToString();
            else
                return null;
        }

        public DataTable GetObjbyID(String UserID, String ObjectID)
        {
            string query = "Select * From dbo.Objects Where UserID = '" + UserID + "' And ObjectID = '" + ObjectID + "'";

            DataTable dataTable = Select(query);
            dataTable.TableName = "OgjbyID";

            return dataTable;
        }

        public DataTable GetObjbyScan(String UserID, String ScannerID)
        {
            string query = "Select * From dbo.Objects Where UserID = '" + UserID + "' And ScannerID = '" + ScannerID + "'";

            DataTable dataTable = Select(query);
            dataTable.TableName = "OgjbyScanner";

            return dataTable;
        }

        public DataTable GetObjbyUser(String UserID)
        {
            string query = "SELECT * FROM (SELECT ROW_NUMBER() OVER(ORDER BY TransactionTime) AS MyRowNumber, * FROM dbo.Objects) tbl WHERE MyRowNumber BETWEEN 0 AND 20;";

            DataTable dataTable = Select(query);
            dataTable.TableName = "OgjbyUser";

            return dataTable;
        }

        public DataTable GetScan(String UserID, String ScannerID)
        {
            string query = "Select * From dbo.Scanners Where UserID = '" + UserID + "' And ScannerID = '" + ScannerID + "'";

            DataTable dataTable = Select(query);
            dataTable.TableName = "ScanbyUser";

            return dataTable;
        }
        public List<String> GetScanners()
        {
            int i;
            List<String> returnList = new List<String>();
            string query = "Select distinct ScannerID from dbo.Scanners";
            try
            {
                DataTable scanners = Select(query);
                for (i = 0; i < scanners.Rows.Count; i++)
                {
                    String scanid = scanners.Rows[i].ItemArray[0].ToString();
                    returnList.Add(scanid);
                }
            }
            catch (Exception e)
            {
                return returnList;
            }
            return returnList;
        }


    }

}

