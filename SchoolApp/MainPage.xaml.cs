namespace SchoolApp;

public partial class MainPage : ContentPage
{
    private int _count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnTapClicked(object sender, EventArgs e)
    {
        _count++;
        StatusLabel.Text = $"Button tapped {_count} time(s).";
    }
}