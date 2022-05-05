using System.Collections.Generic;

namespace Infrastructure.Query
{
    public interface IArticleQuery
    {
        List<ArticleQueryModel> ReadAll();
        ArticleDetailQuery Read(int Id);
    }
}