using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Services;
using StudentRegistration.StudentModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _student;

        public StudentController(IStudent student)
        {
            _student = student;
        }
        /// <summary>
        /// To get the list of students
        /// </summary>
        /// <returns></returns>
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<StudentModel> Get()
        {
            return _student.GetStudent();
        }

        /// <summary>
        /// To add a student
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task Add(StudentModel student)
        {
            await _student.AddStudent(student);
        }
        /// <summary>
        /// To update student
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPost("updateStudent")]
        public async Task UpdateStudent(StudentModel student)
        {
            await _student.UpdateStudent(student);
        }
        /// <summary>
        /// To delete student
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task DeleteStudent(int student)
        {
            await _student.DeleteStudent(student);
        }

    }
}
