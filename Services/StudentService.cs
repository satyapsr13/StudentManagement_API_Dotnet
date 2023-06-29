using MongoDB.Driver;
using StudentManagement_API_Dotnet.Models;

namespace StudentManagement_API_Dotnet.Services
{
    public class StudentService : IStudentService
    {
        private readonly IMongoCollection<Student> _students;

        public StudentService(IStudentStoreDatabaseSettings settings,IMongoClient mongoClient) {
        
            var database=mongoClient.GetDatabase(settings.DatabaseName);
           _students=  database.GetCollection<Student>(settings.StudentCoursesCollectionName);
        
        }


        public Student CreateStudent(Student student)
        { 
            _students.InsertOne(student);
            return student;
        }

        public Student GetStudent(string id)
        {

            return _students.Find(student => student.Id==id).FirstOrDefault();
        }

        public List<Student> GetStudents()
        { 
          
           return _students.Find(student=>true).ToList();

        }

        public void RemoveStudent(string id)
        {
             _students.DeleteOne(student => student.Id == id) ;
        }

        public void UpdateStudent(string id, Student student)
        {

              _students.ReplaceOne(student => student.Id == id,student) ;

        }
    }
}
