using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;

namespace ProgrammersBlog.Shared.Entities.Abstract
{
    public abstract class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
        public virtual string Message { get; set; }


        public int CurrentPage { get; set; } = 1; //şuanki sayfa

        public int PageSize { get; set; } = 5;   //bir sayfada kac tane değer yani blog 

        public int TotalCount { get; set; }   //toplamda kac makale var


        public int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalCount, PageSize));


        public bool ShowPrevious => CurrentPage > 1;

        public bool ShowNext => CurrentPage < TotalPages;
    }
}
