using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Utilities
{
	public static class Messages
	{
		//New'lememize gerek yok.

		public static class Category
		{
			//True gelirse coğul olarak döner.
			public static string NotFound(bool isPlural)
			{
				if (isPlural) return "hiç  bir kategori bulunamadı.";
				return "Böyle bir kategori bulunamadı";
			}


			public static string Add(string categoryName)
			{
				return $"{categoryName} adlı kategori başarıyla eklenmiştir.";
			}
		}
	}
}
