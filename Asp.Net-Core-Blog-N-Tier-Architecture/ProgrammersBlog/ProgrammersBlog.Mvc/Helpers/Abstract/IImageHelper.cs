using Microsoft.AspNetCore.Http;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Helpers.Abstract
{
	public interface IImageHelper
	{

		Task<IDataResult<UploadImageDto>> UploadUserImage(string userName, IFormFile pictureFile, string folderName = "userImages");


		IDataResult<ImageDeleteDto> Delete(string pictureName);
	}
}
