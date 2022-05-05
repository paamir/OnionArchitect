﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using _01_FramWork.Domain;

namespace Damain.Comment
{
    public class Comment : DomainBaseClass<int>
    {
        public string Name { get; private set; }
        public string Massage { get;private set; }
        public int status { get;private set; }//New = 0 , Confirmed = 1, Canceled = 2
        public int ArticleId { get;private set; }
        public Article Article { get;private set; }

        protected Comment()
        {

        }
        public Comment(string name, string massage, int articleId)
        {
            Name = name;
            Massage = massage;
            ArticleId = articleId;
            this.status = Statuses.New;
        }

        public void Cancel()
        {
            status = Statuses.Canceled;
        }

        public void Confirm()
        {
            status = Statuses.Confirm;
        }
    }
}
