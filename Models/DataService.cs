using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace u04598637_HW05.Models
{
    public class DataService
    {
        private String ConnectionString;

        public DataService()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public List<BooksVM> getAllBooks()
        {
            List<BooksVM> books = new List<BooksVM>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand("Select * From books", con))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            BooksVM bvm = new BooksVM
                            {
                                BookID = Convert.ToInt32(reader["bookid"]),
                                BookName = Convert.ToString(reader["name"])
                               
                            }
                        }
                    }
                }
            }
        }
    }
}