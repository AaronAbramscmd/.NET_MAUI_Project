namespace Projet2;

public partial class ResultPage : ContentPage
{
	public ResultPage(int score)
	{
		InitializeComponent();

		Answer1.Text = $"Your score: {score}";
	}

   
    private void BackToLogin(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("//MainPage");
	}

	private void OnReportClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("ReportPage");
	}
}