using BlogApp.Entities.Concrete;
using BlogApp.Shared.DtoBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Dtos
{
   public class CategoryListDto:DtoGetBase
    {
        // bir ategorinin listesini taşıyacağı için dtogetbase!Den türer.
        public IList<Category> Categories { get; set; }
    }
}
