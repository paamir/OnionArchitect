using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Damain;

namespace Application.Contract
{
    public class ArticleCreate
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public int ArticleCategoryId { get; set; }
    }

}
