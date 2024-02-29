using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace konyvtar_BarthaAriana_14sl_grafikus
{
    internal class Adatbazis
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "books";
            builder.CharacterSet = "utf8";
            conn = new MySqlConnection(builder.ConnectionString);
            cmd = conn.CreateCommand();
            try
            {
                kapcsolatNyit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            finally
            {
                kapcsolatZar();
            }
        }

        internal List<Book> getAllBooks()
        {
            List<Book> books = new List<Book>();
            cmd.CommandText = "SELECT * FROM `books` ORDER BY `author`";
            try
            {
                kapcsolatNyit();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string title = reader.GetString("title");
                        string author = reader.GetString("author");
                        int publish_year = reader.GetInt32("publish_year");
                        int page_count = reader.GetInt32("page_count");
                        books.Add(new Book(id, title, author, publish_year, page_count));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { kapcsolatZar(); }
            return books;
        }

        private void kapcsolatNyit()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void kapcsolatZar()
        {
            if(conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        
    }
}
