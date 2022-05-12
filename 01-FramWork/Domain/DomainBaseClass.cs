using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FramWork.Domain
{
    public class DomainBaseClass<T>
    {
        public T Id { get; set; }
        public DateTime CreationDateTime { get; set; }

        public DomainBaseClass()
        {
            CreationDateTime = DateTime.Now;
        }
    }
}
