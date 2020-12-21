using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationAndLogin.Models
{
    public class User
    {
        [Key, Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int idUser { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")]

        public string Password { get; set; }

        [NotMapped]
        [Required]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Age is Required")]
        [Range(18, 100)]
        public int Age { get; set; }


        [Required(ErrorMessage = "Contact No Required")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Contact number")]

        public string ContactNo { get; set; }

       // [Required(ErrorMessage = "Image is Required")]
        // [FileExtensions(ErrorMessage = "Please Select File", Extensions ="jpg,png,jpeg,gif")]
       // [MyFileExtension(ErrorMessage = "Please Select File", AllowedExtensions = "jpg,png,jpeg,gif")]
        //public HttpPostedFileBase Image { get; set; }
        public string FullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        

    }
}