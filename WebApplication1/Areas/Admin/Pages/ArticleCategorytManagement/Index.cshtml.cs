using System.Collections.Generic;
using System.Linq;
using Application.Contract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Areas.Admin.Pages.ArticleCategorytManagement
{
    public class IndexModel : PageModel
    {
        public List<ArticleCategoryViewModel> ArticleCategories { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public IndexModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
            ArticleCategories = _articleCategoryApplication.List().OrderByDescending(x => x.Id).ToList();
        }

        public RedirectToPageResult OnPostRemove(int id)
        {
            _articleCategoryApplication.Delete(id);
            return RedirectToPage("./Index");
        }

        public RedirectToPageResult OnPostActivate(int id)
        {
            _articleCategoryApplication.Activate(id);
            return RedirectToPage("./Index");
        }
    }
}
