using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ADONETEX01.Class
{
    internal class Book
    {
        internal int Id;
        internal string Title;
        internal string Author;
        internal int PublishingYear;
        internal string Isbn;

        

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
