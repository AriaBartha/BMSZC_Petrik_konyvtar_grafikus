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

        internal void insertBook(Book book)
        {
            cmd.CommandText = "INSERT INTO `books`(`id`, `title`, `author`, `publish_year`, `page_count`) VALUES (@id, @title, @author, @publish_year, @page_count)";
            cmd.Parameters.AddWithValue("@id", book.Id);
            cmd.Parameters.AddWithValue("@title", book.Title);
            cmd.Parameters.AddWithValue("@author", book.Author);
            cmd.Parameters.AddWithValue("@publish_year", book.Publish_year);
            cmd.Parameters.AddWithValue("@page_count", book.Page_count);
            try
            {
                kapcsolatNyit();
                cmd.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatZar();
            }
        }

        internal void updateBook(Book book)
        {
           
            cmd.CommandText = "UPDATE `books` SET `title`=@title,`author`=@author,`publish_year`=@publish_year,`page_count`=@page_count WHERE `id`=@id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", book.Id);
            cmd.Parameters.AddWithValue("@title", book.Title);
            cmd.Parameters.AddWithValue("@author", book.Author);
            cmd.Parameters.AddWithValue("@publish_year", book.Publish_year);
            cmd.Parameters.AddWithValue("@page_count", book.Page_count);
            try
            {
                kapcsolatNyit();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatZar();
            }

        }

        internal void deleteBook(Book book)
        {
            cmd.CommandText = "DELETE FROM `books` WHERE `id`=@id";
            cmd.Parameters.AddWithValue("@id", book.Id);

            try
            {
                kapcsolatNyit();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatZar();
            }
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
