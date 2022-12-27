using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;

namespace ProgrammersBlog.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<CategoryDto>> Get(int categoryId);
        Task<IDataResult<CategoryUpdateDto>> GetCategoryUpdateDto(int categoryId); /*   get ile managerda daha fazla işlem yapmamızı engelleyecek. ve kısa süre içerisinde modeli post edecek. */
        Task<IDataResult<CategoryListDto>> GetAll();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeleted();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActive();

        Task<IDataResult<CategoryListDto>> GetAllByDeletedAsync();
        Task<IDataResult<CategoryDto>> Add(CategoryAddDto categoryAddDto,string createdByName);
        Task<IDataResult<CategoryDto>> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
        
        
        // Dataresult ile dönmemizin sebebi daha fazla detayla dönmemiz. örnek alert mesajları içinde
        Task<IDataResult<CategoryDto>> Delete(int categoryId, string modifiedByName);
        Task<IDataResult<CategoryDto>> UndoDeleteAsync(int categoryId, string modifiedByName);
        Task<IResult> HardDelete(int categoryId);


        //bir sayı döneceğiz

        Task<IDataResult<int>> Count();
        Task<IDataResult<int>> CountByIsDeleted();
    }
}
