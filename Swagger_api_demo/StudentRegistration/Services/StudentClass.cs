using StudentRegistration.StudentDBContext;
using StudentRegistration.StudentModels;

namespace StudentRegistration.Services
{
    public class StudentClass : IStudent
    {
        private readonly StudentContext _studentContext;

        public StudentClass(StudentContext studentcontext)
        {
            _studentContext = studentcontext;
        }
        public IEnumerable<StudentModel> GetStudent()
        {
            return _studentContext.Student.ToList();
        }

        public async Task AddStudent(StudentModel newstudent)
        {
            await _studentContext.Student.AddAsync(newstudent);
            await _studentContext.SaveChangesAsync();

        }
        public async Task UpdateStudent(StudentModel student)
        {
            var existingStudent = await _studentContext.Student.FindAsync(student.studentId);
            if (existingStudent != null)
            {
                _studentContext.Entry(existingStudent).CurrentValues.SetValues(student);
                await _studentContext.SaveChangesAsync();
            }
        }

        public async Task DeleteStudent(int student)
        {
            var removestudent = await _studentContext.Student.FindAsync(student);
            _studentContext.Remove(removestudent);
            await _studentContext.SaveChangesAsync();
        }
    }
}
