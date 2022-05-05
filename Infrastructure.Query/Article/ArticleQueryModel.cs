using System;

namespace Infrastructure.Query
{
    public class ArticleQueryModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string ShortDescription { get; set; }
        public string CreationDateTime { get; set; }
        public int ArticleCategoryId { get; set; }
        public int CommentCount { get; set; }
    }
}