using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using System.Collections;
using System.Collections.Generic;

namespace ProgrammersBlog.Mvc.Areas.Admin.Models
{
    public class DashboardViewModel
    {
        public int CategoriesCount { get; set; }

        public int ArticleCount { get; set; }

        public int CommentsCount { get; set; }

        public int UsersCount { get; set; }

        public ArticleListDto Articles { get; set; }

        //
    }
}
