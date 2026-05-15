namespace SchoolApp;

[QueryProperty(nameof(StudentName), "name")]
public partial class StudentDetailPage : ContentPage
{
    public StudentDetailPage()
    {
        InitializeComponent();
    }

    public string StudentName
    {
        set
        {
            NameLabel.Text = value;
            DetailsLabel.Text = $"Имя содержит {value.Length} символов.";
        }
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}