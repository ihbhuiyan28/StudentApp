using System.ComponentModel.DataAnnotations;

namespace StudentApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Registration is Required")]
        [RegularExpression(@"^\d{1,11}$", ErrorMessage = "Characters Not Allowed")]
        public string? Registration { get; set; }
        [Required(ErrorMessage = "Gender is Required")]
        public string? Gender { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Result is Required")]
        public double Result { get; set; }
    }
}
