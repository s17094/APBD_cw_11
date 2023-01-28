using Crawler.Models;

namespace Crawler.Services;

public interface IStudentService
{
    public List<Student> GetStudents();
    public Student GetStudent(int id);
}