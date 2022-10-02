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

        public List<BookVM> getAllBooks()
        {
            List<BookVM> books = new List<BookVM>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand("SELECT bookid , books.name , authors.surname , types.name , pagecount , point AS FROM books INNER JOIN authors on books.authorId = authors.authorId INNER JOIN types ON books.typeId = types.typeId", con))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            BookVM bvm = new BookVM
                            {
                                bookID = Convert.ToInt32(reader["bookid"]),
                                bookName = Convert.ToString(reader["books.name"]),
                                authorName = Convert.ToString(reader["authors.surname"]),
                                booktype = Convert.ToString(reader["types.name"]),
                                bookPC = Convert.ToInt32(reader["pagecount"]),
                                bookPoint = Convert.ToInt32(reader["point"])
                            };
                            books.Add(bvm);
                        }
                    }
                    con.Close();
                }
                return books;
            }
        }
    }
}