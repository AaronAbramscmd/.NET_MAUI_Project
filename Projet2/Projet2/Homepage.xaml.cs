
namespace Projet2;

public partial class Homepage : ContentPage
{
    List<string> student;



    public Homepage()
	{
		InitializeComponent();
        student = new List<string>();


	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
    }
    private void OnClickExam(object sender, EventArgs e)
	{
        student.Add(ID.Text);


        string StudentID = ID.Text;
        string FirstN = Fname.Text;
        string LastN = Lname.Text;
        string Gmail = Email.Text;

        if (string.IsNullOrEmpty(StudentID) || string.IsNullOrEmpty(FirstN) ||
            string.IsNullOrEmpty(LastN) || string.IsNullOrEmpty(Gmail))
        {
           FailedForm.Text = ("All fields must be filled");
        }
        else
        {
            student.Add (StudentID);
            Shell.Current.GoToAsync("ExamPage");
            //FailedForm.Text = StudentID;
        }
        
	}
}