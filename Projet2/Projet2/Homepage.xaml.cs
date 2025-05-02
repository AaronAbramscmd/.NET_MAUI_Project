namespace Projet2;

public partial class Homepage : ContentPage
{
	public Homepage()
	{
		InitializeComponent();


	}
    private void OnClickExam(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("ExamPage");
	}
}