using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCMidTerm.Models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [StringLength(30)]
        public string LastName { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public DateTime CoureEnrolledDate { get; set; }
        [Required]
        public int CourseStatus { get; set; }
        [Required]
        [StringLength(2)]
        public string Grade { get; set; }

    }
}