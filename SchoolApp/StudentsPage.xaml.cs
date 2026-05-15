namespace SchoolApp;

public partial class StudentsPage : ContentPage
{
    public StudentsPage()
    {
        InitializeComponent();

        StudentsList.ItemsSource = new[]
        {
            "Hughie Campbell",
            "Billy Butcher",
            "Kairat Mukashev",
            "Sultan Danialov",
            "Medina Mukasheva"
        };
    }

    private async void OnStudentSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not string name) return;

        await Shell.Current.GoToAsync(
            $"{nameof(StudentDetailPage)}?name={Uri.EscapeDataString(name)}");

        StudentsList.SelectedItem = null;
    }
}