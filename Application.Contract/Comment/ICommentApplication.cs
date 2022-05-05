using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.Comment
{
    public interface ICommentApplication
    {
        void Create(CommentCreateModel comment);
        CommentViewModel Read(int Id);
        List<CommentViewModel> ReadAll();
        void Cancel(int Id);
        void Confirm(int Id);

    }
}
