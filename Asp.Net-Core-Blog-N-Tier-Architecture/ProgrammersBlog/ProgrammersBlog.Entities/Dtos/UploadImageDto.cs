using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
	public class UploadImageDto
	{
		public string FullName { get; set; }  //Resmin tam ismi
		public string OldName { get; set; } //resmin eski ismi
		public string Extension { get; set; } //uzantı

		public string Path { get; set; } //yol

		public string FolderName { get; set; } //resim hangi dosyada

		public long  Size { get; set; } //resmin boyutu


	}
}
