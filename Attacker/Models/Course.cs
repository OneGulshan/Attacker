using System.ComponentModel.DataAnnotations;

namespace Attacker.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Code { get; set; } = "";
        public ICollection<StudentCourse>? StudentCourses { get; set; } = new HashSet<StudentCourse>();
    }
}
