namespace Projet2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("HomePage", typeof(Homepage));

        }
    }
}
