namespace BlogConsole_BlogAPI.DTO
{
    public class CommentCreationRequest
    {
        public int ArticleId { get; set; }
        public string? Author { get; set; }
        public string Content { get; set; }
    }
}
