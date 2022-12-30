using Microsoft.AspNetCore.Mvc;
using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Mvc.Models;
using ProgrammersBlog.Services.Abstract;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.ViewComponents
{
    public class RightSideBarViewComponent :ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IArticleService _articleService;
    public RightSideBarViewComponent(ICategoryService categoryService, IArticleService articleService)
        {
            _categoryService = categoryService;
            _articleService = articleService;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categoriesResult = await _categoryService.GetAllByNonDeletedAndActive();
            var articleResult = await _articleService.GetAllByViewCountAsync(isAscending: false ,takeSize:5);

            return View(new RightSideBarViewModel
            {
                Categories = categoriesResult.Data.Categories,
                Articles = articleResult.Data.Articles
            });
          
        }  
    }
}
