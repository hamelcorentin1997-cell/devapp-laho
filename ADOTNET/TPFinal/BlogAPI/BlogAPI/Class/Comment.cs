using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPFinal.Class
{
    public class Comment
    {
        // Id géré par la base de données (auto-increment)
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Compatibilité avec le code existant qui utilise CurrentCommentId
        public int CurrentCommentId => Id;

        [ForeignKey(nameof(Article))]
        public int ArticleId { get; set; }

        // Propriété de navigation vers l'article
        public Article? Article { get; set; }

        public string? Author { get; set; }

        public string Content { get; set; } = string.Empty;

        public DateOnly CreationDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public Comment(int articleId, string author, string content, DateOnly date)
        {
            ArticleId = articleId;
            Author = author;
            Content = content;
            CreationDate = date;
        }

        public Comment(int articleId, string content, DateOnly date)
        {
            ArticleId = articleId;
            Author = "Anonyme";
            Content = content;
            CreationDate = date;
        }

        public Comment()
        {
            Author = "Anonyme";
            Content = string.Empty;
            CreationDate = DateOnly.FromDateTime(DateTime.Now);
        }

        public override string ToString()
        {
            return $"Commentaire de l'article {ArticleId}, ID du commentaire {Id} auteur {Author}. \n content: {Content}, date {CreationDate}";
        }
    }
}
