using System;
using System.Collections.Generic;
using System.Text;

namespace SDMEntity.BE
{
    public class SupervisorRequest
    {
        public int SupervisorId { get; set; }
        public int GroupId { get; set; }
        public int AdminId { get; set; }
        public bool IsAccepted { get; set; }
    }
}
