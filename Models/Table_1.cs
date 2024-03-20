using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Data.SqlClient;
using System.Diagnostics;

namespace TEST101.Models
{
    public class Table_1 
    {

        public static string con_string = "Server=tcp:debby-sql-server.database.windows.net,1433;Initial Catalog=debby-DB;Persist Security Info=False;User ID=DebbyAnne;Password=Debby4670;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

        public static SqlConnection con = new SqlConnection(con_string);

        public String UserName { get; set; }
        //public int ID{get; set}

        public string userSurname { get; set; }
       
        public string userEmail { get; set; }


        public IActionResult Index()
        {
            return View();
        }

        public int insert_User(Table_1 m)
        {
            //declaring string with object name "sql" where we will write the insirt statements
            //string sql = @"insirt into Table_1([[UserName] [userSurname] [userEmail]])"

            //SqlCOmmand cmd = new SqlCommand(sql, con)

            //return cmd.ExecuteQuery();

            //same method below, but as you can see.. much longer to complete

              string sql = "INSERT INTO Table_1 (UserName, userSurname, userEmail) VALUES (@Name, @Surname, @Email)";
              SqlCommand cmd = new SqlCommand(sql, con);
              cmd.Parameters.AddWithValue("username", UserName);
              cmd.Parameters.AddWithValue("usersurname",userSurname);
              cmd.Parameters.AddWithValue("useremail", userEmail);
              con.Open();
              int rowsAffected = cmd.ExecuteNonQuery();
              con.Close();
              return rowsAffected;              

        }

    }
}
