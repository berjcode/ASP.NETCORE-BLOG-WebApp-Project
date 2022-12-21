using BlogApp.Shared.Entities;
using BlogApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Concrete
{
    public class User:EntityBase,IEntity
    {

        public string  FirstName { get; set; }

        public string LastName { get; set; }
        public string  Email { get; set; }

        public byte[] PasswordHash { get; set; }
        public string UserName { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }

        //Image

        public string Picture { get; set; }

        public string Description { get; set; }


        //bir user'in birden fazla makalesi olablir.

        public ICollection<Article> Articles { get; set; }
    }
}
