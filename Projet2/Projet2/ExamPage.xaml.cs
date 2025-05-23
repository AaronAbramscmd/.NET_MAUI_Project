using System.Collections;
using System.Threading.Tasks;



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

    

    private async void OnSubmitClicked(object sender, EventArgs e)
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

        int score = 0;

        if (E3.IsChecked == true)
        {
            score += 20;
        }
        if (E6.IsChecked == true)
        {
            score += 20;
        }
        if (E9.IsChecked == true)
        {
            score += 20;
        }
        if(E14.IsChecked == true)
        {
            score += 20;
        }
        if(option1.IsChecked && option2.IsChecked && option4.IsChecked && !option3.IsChecked && !option5.IsChecked)
        {
            score += 20;
        } 
        


        if (!IsRadioButtonChecked(Questions))
        {
            NoAnswers.Text = ("Answer every question");
        }
        else
        {
            await Navigation.PushAsync(new ResultPage(score));
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