using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVClast.Models
{
    public class Student
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Name Is Required")]
        
        
        [MinLength(3, ErrorMessage = "Name Min Length Is 3")]
        [MaxLength(50, ErrorMessage = "Name Max Length Is 50")]
        [DisplayName("Student Name")] 
        [Column("Student eName")] 
       
        public string Name { get; set; }


        [Range(10, 21, ErrorMessage = "Age Must Be Between 10 and 21")]
        public int Age { get; set; }


      


        [StringLength(100, ErrorMessage = "Address Must Be Between 4 and 100", MinimumLength = 4)]
        public string Address { get; set; }


        [EmailAddress(ErrorMessage = "Please Enter A Valid Email")]
        [StringLength(100, ErrorMessage = "Email Must Be Between 4 and 100", MinimumLength = 4)]
        public string Email { get; set; }


        [MaxLength(30, ErrorMessage = "Password Max Length Is 30")]
        [MinLength(8, ErrorMessage = "Password Min Length Is 8")]
        [Required(ErrorMessage = "Password Is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        
        [NotMapped]
        [MaxLength(30, ErrorMessage = "Confirm Password Max Length Is 30")]
        [MinLength(8, ErrorMessage = "Confirm Password Min Length Is 8")]
        [Required(ErrorMessage = "Confirm Password Is Required")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password Not Match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        
        [ForeignKey(nameof(Department))]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        
    }
}

