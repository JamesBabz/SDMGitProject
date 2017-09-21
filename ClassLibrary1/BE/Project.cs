using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.BE
{
    using System.Reflection.Metadata.Ecma335;

    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CompanyCvr { get; set; }

        public string ProjectDescription { get; set; }

        public DateTime CreationDate { get; set; }

    }
}
