using BlogApp.Shared.Entities.Abstract;
using BlogApp.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Concrete
{
    public class Role : EntityBase, IEntity
    {

        public string Name { get; set; }
        public string DescriptionRole { get; set; }

        //Bir kullanıcı bir role sahip, bir role birden fazla kullanıcıda olablir.
        public ICollection<User> User { get; set; }

    }
}
