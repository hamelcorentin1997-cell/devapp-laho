namespace BlogConsole_BlogAPI.DTO
{
    public class CommentDetailsresponse
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string? Author { get; set; }
        public string Content { get; set; }
        public string CreationDate { get; set; }
    }
}
