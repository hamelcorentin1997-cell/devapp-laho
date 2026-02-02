using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPFinal.Class
{
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //public static int StaticId { get; set; } = 1;

        //public int CurrentId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public DateOnly CreationDate { get; set; } = default;

        public DateOnly ModifDate { get; set; } = default;

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public static List<Article> Articles { get; set; } = new List<Article>();

        public Article(int id , string title, string content, DateOnly creationDate)
        {
            Id = id;
            Title = title;
            Content = content;
            CreationDate = creationDate;
            Comments = new List<Comment>();
        }

        public Article(string title, int id, string content, DateOnly modifDate)
        {
            Id = id;
            Title = title;
            Content = content;
            Comments = new List<Comment>();
            ModifDate = modifDate;
        }

        public Article()
        {
            Comments = new List<Comment>();
        }

        public override string ToString()
        {
            return $"id {this.Id}, titre {this.Title}. \n content: {this.Content}. \n date de création {this.CreationDate}  derniere modif {this.ModifDate}";
        }
    }
}
