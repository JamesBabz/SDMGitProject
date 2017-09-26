using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.BE
{
    class SupervisorRequest
    {
        public int SupervisorId { get; set; }
        public int GroupId { get; set; }
        public int AdminId { get; set; }
        public bool IsAccepted { get; set; }
    }
}
