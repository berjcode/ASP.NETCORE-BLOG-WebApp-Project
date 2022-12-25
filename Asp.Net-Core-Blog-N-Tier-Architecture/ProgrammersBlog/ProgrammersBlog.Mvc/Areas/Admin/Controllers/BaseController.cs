using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Mvc.Helpers.Abstract;

namespace ProgrammersBlog.Mvc.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        //Sadece türeyen sınıflar kullanır.
      

        public BaseController(UserManager<User> userManager, IMapper mapper, IImageHelper imageHelper)
        {
            UserManager = userManager;
            Mapper = mapper;
            ImageHelper = imageHelper;
        }

         
        protected UserManager<User> UserManager { get; }//field
        protected IMapper Mapper { get;  } //sadece get olacak.farklı sınıflar değiştirmesin


        protected IImageHelper ImageHelper { get;  }

        protected User LoggedInUser => UserManager.GetUserAsync(HttpContext.User).Result;

    }
}
