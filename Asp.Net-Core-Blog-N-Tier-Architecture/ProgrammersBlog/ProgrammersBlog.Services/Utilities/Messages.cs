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

            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla arşivden geri getirilmiştir. ";
            }


        }


        public static class Comment
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir yorum bulunamadı.";
                return "Böyle bir yorum bulunamadı.";
            }

            public static string Approve(int commentId)
            {
                return $" {commentId}, yorumunuz başarıyla Onaylanmıştır.";
            }
            public static string Add(string createdByName)
            {
                return $"Sayın {createdByName}, yorumunuz başarıyla eklenmiştir.";
            }

            public static string Update(string createdByName)
            {
                return $"{createdByName} tarafından eklenen yorum başarıyla güncellenmiştir.";
            }
            public static string Delete(string createdByName)
            {
                return $"{createdByName} tarafından eklenen yorum başarıyla silinmiştir.";
            }
            public static string HardDelete(string createdByName)
            {
                return $"{createdByName} tarafından eklenen yorum başarıyla veritabanından silinmiştir.";
            }

            public static string UndoDelete(string createdByName)
            {
                return $"{createdByName} adlı yorum geri getirilmiştir.";
            }
        }
    }
}
