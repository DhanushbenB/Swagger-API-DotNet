using StudentRegistration.StudentModels;

namespace StudentRegistration.Services
{
    public interface IStudent
    {
        IEnumerable<StudentModel> GetStudent();

        Task AddStudent(StudentModel newstudent);

        Task UpdateStudent(StudentModel student);

        Task DeleteStudent(int student);
    }
}
