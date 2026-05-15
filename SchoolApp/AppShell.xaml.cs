namespace SchoolApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(StudentsPage), typeof(StudentsPage));
        Routing.RegisterRoute(nameof(StudentDetailPage), typeof(StudentDetailPage));
    }
}