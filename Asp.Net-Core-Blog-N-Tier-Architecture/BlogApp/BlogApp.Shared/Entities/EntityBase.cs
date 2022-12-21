using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Entities
{
    public abstract class EntityBase
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now; //Bu değeri bazen farklı şekilde kullanırız. Kullanabilmek için override etmek gerekir. Abstract Class
        //override CreatedDate = new Datetime(2020/02/05);

        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;

        public virtual bool IsDeleted { get; set; } = false; // Silindi Mi? manuel 
        public virtual bool IsActive { get; set; } = true;

        public virtual string CreatedByName { get; set; } = "Admin";

        public virtual string ModifiedByName { get; set; } = "Admin";

        public virtual string Note { get; set; }
        /* Abstract (Soyut) sınıfları kullanarak, nesne üretirken bir şablon oluşturmak istememizdir diyebiliriz. Yani bir sınıf üzerinde bulunan özellikleri kullanarak yeni bir sınıf türetmek istediğimiz zaman,
        içerisinde bulunan bazı temel yapıları yeniden oluşturmak için override (aşırı yükleme) işlemini uygular ve sınıf yapılarına göre özel bir hale getiririz.*/
        //Override kelimesini geçersiz kılma anlamının yanı sıra aşırı yükleme anlamı da taşır.

    }
}