using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.BE
{
    class Supervisor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [Range(00000000, 99999999)]
        public int Phone { get; set; }
        public string Address { get; set; }
        public bool IsAvailable { get; set; }
    }
}
