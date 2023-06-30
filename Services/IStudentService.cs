using StudentManagement_API_Dotnet.Models;

namespace StudentManagement_API_Dotnet.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetStudent(string id);
        Student CreateStudent(Student student);



        void UpdateStudent(string id,Student student);
        void RemoveStudent(string id);
    }
}
