using ADONETEX01.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ADONETEX01.Class
{
    internal class Ihm
    {
        public static int Id { get; set; }
        public static void menu()
        { 



            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("=-=-=-=-=-= Menu principal =-=-=-=-=-=");
                Console.WriteLine("1: ajouter un livre, 2: consulter tout les livre, 3: consulter un livre par id, ");
                Console.WriteLine("4: modifier info livre, 5: suprimer un livre. 0:  quitter l'application.");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Ajout d'un Nouveau livre");
                        Console.Write("titre : ");
                        string title = Console.ReadLine();
                        Console.Write("auteur : ");
                        string author = Console.ReadLine();
                        Console.Write("date de publication : ");
                        int publishingYear = int.Parse(Console.ReadLine());
                        Console.Write("isbn : ");
                        string isbn = Console.ReadLine();

                        // Creation de l'objet Personne
                        Book book = new Book(title, author, publishingYear, isbn);

                        Repo.AddBook(book);
                        
                        break;

                    case "2":
                        Console.WriteLine("=-=-=-= livres =-=-=-= enregistrés =-=-=-= ");

                        
                        foreach (var livre in Repo.ReadAllBook())
                        {
                            Console.WriteLine(livre);
                        }
                        break;
                    case "3":
                        Console.WriteLine("id du livre recherché: ");
                        Id = int.Parse(Console.ReadLine());
                        Repo.ReadOneBook(Id);
                        break;

                    case "4":
                        Console.WriteLine("id du livre recherché: ");
                         Id = int.Parse(Console.ReadLine());
                        Repo.ModifyBook(Id);
                        break;

                    case "5":
                        Repo.DeleteBook();
                        break;

                    case "0":
                        Console.WriteLine("au revoir!");
                        return;
                    default:
                        Console.WriteLine("choix non reconu.");
                        break;
                }
            }


        }
    }
}
