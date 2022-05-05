using System.Collections.Generic;
using System.Linq;
using Application.Contract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Areas.Admin.Pages.ArticleManagement
{
    public class IndexModel : PageModel
    {
        public List<ArticleViewModel> Articles;
        private readonly IArticleApplication _articleApplication;
        public IndexModel(IArticleApplication articleApplication)
        {
            _articleApplication = articleApplication;
        }

        public void OnGet()
        {
            Articles = _articleApplication.ReadAll().OrderByDescending(x => x.Id).ToList();
        }

        public RedirectToPageResult OnPostRemove(int Id)
        {
            _articleApplication.Delete(Id);
            return RedirectToPage("./Index");
        }

        public RedirectToPageResult OnPostActivate(int Id)
        {
            _articleApplication.Activate(Id);
            return RedirectToPage("./Index");
        }
    }
}
