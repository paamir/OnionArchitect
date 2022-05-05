using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damain
{
    public interface IArticleRepository
    {
        void Create(Article article);
        List<Article> ReadAll();
        Article Read(int Id);
        void Save();
        void Edit(Article article);
    }
}
