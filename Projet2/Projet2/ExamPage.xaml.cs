using System.Collections;

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
        bool IsRadioButtonChecked(StackLayout group)
        {
            return group.Children
                .OfType<RadioButton>()
                .Any(rb => rb.IsChecked == true);
        }

        bool IsCheckBoxChecked(StackLayout group) 
        { 
            return group.Children 
                .OfType<CheckBox>()
                .Any (rb => rb.IsChecked == true);
        }



        if (!IsRadioButtonChecked(Questions))
        {
            NoAnswers.Text = ("Answer every question");
        }
        else
        {
            Shell.Current.GoToAsync("ResultPage");
        }



    }

	private void OnClearClicked(object sender, EventArgs e)
	{
		
	  // Question 1 ( C is the correct answer)
        E1.IsChecked = false;
        E2.IsChecked = false;
        E3.IsChecked = false;
        E4.IsChecked = false;

	  // Question 2 ( B is the corect answer)
        E5.IsChecked = false;
        E6.IsChecked = false;
        E7.IsChecked = false;
        E8.IsChecked = false;

	  // Question 3 ( A is the correct answer)
		E9.IsChecked = false;
		E10.IsChecked = false;
		E11.IsChecked = false;
		E12.IsChecked = false;

		// Question 4 ( B is the correct answer)
		E13.IsChecked = false;
		E14.IsChecked = false;
		E15.IsChecked = false;
		E16.IsChecked = false;

		// Question 5 ( 1,2, and 4 are the correct answers)
		option1.IsChecked = false;
		option2.IsChecked = false;
		option3.IsChecked = false;
		option4.IsChecked = false;
		option5.IsChecked = false;
    }

	
}