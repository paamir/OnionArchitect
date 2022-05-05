using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Damain;
using Damain.Comment;

namespace Infrastructure.Query
{
    public class ArticleDetailQuery : ArticleQueryModel
    {
        public string Content { get; set; }
        public ArticleCategory ArticleCategory { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
