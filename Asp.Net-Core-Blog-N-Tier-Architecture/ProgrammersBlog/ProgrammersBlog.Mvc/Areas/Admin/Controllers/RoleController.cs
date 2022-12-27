﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Mvc.Areas.Admin.Models;
using ProgrammersBlog.Mvc.Helpers.Abstract;
using ProgrammersBlog.Shared.Utilities.Extensions;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : BaseController
    {

        private readonly RoleManager<Role> _roleManager;

        public RoleController(RoleManager<Role> roleManager,UserManager<User> userManager,IMapper mapper,IImageHelper imageHelper):base( userManager, mapper, imageHelper)
        {
            _roleManager = roleManager;
        }

        [Authorize(Roles ="SuperAdmin, Role.Read")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return View(new RoleListDto
            {
                Roles = roles
            });
        }


        [Authorize(Roles = "SuperAdmin, Role.Read")]
        [HttpGet]
        public async Task<IActionResult> GetAllRoles()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            //bir json ile dönmemiz gerekir.

            var roleListDto = JsonSerializer.Serialize(new RoleListDto
            {
                Roles = roles
            });

            return Json(roleListDto);
        }

        [Authorize(Roles = "SuperAdmin, Role.Update")]
        [HttpGet]
        public async Task<IActionResult> Assign(int userId)
        {
            var user = await UserManager.Users.SingleOrDefaultAsync( u => u.Id == userId); //kullanıcı getir
            var roles = await _roleManager.Roles.ToListAsync(); //rol getir

            var userRoles = await UserManager.GetRolesAsync(user); //kullanıcıın rolünü getir

            UserRoleAssignDto userRoleAssignDto = new UserRoleAssignDto
            {
                UserId = userId,
                UserName = user.UserName,
            };
            //olan roller secili gelmeli
            foreach(var role in roles)
            {
                RoleAssignDto rolesAssignDto = new RoleAssignDto
                {
                    RoleId = role.Id,
                    RoleName = role.Name,
                    HasRole = userRoles.Contains(role.Name  ) //Rolü kontrol et
                };

                userRoleAssignDto.RoleAssignDtos.Add(rolesAssignDto);
            }
            return PartialView("_RoleAssignPartial", userRoleAssignDto);
        }


        [Authorize(Roles = "SuperAdmin, Role.Update")]
        [HttpPost]
        public async Task<IActionResult> Assign(UserRoleAssignDto userRoleAssignDto)
        {
            if(ModelState.IsValid) { 
             var user = await UserManager.Users.SingleOrDefaultAsync(u => u.Id == userRoleAssignDto.UserId);

            foreach(var roleAssignDto in userRoleAssignDto.RoleAssignDtos)
            {
                if (roleAssignDto.HasRole)
                    await UserManager.AddToRoleAsync(user,roleAssignDto.RoleName);
                else
                {
                    await UserManager.RemoveFromRoleAsync(user,roleAssignDto.RoleName);
                }
            }
                await UserManager.UpdateSecurityStampAsync(user);
            var userRoleAssignAjaxViewModel = JsonSerializer.Serialize(new UserRoleAssignAjaxViewModel
            {
                UserDto = new UserDto
                {
                    User = user,
                    Message =$"{user.UserName} kullanıcına ait rol atama işlemi başarıyla tamamlanmıştır.",
                    ResultStatus = ResultStatus.Success
                },

                RoleAssignPartial = await this.RenderViewToStringAsync("_RoleAssignPartial",userRoleAssignDto)
            });

            return Json(userRoleAssignAjaxViewModel);
            }else
            {
                var userRoleAssignAjaxErrorModel = JsonSerializer.Serialize(new UserRoleAssignAjaxViewModel
                {
                   

                    RoleAssignPartial = await this.RenderViewToStringAsync("_RoleAssignPartial", userRoleAssignDto),
                    UserRoleAssignDto =userRoleAssignDto
                });
                return Json(userRoleAssignAjaxErrorModel);
            }
    }
}
}