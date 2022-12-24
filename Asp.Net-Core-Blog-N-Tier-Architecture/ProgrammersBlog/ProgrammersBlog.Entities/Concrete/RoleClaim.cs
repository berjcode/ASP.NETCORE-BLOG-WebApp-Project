using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProgrammersBlog.Entities.Concrete
{
    public class RoleClaim:IdentityRoleClaim<int>
    {

        // yaptığımız talepler neticesinde getiren anlamına gelir.
        //Claimler; rollerin dışında kullanıcı hakkında bilgi tutmamızı ve bu bilgilere göre yetkilendirme yapmamızı sağlayan yapılardır.
    }
}
