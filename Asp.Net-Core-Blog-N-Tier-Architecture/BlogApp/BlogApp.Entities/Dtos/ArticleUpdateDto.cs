using BlogApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Dtos
{
    public class ArticleUpdateDto
    {
        [Required]
        public int Id { get; set; }


        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]

        public string Title { get; set; }

        [DisplayName("İçerik")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]

        [MinLength(10, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Content { get; set; }

        [DisplayName("Thumbnail")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [MaxLength(250, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Thumbnail { get; set; }

        [DisplayName("Tarih")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [DisplayName("SeoYazar")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [MaxLength(50, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string SeoAuthor { get; set; }


        [DisplayName("Seo Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [MaxLength(250, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(2, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string SeoDescription { get; set; }

        [DisplayName("Seo Tagları")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string SeoTags { get; set; }

        [DisplayName("Kategori")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [DisplayName("Aktif mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public bool IsActive { get; set; }

        [DisplayName("Aktif mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public bool IsDeleted { get; set; }
    }
}
