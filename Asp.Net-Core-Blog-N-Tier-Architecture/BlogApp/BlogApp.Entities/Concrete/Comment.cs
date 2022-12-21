using BlogApp.Shared.Entities;
using BlogApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Concrete
{
  public class Comment:EntityBase,IEntity
    {

        public string Text { get; set; }


        //Bir yorumun Bir Makalesi vardır.
        public int ArticleId { get; set; }

        public Article Article { get; set; }
    }
}
