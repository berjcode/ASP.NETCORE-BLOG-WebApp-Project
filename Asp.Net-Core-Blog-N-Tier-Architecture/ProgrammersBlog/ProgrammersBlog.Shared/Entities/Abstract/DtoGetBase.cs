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


        public virtual int CurrentPage { get; set; } = 1; //şuanki sayfa

        public virtual int PageSize { get; set; } = 5;   //bir sayfada kac tane değer yani blog 

        public virtual int TotalCount { get; set; }   //toplamda kac makale var


        public virtual int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalCount, PageSize));


        public virtual bool ShowPrevious => CurrentPage > 1;

        public virtual bool ShowNext => CurrentPage < TotalPages;

        public virtual bool IsAscending { get; set; } = false;
    }
}
