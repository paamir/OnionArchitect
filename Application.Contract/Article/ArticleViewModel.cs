using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public int ArticleCategoryId { get; set; }
        public string CreationDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
