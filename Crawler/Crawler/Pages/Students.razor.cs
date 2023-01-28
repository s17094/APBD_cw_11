using Crawler.Models;
using Crawler.Services;
using Microsoft.AspNetCore.Components;


namespace Crawler.Pages
{
    public partial class Students
    {
        [Inject]
        public IStudentService StudentService { get; set; }

        private List<Student> _students = new();
        private string _currentSort;

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(4000);
            _students = StudentService.GetStudents();

            _currentSort = "";
        }

        private void DeleteStudent(Student st)
        {
            _students.Remove(st);
        }

        private void SortByFirstName()
        {
            if (_currentSort == "FirstNameAsc")
            {
                _students = _students.OrderByDescending(o => o.FirstName).ToList();
                _currentSort = "FirstNameDesc";
            }
            else
            {
                _students = _students.OrderBy(o => o.FirstName).ToList();
                _currentSort = "FirstNameAsc";
            }
        }

        private void SortByLastName()
        {
            if (_currentSort == "LastNameAsc")
            {
                _students = _students.OrderByDescending(o => o.LastName).ToList();
                _currentSort = "LastNameDesc";
            }
            else
            {
                _students = _students.OrderBy(o => o.LastName).ToList();
                _currentSort = "LastNameAsc";
            }
        }

        private void SortByBirthdate()
        {
            if (_currentSort == "BirthdateAsc")
            {
                _students = _students.OrderByDescending(o => o.Birthdate).ToList();
                _currentSort = "BirthdateDesc";
            }
            else
            {
                _students = _students.OrderBy(o => o.Birthdate).ToList();
                _currentSort = "BirthdateAsc";
            }
        }

        private void SortByStudies()
        {
            if (_currentSort == "StudiesAsc")
            {
                _students = _students.OrderByDescending(o => o.Studies).ToList();
                _currentSort = "StudiesDesc";
            }
            else
            {
                _students = _students.OrderBy(o => o.Studies).ToList();
                _currentSort = "StudiesAsc";
            }
        }

    }
}

