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

	private void OnClearClicked(object sender, EventArgs e)
	{
	  // Question 1
        E1.IsChecked = false;
        E2.IsChecked = false;
        E3.IsChecked = false;
        E4.IsChecked = false;

	  // Question 2
        E5.IsChecked = false;
        E6.IsChecked = false;
        E7.IsChecked = false;
        E8.IsChecked = false;

	  // Question 3
		E9.IsChecked = false;
		E10.IsChecked = false;
		E11.IsChecked = false;
		E12.IsChecked = false;

		// Question 4
		E13.IsChecked = false;
		E14.IsChecked = false;
		E15.IsChecked = false;
		E16.IsChecked = false;

		// Question 5
		option1.IsChecked = false;
		option2.IsChecked = false;
		option3.IsChecked = false;
		option4.IsChecked = false;
		option5.IsChecked = false;
    }

	
}