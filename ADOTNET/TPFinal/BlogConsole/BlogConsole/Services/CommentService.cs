using TPFinal.Class;

namespace TPFinal.Services
{
    public class CommentService
    {
        //ajouter commentaire
        public static string AddCommentary(Comment comment)
        {
            int index = Article.Articles.FindIndex(a => a.CurrentId == comment.ArticleId);

            if (index != -1)
            {
                Article.Articles[comment.ArticleId].Comments.Add(comment);
                Console.WriteLine(comment);
                return "commentaire ajouté";
            }
            else
            {
                return $"Article avec l'ID {comment.ArticleId} non trouvé.";
            }


        }
        //supprimer commentaire
        public static string DeleteComment(int id)
        {
            
            for (int i = 0; i < Article.Articles.Count; i++)
            {
                for (int j = 0; j < Article.Articles[i].Comments.Count; j++)
                {
                    if (Article.Articles[i].Comments[j].CurrentCommentId == id )
                    {
                        Article.Articles[i].Comments.RemoveAt(j);
                        return "commentaire suprimé.";
                    }

                }
            }
            return $"aucun commentaire avec l'id {id} n'as été trouvé";
        }
    }
}
