namespace StudentManagement_API_Dotnet.Models
{
    public class StudentStoreDatabaseSettings : IStudentStoreDatabaseSettings
    {

        public string StudentCoursesCollectionName { get ; set ; }
        public string ConnectionString { get ; set ; }
        public string DatabaseName { get ; set ; }
    }
}
