using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Damain;

namespace Infrastructure.EfCore.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly OAContext _context;

        public ArticleRepository(OAContext context)
        {
            _context = context;
        }

        public void Create(Article article)
        {
            _context.Articles.Add(article);
            Save();
        }

        public List<Article> ReadAll()
        {
           return _context.Articles.ToList();
        }

        public Article Read(int Id)
        {
            return _context.Articles.FirstOrDefault(x => x.Id == Id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Edit(Article article)
        {
        }
    }
}
