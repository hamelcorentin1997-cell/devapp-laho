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
        public static void menu()
        {



            while (true)
            {
                Console.WriteLine("1: ajouter, 2 consulter tout les livre, 3 consulter un livre par id, 4 modifier info livre, 5 suprimer un livre. 0 = quitter");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Book.AddBook();
                        break;
                    case "2":
                        Book.ReadAllBook();
                        break;
                    case "3":
                        Book.ReadOneBook();
                        break;
                    case "4":
                        Book.ModifyBook();
                        break;
                    case "5":
                        Book.DeleteBook();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("choix non reconu.");
                        break;
                }
            }


        }
    }
}
