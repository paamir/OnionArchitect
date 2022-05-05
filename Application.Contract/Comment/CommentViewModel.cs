using Damain;

namespace Application.Contract.Comment
{
    public class CommentViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Massage { get; set; }
        public string CreationDate { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public int Status { get; set; }
    }
}