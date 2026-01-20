using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using ADONETEX01.Class;

namespace ADONETEX01.Class
{
    internal class Repo
    {
        private static string _connectionString = "Server=localhost;Database=db_Livres ;User ID=root;Password=root";
        public static bool AddBook( Book book)
        {
            bool result = false;
            // Mise en place de notre object qui nous servira a interagir avec la bdd
            MySqlConnection connection = new MySqlConnection(_connectionString);

            try
            {

                connection.Open();
                string query = "INSERT INTO livres (title, author, publishingYear, isbn) VALUES (@title, @author, @publishingYear, @isbn)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                
                
                cmd.Parameters.AddWithValue("@title", book.Title);
                cmd.Parameters.AddWithValue("@author", book.Author);
                cmd.Parameters.AddWithValue("@publishingYear", book.PublishingYear);
                cmd.Parameters.AddWithValue("@isbn", book.Isbn);


                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    result = true;
                    //Console.WriteLine("Livre ajouté avec succes");
                }
            }
            catch (Exception e)
            {
                result = false;
                //// j'atterit dans le catch si une erreur est arrive dans le try
                //Console.WriteLine("Erreur : " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        // --------------------------------------------
        // --------------------------------------------
        // --------------------------------------------

        public static List<Book> ReadAllBook()
        {
            
            //Console.WriteLine("=-=-=-= livres =-=-=-= enregistrés =-=-=-= ");
            List<Book> books = new List<Book>();
            MySqlConnection conection = new MySqlConnection(_connectionString);
            try
            {
                conection.Open();
                string query = "SELECT * FROM livres";

                MySqlCommand cmd = new MySqlCommand(query, conection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Book b = new Book(reader.GetInt32("id"), reader.GetString("title"), reader.GetString("author"), reader.GetInt32("publishingYear"), reader.GetString("isbn"));
                        books.Add(b);
                    }
                }
                else
                {
                    //Console.WriteLine("Aucun livre dans la base de donnée.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Erreur : {ex.Message}");
            }
            finally
            {
                conection.Close();
            }
            return books;
        }

        // --------------------------------------------
        // --------------------------------------------
        // --------------------------------------------
        public static Book ReadOneBook(int id)
        {

            Book book = null;
            MySqlConnection connection = new MySqlConnection(_connectionString);
            try
            {
                connection.Open();

                string query = "SELECT * FROM livres WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", Ihm.Id);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                     book = new Book(reader.GetInt32("id"), reader.GetString("title"), reader.GetString("author"), reader.GetInt32("publishingYear"), reader.GetString("isbn"));
                    
                }
                else
                {
                    Console.WriteLine("Aucune personne trouvée avec cet ID!");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return book;

        }

        // --------------------------------------------
        // --------------------------------------------
        // --------------------------------------------

        public static void ModifyBook(int id)
        {


            MySqlConnection connection = new MySqlConnection(_connectionString);
            try
            {
                connection.Open();

                string queryCheck = "SELECT COUNT(*) FROM livres WHERE id = @id";
                MySqlCommand cmdCheck = new MySqlCommand(queryCheck, connection);
                cmdCheck.Parameters.AddWithValue("@id", id);
                int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (count == 0)
                {
                    Console.WriteLine("aucune personne avec cet id!");
                    return;
                }

                Console.WriteLine("modification du  livre");
                Console.Write("titre : ");
                var title = Console.ReadLine();

                Console.Write("auteur : ");
                var author = Console.ReadLine();

                Console.Write("date de publication : ");
                var publishingYear = int.Parse(Console.ReadLine());

                Console.Write("isbn : ");
                var isbn = Console.ReadLine();

                string query = "UPDATE livres SET title = @title, author = @author, publishingYear = @publishingYear, isbn = @isbn WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@publishingYear", publishingYear);
                cmd.Parameters.AddWithValue("@isbn", isbn);
                cmd.Parameters.AddWithValue("@id", id);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("le livre a été modifié.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur: {ex.Message}");

            }
            finally
            {
                connection.Close();
            }
        }
        // --------------------------------------------
        // --------------------------------------------
        // --------------------------------------------

        public static void DeleteBook()
        {
            Console.WriteLine("id du livre recherché: ");
            var id = int.Parse(Console.ReadLine());

            MySqlConnection connection = new MySqlConnection(_connectionString);
            try
            {
                connection.Open();

                string query = "DELETE FROM livres WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("livre supprimé");
                }
                else
                {
                    Console.WriteLine("pas de livre a cet id!");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur: {ex.Message}");
            }
            finally { connection.Close(); }
        }

    }
}
