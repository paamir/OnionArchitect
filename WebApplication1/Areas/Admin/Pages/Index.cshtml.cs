using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Contract;
using Damain;
using Infrastructure.EfCore;
using Infrastructure.EfCore.Repository;
using Infrastructure.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Areas.Admin.Pages
{
    public class IndexModel : PageModel
    {
        public List<ArticleQueryModel> Articles { get; set; }

        private readonly IArticleQuery _articleQuery;

        public IndexModel(IArticleQuery ArticleQuery)
        {
            _articleQuery = ArticleQuery;
        }

        public void OnGet()
        {
            Articles = _articleQuery.ReadAll();
        }
    }
}