using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damain.Comment
{
    public interface ICommentRepository
    {
        void Create(Comment comment);
        Comment Read(int Id);
        List<Comment> ReadAll();
        void Save();

    }
}
