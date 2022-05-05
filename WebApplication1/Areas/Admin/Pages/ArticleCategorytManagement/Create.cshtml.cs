using Application.Contract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Areas.Admin.Pages.ArticleCategorytManagement
{
    public class CreateModel : PageModel
    {
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public CreateModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
        }

        public RedirectResult OnPost(ArticleCategoryCreate _articleCategoryCreate)
        {
            _articleCategoryApplication.Add(_articleCategoryCreate);
            return Redirect("./Index");
        }
    }
}
