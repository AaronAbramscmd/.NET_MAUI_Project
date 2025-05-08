namespace Projet2
{
    
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            string CorrectPassword = "1234";
            string entPassword = Password.Text;
            

            if (entPassword != CorrectPassword)
            {
                Wrong.Text = "This password is Incorrect!";
            }
            else
            {
                
                Shell.Current.GoToAsync("HomePage");
            }
        }

       
    }

}
