using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADOCSharpDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6TKS21FE\SQLEXPRESS;Initial Catalog=EmpSample_#OK;Integrated Security=SSPI");
            con.Open();
            SqlCommand com = new SqlCommand("select * from tblEmployees", con);
            SqlDataReader dr=com.ExecuteReader();
            Console.WriteLine(dr.HasRows); // to check if table has records
            Console.WriteLine("Employee details are as follows");
            while (dr.Read())
            {
                Console.WriteLine($" {dr[0]} ");
            }
        }
    }
}
