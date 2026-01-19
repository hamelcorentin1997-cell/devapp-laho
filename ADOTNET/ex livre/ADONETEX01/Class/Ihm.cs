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
                        Repo.AddBook();
                        break;
                    case "2":
                        Repo.ReadAllBook();
                        break;
                    case "3":
                        Repo.ReadOneBook();
                        break;
                    case "4":
                        Repo.ModifyBook();
                        break;
                    case "5":
                        Repo.DeleteBook();
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
