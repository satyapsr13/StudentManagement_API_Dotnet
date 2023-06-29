﻿using MongoDB.Driver;
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
            throw new NotImplementedException();
        }

        public Student GetStudent(string id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            throw new NotImplementedException();
        }

        public void RemoveStudent(string id)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(string id, Student student)
        {
            throw new NotImplementedException();
        }
    }
}
