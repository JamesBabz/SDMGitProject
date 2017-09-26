using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SDMEntity.BE
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentGroupId { get; set; }
        public string Email { get; set; }
        [Range (00000000,99999999)]
        public int Phone { get; set; }
        public string Address { get; set; }
    }
}
