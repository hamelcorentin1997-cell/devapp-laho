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

        internal static string _connectionString = "Server=localhost;Database=db_Livres ;User ID=root;Password=root";

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



       

        public override string ToString()
        {
            return $"Id: {Id} || titre: {Title}, auteur: {Author} || publication: {PublishingYear} || isbn: {Isbn}";
        }
    }
}
