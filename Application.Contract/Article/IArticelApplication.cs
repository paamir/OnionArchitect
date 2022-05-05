using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Contract;

namespace Application.Contract
{
    public interface IArticleApplication
    {
        void Create(ArticleCreate articleCreate);
        void Delete(int articleId);
        List<ArticleViewModel> ReadAll();
        ArticleViewModel Read(int Id);
        void Activate(int id);
        void Edit(ArticleEdit article);
    }
}
