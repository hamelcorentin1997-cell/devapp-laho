using TPFinal.Class;
namespace BlogConsole_BlogAPI.DTO
{
    public class ArticleDetailsResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string CreationDate { get; set; }
        public string ModifDate { get; set; }
        //ajout de la Liste Comment pour ajouter les commentaire associé a l'article
        public List<CommentDetailsresponse> Comments { get; set; }

        

    }
}
