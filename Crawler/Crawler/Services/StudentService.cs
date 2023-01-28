using Crawler.Models;

namespace Crawler.Services;

public class StudentService : IStudentService
{

    private List<Student> _students;

    public StudentService()
    {
        List<Student> students = new();
        students.Add(new Student
        {
            Id = 1,
            Avatar = "avatar.jpg",
            FirstName = "Jan",
            LastName = "Kowalski",
            Birthdate = new DateTime(2002, 5,24),
            Studies = "Informatyka"
        });
        students.Add(new Student
        {
            Id = 2,
            Avatar = "avatar.jpg",
            FirstName = "Anna",
            LastName = "Malewska",
            Birthdate = new DateTime(2000, 5,25),
            Studies = "Grafika"
        });
        students.Add(new Student
        {
            Id = 3,
            Avatar = "avatar.jpg",
            FirstName = "Tomasz",
            LastName = "Zieliński",
            Birthdate = new DateTime(1996, 5,25),
            Studies = "Informatyka"
        });
        students.Add(new Student
        {
            Id = 4,
            Avatar = "avatar.jpg",
            FirstName = "Marian",
            LastName = "Paździoch",
            Birthdate = new DateTime(1945, 2,12),
            Studies = "Informatyka"
        });
        students.Add(new Student
        {
            Id = 5,
            Avatar = "avatar.jpg",
            FirstName = "Ferdynand",
            LastName = "Kiepski",
            Birthdate = new DateTime(1960, 10,11),
            Studies = "Grafika"
        });
        students.Add(new Student
        {
            Id = 6,
            Avatar = "avatar.jpg",
            FirstName = "Anna",
            LastName = "Dębowska",
            Birthdate = new DateTime(2000, 7,25),
            Studies = "Sztuczna Inteligencja"
        });
        students.Add(new Student
        {
            Id = 7,
            Avatar = "avatar.jpg",
            FirstName = "Katarzyna",
            LastName = "Mrówka",
            Birthdate = new DateTime(1990, 3,3),
            Studies = "Sztuka"
        });
        students.Add(new Student
        {
            Id = 8,
            Avatar = "avatar.jpg",
            FirstName = "Marysia",
            LastName = "Zalewska",
            Birthdate = new DateTime(1992, 9,14),
            Studies = "Grafika"
        });
        students.Add(new Student
        {
            Id = 9,
            Avatar = "avatar.jpg",
            FirstName = "Małgorzata",
            LastName = "Majerska",
            Birthdate = new DateTime(1997, 7,6),
            Studies = "Grafika"
        });
        students.Add(new Student
        {
            Id = 10,
            Avatar = "avatar.jpg",
            FirstName = "Zbigniew",
            LastName = "Mural",
            Birthdate = new DateTime(1989, 3,12),
            Studies = "Obróbka i sskrawanie"
        });
        _students = students;
    }

    public List<Student> GetStudents()
    {
        return _students;
    }

    public Student GetStudent(int id)
    {
        return _students.Find(s => s.Id == id);
    }

}