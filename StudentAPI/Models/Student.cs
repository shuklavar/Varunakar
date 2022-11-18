using System;
using System.Collections.Generic;

namespace StudentAPI.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? RollNumber { get; set; }
        public string? Country { get; set; }
    }
}
