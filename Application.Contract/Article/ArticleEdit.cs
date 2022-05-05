using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Contract;

namespace Application.Contract
{
    public class ArticleEdit : ArticleCreate
    {
        public int  Id { get; set; }
    }
}
