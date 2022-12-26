using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
   public class UserRoleAssignDto
    {

        public UserRoleAssignDto()
        {
            RoleAssignDtos = new List<RoleAssignDto>();
        }
        public int UserId { get; set; }

        public string UserName { get; set; }


        public IList<RoleAssignDto> RoleAssignDtos { get; set; } //bir interface olduğu için construcda yazmamız gerek. Normalde liste geldiği için sorun olmaz. ama tek tek attığımız zaman böyle yapmalıyız.
    }
}
