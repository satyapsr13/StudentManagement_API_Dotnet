using Microsoft.AspNetCore.Mvc;
using StudentManagement_API_Dotnet.Models;
using StudentManagement_API_Dotnet.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentManagement_API_Dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET: api/<StudentsController>
         
        private readonly IStudentService _studentService;
        StudentsController(IStudentService studentService) {
          this._studentService=studentService;
        }

        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            return _studentService.GetStudents();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public ActionResult<Student> Get(string id)
        {
            var student= _studentService.GetStudent(id);

            if(student!=null)
            {
                return NotFound($" Student with Id={id} not found");
            }

            return student;
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

            

        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
