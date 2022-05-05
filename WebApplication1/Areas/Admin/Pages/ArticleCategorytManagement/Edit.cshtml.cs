using Application.Contract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Areas.Admin.Pages.ArticleCategorytManagement
{
    public class EditModel : PageModel
    {
        private readonly IArticleCategoryApplication _articleCategoryApplication;
        [BindProperty] public ArticleCategoryUpdate _ArticleCategoryUpdate { get; set; }

        public EditModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet(int Id)
        {
            var Article = _articleCategoryApplication.Read(Id);
            _ArticleCategoryUpdate = new ArticleCategoryUpdate(){Id = Article.Id, Title = Article.Title};
        }

        public RedirectToPageResult OnPost()
        {
            _articleCategoryApplication.Update(_ArticleCategoryUpdate);
           return RedirectToPage("./Index");
        }
    }
}