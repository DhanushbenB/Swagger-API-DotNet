using Microsoft.EntityFrameworkCore;

using StudentRegistration.StudentModels;
namespace StudentRegistration.StudentDBContext
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        public DbSet<StudentModel> Student { get; set; }
    }
    
}
