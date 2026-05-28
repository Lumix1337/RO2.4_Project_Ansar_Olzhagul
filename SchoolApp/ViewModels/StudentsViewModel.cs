using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SchoolApp.Models;

namespace SchoolApp.ViewModels;

public class StudentsViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Student> Students { get; } = new();

    private string _newName = "";

    public string NewName
    {
        get => _newName;
        set
        {
            if (value == _newName) return;
            _newName = value;
            OnPropertyChanged();
        }
    }

    public StudentsViewModel()
    {
        // стартовые mock-данные — те же 5 студентов из L14, теперь с GPA
        Students.Add(new Student { Name = "Hughie Campbell", Gpa = 3.85 });
        Students.Add(new Student { Name = "Billy Butcher", Gpa = 3.20 });
        Students.Add(new Student { Name = "Kairat Mukashev", Gpa = 3.95 });
        Students.Add(new Student { Name = "Sultan Danialov", Gpa = 2.75 });
        Students.Add(new Student { Name = "Medina Mukasheva", Gpa = 3.60 });
    }

    public void AddStudent()
    {
        if (string.IsNullOrWhiteSpace(NewName)) return;
        Students.Add(new Student { Name = NewName, Gpa = 3.0 });
        NewName = "";
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}