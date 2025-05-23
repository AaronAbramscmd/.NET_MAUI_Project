
using System.Threading.Tasks;

namespace Projet2;

public partial class Homepage : ContentPage
{
    public class Student
    {
        public string ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
    }

    List<Student> students;

    public Homepage()
	{
		InitializeComponent();
        students = new List<Student>();


	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
    }
    private async void OnClickExam(object sender, EventArgs e)
	{


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
            var student = new Student
            {
                ID = StudentID,
                Fname = FirstN,
                Lname = LastN,
                Email = Gmail,
            };
            students.Add(student);
            await Shell.Current.GoToAsync("ExamPage");
            //FailedForm.Text = StudentID;
        }
        
	}
}