using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUYEN_THI_A1
{
    internal class DatabaseManager
    {
        public static string username;

        static SqlConnection sqlConnection = new SqlConnection(@"data source=DESKTOP-1ARB7R2;initial catalog=QLTBLA1;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;");
        //static SqlConnection sqlConnection = new SqlConnection(@"name = DatabaseManager.cs"); BTLThiLaiXe
        static SqlDataAdapter sqlData;

        public static DataTable executeQuery(string sql)
        {
            sqlData = new SqlDataAdapter(sql, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            return dataTable;
        }
    }
}
