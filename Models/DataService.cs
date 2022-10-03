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
                using(SqlCommand cmd = new SqlCommand("SELECT books.bookId AS bookId , books.name AS name, authors.surname AS aname , types.name AS tname, books.pagecount AS pagecount, books.point AS point FROM books INNER JOIN authors on books.authorId = authors.authorId INNER JOIN types ON books.typeId = types.typeId", con))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            BookVM bvm = new BookVM
                            {
                                bookId = Convert.ToInt32(reader["bookId"]),
                                name = Convert.ToString(reader["name"]),
                                aname = Convert.ToString(reader["aname"]),
                                tname = Convert.ToString(reader["tname"]),
                                pagecount = Convert.ToInt32(reader["pagecount"]),
                                point = Convert.ToInt32(reader["point"])
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