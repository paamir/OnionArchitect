using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Contract.Comment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Areas.Admin.Pages.CommentManagement
{
    public class listModel : PageModel
    {
        public List<CommentViewModel> Comments;
        public readonly ICommentApplication _commentApplication;

        public listModel(ICommentApplication commentApplication)
        {
            _commentApplication = commentApplication;
        }

        public void OnGet()
        {
            Comments = _commentApplication.ReadAll();
        }

        public RedirectToPageResult OnPostCancel(int Id)
        {
            _commentApplication.Cancel(Id);
            return RedirectToPage("./List");

        }
        public RedirectToPageResult OnPostConfirm(int Id)
        {
            _commentApplication.Confirm(Id);
            return RedirectToPage("./List");
        }
    }
}
