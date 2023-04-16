using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace DatabaseConnection
{
    public class myConnections
    {
         
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\DESKTOP;AttachDbFilename= " + (AppDomain.CurrentDomain.BaseDirectory).ToString() + "LibararyManagementSystem.mdf;" + "Integrated Security=True;Connect Timeout=15;");
        public static SqlConnection GetConnections()
        {
            //string path = Path.GetFullPath(Environment.CurrentDirectory);
            //string database = "LibararyManagementSystem.mdf";

            //string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= " +path + @"\" + database+ ";Integrated Security=True;";
            //SqlConnection connection = new SqlConnection(connect);
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-0OT4A26\DESKTOP;Initial Catalog=LibararyManagementSystem;Integrated Security=True");
            return connection;

        }
    }
}
