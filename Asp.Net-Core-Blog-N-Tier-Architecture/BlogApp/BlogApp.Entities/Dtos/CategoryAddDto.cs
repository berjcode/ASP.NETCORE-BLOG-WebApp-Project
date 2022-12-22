using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Dtos
{
    public class CategoryAddDto
    {
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} boş geçilemez.")] //1 = 70
        [MaxLength(70, ErrorMessage = " {0} {1} karakterden büyük olamaz.")]
        [MinLength(3, ErrorMessage = " {0} {1} karakterden küçük olamaz.")]
        public string Name { get; set; }

        [DisplayName("Kategori Açıklaması")]
        //[Required(ErrorMessage = "{0} boş geçilemez.")] //1 = 70
        [MaxLength(500, ErrorMessage = " {0} {1} karakterden büyük olamaz.")]
        [MinLength(3, ErrorMessage = " {0} {1} karakterden küçük olamaz.")]
        public string Description { get; set; }
        [DisplayName("Kategori Özel  Notu")]
        //[Required(ErrorMessage = "{0} boş geçilemez.")] //1 = 70
        [MaxLength(500, ErrorMessage = " {0} {1} karakterden büyük olamaz.")]
        [MinLength(3, ErrorMessage = " {0} {1} karakterden küçük olamaz.")]
        public string Note { get; set; }

        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} boş geçilemez.")] //1 = 70
        public bool IsActive { get; set; }
    }
}
