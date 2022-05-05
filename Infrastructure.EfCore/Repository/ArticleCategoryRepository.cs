using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Damain;

namespace Infrastructure.EfCore.Repository
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly OAContext _context;

        public ArticleCategoryRepository(OAContext context)
        {
            _context = context;
        }

        public void Create(ArticleCategory articleCategory)
        {
            _context.ArticleCategories.Add(articleCategory);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public List<ArticleCategory> ReadAll()
        {

            return _context.ArticleCategories.OrderByDescending(x => x.Id).ToList();
        }

        public ArticleCategory Read(int Id)
        {
            return _context.ArticleCategories.FirstOrDefault(x => x.Id == Id);
        }

        public bool Exited(string Title)
        {
            return _context.ArticleCategories.Any(x => x.Title == Title);
        }
    }
}
