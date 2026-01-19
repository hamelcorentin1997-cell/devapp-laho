using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ADONETEX01.Class
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublishingYear { get; set; }
        public string Isbn { get; set; }

        private static string _connectionString = "Server=localhost;Database=db_Livres ;User ID=root;Password=root";

        public Book(string title, string author, int publishingYear, string isbn) 
        {
            Title = title;
            Author = author;
            PublishingYear = publishingYear;
            Isbn = isbn;
        }
        public Book(int id, string title, string author, int publishingYear, string isbn) :this (title,author,publishingYear,isbn) 
        {
            Id= id;
        }



        public static void AddBook()
        {
            Console.WriteLine("Ajout d'un Nouveau livre");
            Console.WriteLine("titre : ");
            string title = Console.ReadLine();
            Console.WriteLine("auteur : ");
            string author = Console.ReadLine();
            Console.WriteLine("date de publication : ");
            int publishingYear = int.Parse(Console.ReadLine());
            Console.WriteLine("isbn : ");
            string isbn = Console.ReadLine();

            // Creation de l'objet Personne
            Book book = new Book(title, author, publishingYear, isbn);



            // Mise en place de notre object qui nous servira a interagir avec la bdd
            MySqlConnection connection = new MySqlConnection(_connectionString);

            try
            {

                connection.Open();


                string query = "INSERT INTO livres (title, author, publishingYear, isbn) VALUES (@title, @author, @publishingYear, @isbn)";


                MySqlCommand cmd = new MySqlCommand(query, connection);


                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@publishingYear", publishingYear);
                cmd.Parameters.AddWithValue("@isbn", isbn);


                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    Console.WriteLine("Livre ajouté avec succes");
                }
            }
            catch (Exception e)
            { // j'atterit dans le catch si une erreur est arrive dans le try
                Console.WriteLine("Erreur : " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        // --------------------------------------------
        // --------------------------------------------
        // --------------------------------------------

        public static void ReadAllBook()
        {
            Console.WriteLine("=-=-=-= livres =-=-=-= enregistrés =-=-=-= ");
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
                        Console.WriteLine(b);
                    }
                }
                else
                {
                    Console.WriteLine("Aucun livre dans la base de donnée.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
            finally
            {
                conection.Close();
            }
        }

        // --------------------------------------------
        // --------------------------------------------
        // --------------------------------------------
        public static void ReadOneBook()
        {
            Console.WriteLine("id du livre recherché: ");
            var id = int.Parse(Console.ReadLine());

            MySqlConnection connection = new MySqlConnection(_connectionString);
            try
            {
                connection.Open();

                string query = "SELECT * FROM livres WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Book b = new Book(reader.GetInt32("id"), reader.GetString("title"), reader.GetString("author"), reader.GetInt32("publishingYear"), reader.GetString("isbn"));
                    Console.WriteLine(b);
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

        }

        // --------------------------------------------
        // --------------------------------------------
        // --------------------------------------------

        public static void ModifyBook()
        {
            Console.WriteLine("id du livre recherché: ");
            var id = int.Parse(Console.ReadLine());

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
                Console.WriteLine("titre : ");
                var title = Console.ReadLine();

                Console.WriteLine("auteur : ");
                var author = Console.ReadLine();
                
                Console.WriteLine("date de publication : ");
                var publishingYear = int.Parse(Console.ReadLine());
                
                Console.WriteLine("isbn : ");
                var isbn = Console.ReadLine();

                string query = "UPDATE livres SET title = @title, author = @author, publishingYear = @publishingYear, isbn = @isbn WHERE id = @id" ;

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
                MySqlCommand cmd = new MySqlCommand( query, connection);
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

        public override string ToString()
        {
            return $"Id: {Id} || titre: {Title}, auteur: {Author} || publication: {PublishingYear} || isbn: {Isbn}";
        }
    }
}
