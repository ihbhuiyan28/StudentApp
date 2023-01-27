namespace StudentApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Registration { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public double Result { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
