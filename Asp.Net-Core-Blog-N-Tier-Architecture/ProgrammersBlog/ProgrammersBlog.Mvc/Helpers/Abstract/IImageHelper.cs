using Microsoft.AspNetCore.Http;
using ProgrammersBlog.Entities.ComplexType;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Helpers.Abstract
{
	public interface IImageHelper
	{

		Task<IDataResult<UploadImageDto>> Upload(string Name, IFormFile pictureFile,PictureType pictureType, string folderName = null);


		IDataResult<ImageDeleteDto> Delete(string pictureName);
	}
}
