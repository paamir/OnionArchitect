﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract
{
    public class ArticleCategoryViewModel
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string CreationDate { get; set; }
        public string Title { get; set; }
    }
}
