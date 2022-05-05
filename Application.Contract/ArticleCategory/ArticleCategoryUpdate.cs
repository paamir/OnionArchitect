using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract
{
    public class ArticleCategoryUpdate: ArticleCategoryCreate
    {
        public int Id { get; set; }
    }
}
