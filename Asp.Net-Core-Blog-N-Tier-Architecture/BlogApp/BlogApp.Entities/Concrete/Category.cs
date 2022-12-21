using BlogApp.Shared.Entities;
using BlogApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Concrete
{
    public class Category:EntityBase,IEntity
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Article> Articles { get;set; } //MAKALE Post
      //   public override string CreatedByName { get; set; } = "Admin"; Override örneği
    }
}
