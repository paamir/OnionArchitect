using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Contract;
using Application.Contract.Comment;
using Damain;
using Infrastructure.EfCore;
using Infrastructure.EfCore.Repository;
using Infrastructure.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        public List<ArticleQueryModel> Articles { get; set; }
        private readonly ICommentApplication _commentApplication;

        private readonly IArticleQuery _articleQuery;

        public IndexModel(IArticleQuery ArticleQuery, ICommentApplication commentApplication)
        {

            _articleQuery = ArticleQuery;
            _commentApplication = commentApplication;
        }

        public void OnGet()
        {
            _commentApplication.Create(new CommentCreateModel() { ArticleId = 17, Massage = "alsdkjaljd", Name = "amir" });
            Articles = _articleQuery.ReadAll();
        }
    }
}