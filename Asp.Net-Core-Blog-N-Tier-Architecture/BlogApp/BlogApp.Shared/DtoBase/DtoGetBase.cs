using BlogApp.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.DtoBase
{
   public abstract class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
    }
}
