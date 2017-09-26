using System;
using System.Collections.Generic;
using System.Text;

namespace SDMEntity.BE
{
    public class User
    {
        public int PersonId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Level { get; set; }
    }
}
