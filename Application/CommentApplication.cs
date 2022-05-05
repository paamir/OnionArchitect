using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Contract.Comment;
using Damain.Comment;
using Infrastructure.EfCore.Repository;

namespace Application
{
    public class CommentApplication : ICommentApplication
    {
        private readonly ICommentRepository _commentRepository;

        public CommentApplication(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public void Create(CommentCreateModel comment)
        {
            _commentRepository.Create(new Comment(comment.Name, comment.Massage, comment.ArticleId));
        }

        public CommentViewModel Read(int Id)
        {
            var Comment = _commentRepository.Read(Id);
            return new CommentViewModel()
            {
                CreationDate = Comment.CreationDateTime.ToString(), Id = Comment.Id, Massage = Comment.Massage,
                Name = Comment.Name, ArticleId = Comment.ArticleId
            };
        }

        public List<CommentViewModel> ReadAll()
        {
            return _commentRepository.ReadAll().Select(x => new CommentViewModel()
                    {ArticleId = x.ArticleId, CreationDate = x.Massage, Id = x.Id, Massage = x.Massage, Name = x.Name, Article = x.Article, Status = x.status})
                .ToList();
        }

        public void Cancel(int Id)
        {
            var comment = _commentRepository.Read(Id);
            comment.Cancel();
            _commentRepository.Save();
        }

        public void Confirm(int Id)
        {
            var comment = _commentRepository.Read(Id);
            comment.Confirm();
            _commentRepository.Save();
        }
    }
}