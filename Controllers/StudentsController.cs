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
        public ActionResult<Student> Post([FromBody] Student student)
        {
            _studentService.CreateStudent(student);

            return CreatedAtAction(nameof(Get), new {id=student.Id}, student);  
            

        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Student student)
        {

            var existingStudent = _studentService.GetStudent(id);
            if(existingStudent==null) {
                return NotFound($"Student with Id= {id} not found");
                    
                    }

            _studentService.UpdateStudent(id, student);
            return NoContent();
        
        
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {

            var existingStudent = _studentService.GetStudent(id);
            if (existingStudent == null)
            {
                return NotFound($"Student with Id= {id} not found");

            }

            _studentService.RemoveStudent(id);
            return Ok($"Student with Id= {id} Deleted");
        }
    }
}
