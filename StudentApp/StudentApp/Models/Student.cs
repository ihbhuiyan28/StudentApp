using System.ComponentModel.DataAnnotations;

namespace StudentApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "Student Name")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Student Name is Required")]
        public string? Name { get; set; }

        [Display(Name = "Student Registration")]
        [MaxLength(11)]
        [Required(ErrorMessage = "Student Registration is Required")]
        public string? Registration { get; set; }

        [Display(Name = "Student Gender")]
        [MaxLength(6)]
        [Required(ErrorMessage = "Student Gender is Required")]
        public string? Gender { get; set; }

        [Display(Name = "Student Email")]
        [EmailAddress]
        [Required(ErrorMessage = "Student Email is Required")]
        public string? Email { get; set; }

        [Display(Name = "Student Result")]
        [Required(ErrorMessage = "Student Result is Required")]
        public double Result { get; set; }
    }
}
