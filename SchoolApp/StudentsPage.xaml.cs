using SchoolApp.Models;
using SchoolApp.ViewModels;

namespace SchoolApp;

public partial class StudentsPage : ContentPage
{
    private readonly StudentsViewModel _vm;

    public StudentsPage()
    {
        InitializeComponent();
        _vm = new StudentsViewModel();
        BindingContext = _vm;
    }

    private void OnAddClicked(object sender, EventArgs e)
    {
        _vm.AddStudent();
    }

    private async void OnStudentSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not Student student) return;

        await Shell.Current.GoToAsync(
            $"{nameof(StudentDetailPage)}?name={Uri.EscapeDataString(student.Name)}");

        StudentsList.SelectedItem = null;
    }
}