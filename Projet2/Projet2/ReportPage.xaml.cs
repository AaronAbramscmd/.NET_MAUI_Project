namespace Projet2;

public partial class ReportPage : ContentPage
{
	public ReportPage()
	{
		InitializeComponent();
	}

    private void BackToLogin(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }
}