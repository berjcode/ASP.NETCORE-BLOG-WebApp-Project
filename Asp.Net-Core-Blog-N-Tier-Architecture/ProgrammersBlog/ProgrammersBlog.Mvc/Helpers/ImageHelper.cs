using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Mvc.Helpers.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using System.IO;
using System;
using System.Threading.Tasks;
using ProgrammersBlog.Shared.Utilities.Extensions;
using ProgrammersBlog.Shared.Utilities.Results.Concrete;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;
using ProgrammersBlog.Entities.ComplexType;
using System.Text.RegularExpressions;

namespace ProgrammersBlog.Mvc.Helpers
{
	public class ImageHelper : IImageHelper
	{
		private readonly IWebHostEnvironment _env;
		private readonly string _wwwroot;
		private const string imgFolder = "img";
		private const string userImagesFolder = "userImages";
		private const string postImagesFolder = "postImages";

		public ImageHelper(IWebHostEnvironment env)
		{
			_env = env;
			_wwwroot = _env.WebRootPath;
		}

		public IDataResult<ImageDeleteDto> Delete(string pictureName)
		{
			
			var fileToDelete = Path.Combine($"{_wwwroot}/{imgFolder}/", pictureName);
			if (System.IO.File.Exists(fileToDelete))
			{
				var fileInfo = new FileInfo(fileToDelete); //Path Belirtiyoruz.
				System.IO.File.Delete(fileToDelete);
				return new DataResult<ImageDeleteDto>(ResultStatus.Success,$"Böyle bir resim bulunamadı.", null);
			}
			else
			{
				return new DataResult<ImageDeleteDto>(ResultStatus.Success, $"Böyle bir resim bulunamadı.", null);
			}
		}

		public async Task<IDataResult<UploadImageDto>> Upload(string Name, IFormFile pictureFile, PictureType pictureType,string folderName = null)
		{
			//Enum kulladnığımız için bir kontrol daha yapmalıyız. Klasor adı null gelirse? 
			//Folder Name null gelirse userımagesfolder döndür.  eğer null gelmezse postımages döndür.

			folderName ??= pictureType == PictureType.User ? userImagesFolder : postImagesFolder;

			//Foldername değişkeni ile gelen klasör adı sistemde yoksa  yeni bir klasör oluşturulur.
			if (!Directory.Exists($"{_wwwroot}/{imgFolder}/{folderName}"))
			{
				Directory.CreateDirectory($"{_wwwroot}/{imgFolder}/{folderName}");
			}
			string oldFileName = Path.GetFileNameWithoutExtension(pictureFile.FileName);
			string fileExtension = Path.GetExtension(pictureFile.FileName);

			//regex kullanıyoruz.

			Regex regex = new Regex("[*'\",._&#^@?]");
			Name = regex.Replace(Name,string.Empty);


 

			DateTime dateTime = DateTime.Now;
			// abdullah_587_5_38_12_3_10_2020.png
			string newFileName = $"{Name}_{dateTime.FullDateAndTimeStringWithUnderscore()}{fileExtension}";
			var path = Path.Combine($"{_wwwroot}/{imgFolder}/{folderName}", newFileName);
			await using (var stream = new FileStream(path, FileMode.Create))
			{
				await pictureFile.CopyToAsync(stream);
			}
			string message = pictureType == PictureType.User ? $"{Name} adlı kullanıcının resimi başarıyla yüklenmiştir." : $"{Name} adlı makalenin resimi başarıyla yüklenmiştir.";

            return new DataResult<UploadImageDto>(ResultStatus.Success, message, new UploadImageDto
			{
				FullName = $"{folderName}/{newFileName}",
				OldName = oldFileName,
				Extension = fileExtension,
				FolderName = folderName,
				Path = path,
				Size = pictureFile.Length
			});
		}

		
	
	}
}
