using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Contract.Comment;
using Infrastructure.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages.Article
{
    public class ArticleDetailModel : PageModel
    {
        public ArticleDetailQuery Article { get; set; }
        private readonly IArticleQuery _articleQuery;
        private readonly ICommentApplication _commentApplication;

        public ArticleDetailModel(IArticleQuery articleQuery, ICommentApplication commentApplication)
        {
            _articleQuery = articleQuery;
            _commentApplication = commentApplication;
        }

        public void OnGet(int Id)
        {
            Article =  _articleQuery.Read(Id);
        }

        public void OnPost(CommentCreateModel comment)
        {
            _commentApplication.Create(comment);
        }
    }
}
