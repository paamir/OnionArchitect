using System.Collections.Generic;
using System.Linq;
using Application.Contract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication1.Areas.Admin.Pages.ArticleManagement
{
    public class EditModel : PageModel
    {
        [BindProperty] public ArticleEdit _Article { get; set; }
        public List<SelectListItem> ArticleCategories;
        private readonly IArticleApplication _articleApplication;
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public EditModel(IArticleApplication articleApplication, IArticleCategoryApplication articleCategoryApplication)
        {
            _articleApplication = articleApplication;
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet(int Id)
        {
            ArticleCategories = _articleCategoryApplication.List()
                .Select(x => new SelectListItem(x.Title, x.Id.ToString())).ToList();


            var Article = _articleApplication.Read(Id);
            _Article = new ArticleEdit()
            {
                Id = Article.Id, Content = Article.Content,
                ArticleCategoryId = Article.ArticleCategoryId, Image = Article.Image,
                ShortDescription = Article.ShortDescription, Title = Article.Title
            };
        }

        public RedirectToPageResult OnPost()
        {
            _articleApplication.Edit(_Article);
            return RedirectToPage("./Index");
        }
    }
}