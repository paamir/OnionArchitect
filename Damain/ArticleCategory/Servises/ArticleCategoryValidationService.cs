using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Damain
{
    public class ArticleCategoryValidationService : IArticleCategoryValidationService
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;

        public ArticleCategoryValidationService(IArticleCategoryRepository articleCategoryRepository)
        {
            _articleCategoryRepository = articleCategoryRepository;
        }

        public void EarlyExite(string Title)
        {
            if (_articleCategoryRepository.Exited(Title))
            {
                throw new ItHasExistedBefore("this record is duplicated");
            }
        }

    }
}
