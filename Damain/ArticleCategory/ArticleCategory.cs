using System;
using System.Collections.Generic;

namespace Damain
{
    public class ArticleCategory
    {
        public int Id { get; private set; }
        public DateTime CreationDate { get; private set; }
        public string Title { get; private set; }
        public bool IsDeleted{ get; private set; }
        public List<Article> Article { get; private set; }

        protected ArticleCategory()
        {

        }
        public ArticleCategory(string title, IArticleCategoryValidationService _articleCategoryValidationService)
        {
            _articleCategoryValidationService.EarlyExite(title);
            EmptyOrWhitespace(title);
            Title = title;
            IsDeleted = false;
            CreationDate = DateTime.Now;
        }

        public void EmptyOrWhitespace(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new Exception();
            }
        }
        public void RenameTitle(string Title)
        {
            EmptyOrWhitespace(Title);

            this.Title = Title;
        }

        public void Remove()
        {
            IsDeleted = true;
        }

        public void Activate()
        {
            IsDeleted = false;
        }

        public void ChangeStatus(bool status)
        {
            this.IsDeleted = status;
        }
    }
}
