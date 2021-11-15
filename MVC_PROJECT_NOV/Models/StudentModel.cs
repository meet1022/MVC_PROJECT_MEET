using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_PROJECT_NOV.Models
{
    public class StudentModel
    {   
        [Required(ErrorMessage ="StudentID can't be empty.")]
        public int StudentId { get; set; }
        [StringLength(30,ErrorMessage ="Length Should be between 3 to 30",MinimumLength =3)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Range(18,40)]
        public int Age { get; set; }
        public string HiddenField { get; set; }

    }
}