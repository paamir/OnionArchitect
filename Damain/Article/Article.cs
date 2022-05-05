using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_FramWork.Domain;

namespace Damain
{
    public class Article : DomainBaseClass<int>
    {
        public string Title { get; private set; }
        public string ShortDescription { get; private set; }
        public string Image { get; private set; }
        public string Content { get; private set; }
        public int ArticleCategoryId { get; private set; }
        public ArticleCategory ArticleCategory { get; private set; }
        public bool IsDeleted{ get; private set; }
        public List<Comment.Comment> Comments { get; set; }

        protected Article()
        {
            
        }
        public Article(string title, string shortDescription, string image, string content, int articleCategoryId)
        {
            Title = title;
            ShortDescription = shortDescription;
            Image = image;
            Content = content;
            IsDeleted = false;
            ArticleCategoryId = articleCategoryId;
        }

        public void Delete()
        {
            IsDeleted = true;
        }
        public void Activate()
        {
            IsDeleted = false;
        }

        public void Edit(string title, string shortDescription, string image, string content, int articleCategoryId)
        {
            Title = title;
            ShortDescription = shortDescription;
            Image = image;
            Content = content;
            ArticleCategoryId = articleCategoryId;

        }
    }
}
