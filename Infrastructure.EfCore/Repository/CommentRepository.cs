using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Damain.Comment;

namespace Infrastructure.EfCore.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly OAContext _context;

        public CommentRepository(OAContext context)
        {
            _context = context;
        }
        public void Create(Comment comment)
        {
            _context.Comments.Add(comment);
            Save();
        }
        public Comment Read(int Id)
        {
            return _context.Comments.FirstOrDefault(x => x.Id == Id);
        }

        public List<Comment> ReadAll()
        {
            return _context.Comments.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
