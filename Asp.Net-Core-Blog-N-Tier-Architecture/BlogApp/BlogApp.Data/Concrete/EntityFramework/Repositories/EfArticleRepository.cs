using BlogApp.Data.Abstract;
using BlogApp.Entities.Concrete;
using BlogApp.Shared.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Repositories
{
    public class EfArticleRepository : EfEntityRepositoryBase<Article>, IArticleRepository
    {

        public EfArticleRepository(DbContext context) : base(context)
        {

        }
    }
}
