using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Mvc.Areas.Admin.Models;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;

namespace ProgrammersBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
   
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IArticleService _articleService;
        private readonly ICommentService _commentService;

        private readonly UserManager<User> _userManager;

        public HomeController(ICategoryService categoryService, IArticleService articleService, ICommentService commentService, UserManager<User> userManager)
        {
            _categoryService = categoryService;
            _articleService = articleService;
            _commentService = commentService;
            _userManager = userManager;
        }

        [Authorize(Roles = "SuperAdmin,AdminArea.Home.Read")]
        public async Task<IActionResult> Index()
        {
            var categoriesCountResult = await _categoryService.CountByIsDeleted();

            var articlesCountResult = await _articleService.CountByIsDeleted();

            var commentCountResult = await _commentService.CountByNonDeletedAsync();
            var userCount = await _userManager.Users.CountAsync();

            var articleResult = await _articleService.GetAll();


            if(categoriesCountResult.ResultStatus ==ResultStatus.Success && articlesCountResult.ResultStatus == ResultStatus.Success && commentCountResult.ResultStatus == ResultStatus.Success && userCount > -1 && articleResult.ResultStatus == ResultStatus.Success)
            {
                return View(new DashboardViewModel
                {
                    CategoriesCount =categoriesCountResult.Data,
                    ArticleCount = articlesCountResult.Data,
                    CommentsCount = commentCountResult.Data,
                    UsersCount = userCount,
                    Articles = articleResult.Data
                });
            }
            return NotFound();
        }
    }
}
