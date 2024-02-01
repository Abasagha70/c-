using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegister.entity
{
    public class User :Entity<Guid>

    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Username { get; set; }

        public String Password { get; set; }
        public String Email { get; set; }


      

    }
}
