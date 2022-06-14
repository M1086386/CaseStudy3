using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CaseStudy3.Models
{
    public class School
    {
        [Key]
        public int SchoolIdentity { get; set; }
        public string SchoolName { get; set; }
        public int NumberOfStudents { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

    }
}