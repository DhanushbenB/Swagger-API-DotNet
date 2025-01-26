using System.ComponentModel.DataAnnotations;

namespace StudentRegistration.StudentModels
{
    public class StudentModel
    {
        [Key]
        public int studentId { get; set; }
        public string? studentName { get; set; }
        public string? studentDepartment { get; set; }
        public string? studentEmail { get; set; }

    }
}
