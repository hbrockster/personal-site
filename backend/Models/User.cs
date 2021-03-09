using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string CellPhoneNumber { get; set; }
        public string Email { get; set; }

    }
}
