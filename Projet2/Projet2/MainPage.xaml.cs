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
            Shell.Current.GoToAsync("HomePage");
        }

        private void OnCreateCLicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("CreatePage");
        }
    }

}
