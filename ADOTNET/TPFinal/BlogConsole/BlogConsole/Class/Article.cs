using System.ComponentModel.DataAnnotations;

namespace TPFinal.Class
{
    public class Article
    {
        public static int StaticId { get; set; }
        public int CurrentId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateOnly CreationDate { get; set; } = new DateOnly(); // int year int month int day 
        public DateOnly ModifDate { get; set; }
        public List<Comment> Comments { get; set; }
        public static List<Article> Articles { get; set; } = new List<Article>();
        public Article( string title, string content, DateOnly creationDate)
        {
            CurrentId = StaticId;
            StaticId++;
            Title = title;
            Content = content;
            CreationDate = creationDate;
            Comments = new List<Comment>();
            
        }
        public Article(string title, int id, string content, DateOnly modifDate)
        {
            CurrentId = id;
            Title = title;
            Content = content;
            Comments = new List<Comment>();
            ModifDate = modifDate;
        }


        public Article() { }
        public override string ToString()
        {
            return $"id {this.CurrentId}, titre {this.Title}. \n content: {this.Content}. \n date de création {this.CreationDate}  derniere modif {this.ModifDate}";
        }
    }
}
