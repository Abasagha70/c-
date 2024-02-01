using LoginRegister.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegister.entity
{
    public class Entity <T>
    {
        public T Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate{ get; set; }

        public Status Status { get; set; }
    }
}
