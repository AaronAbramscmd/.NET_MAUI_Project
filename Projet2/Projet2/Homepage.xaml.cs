namespace Projet2;

public partial class Homepage : ContentPage
{
	public Homepage()
	{
		InitializeComponent();


	}
    private void OnClickExam(object sender, EventArgs e)
	{
        string StudentID = ID.Text;
        string FirstN = Fname.Text;
        string LastN = Lname.Text;
        string Gmail = Email.Text;

        if (string.IsNullOrEmpty(StudentID) || string.IsNullOrEmpty(FirstN) ||
            string.IsNullOrEmpty(LastN) || string.IsNullOrEmpty(Gmail))
        {
           FailedForm.Text = "All fields must be filled"; 
        }
        else
        {
            Shell.Current.GoToAsync("ExamPage");
        }
        
	}
}