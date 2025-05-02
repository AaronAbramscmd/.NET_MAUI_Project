namespace Projet2;

public partial class ExamPage : ContentPage
{
	public ExamPage()
	{
		InitializeComponent();

		
	}
	private void OnGoBackClicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("..");
    }

	private void OnSubmitClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("ResultPage");
	}
}