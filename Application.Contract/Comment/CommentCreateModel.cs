namespace Application.Contract.Comment
{
    public class CommentCreateModel
    {
        public string Name { get; set; }
        public string Massage { get; set; }
        public int ArticleId { get; set; }
    }
}