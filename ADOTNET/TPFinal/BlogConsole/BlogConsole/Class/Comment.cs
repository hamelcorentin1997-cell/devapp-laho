using System.ComponentModel.DataAnnotations;

namespace TPFinal.Class
{
    public class Comment
    {

        public static int CommentId { get; set; }
        [Key]
        public static int Id { get; set; }
        public int CurrentCommentId { get; set; }
        public int  ArticleId { get; set; }
        public string? Author { get; set; }
        public string Content { get; set; }
        public DateOnly CreationDate { get; set; } = new DateOnly();


        public Comment(int articleId, string author, string content, DateOnly date)
        {
            this.ArticleId = articleId;
            this.Author = author;
            this.Content = content;
            this.CreationDate = date;
            this.CurrentCommentId = CommentId;
            CommentId++ ;            
        }
        public Comment(int articleId,  string content, DateOnly date)
        {
            this.ArticleId = articleId;
            this.Author = "Anonyme";
            this.Content = content;
            this.CreationDate = date;
            this.CurrentCommentId = CommentId;
            CommentId++;
        }

        public Comment() { }
        public override string ToString()
        {
            return $"Commentaire de l'article {this.ArticleId}, ID du commentaire {this.CurrentCommentId} auteur {this.Author}. \n content: {this.Content}, date {this.CreationDate}";
        }

    }
   
}
