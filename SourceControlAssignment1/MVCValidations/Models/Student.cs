using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCValidations.Models
{
    public class Student
    {
        [Required (ErrorMessage = "FirstName is Required")]
        public String FirstName { get; set; }

        [Required (ErrorMessage = "LastName is Required")]
        [StringLength(60, MinimumLength = 4)]
        public String LastName { get; set; }

        public DateTime DateOfBirth{ get; set; }


        [MaxLength(50), MinLength(10)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Contact No Required")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Contact number")]
        public string ContactNo { get; set; }

        [Required (ErrorMessage = "Email Address is Required")]
        [EmailAddress (ErrorMessage = "Please Enter Valid Email Address")]
        public String Email { get; set; }

        [Compare("Email")]
        public string ConfirmEmail { get; set; }

        [Required (ErrorMessage = "Age is Required")]
        [Range(18,100)]
        public int Age { get; set; }

    }
}