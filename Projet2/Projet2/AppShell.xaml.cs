namespace Projet2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("HomePage", typeof(Homepage));

            Routing.RegisterRoute("ExamPage", typeof (ExamPage));

            Routing.RegisterRoute("ResultPage", typeof(ResultPage));

            Routing.RegisterRoute("MainPage", typeof(MainPage));

            Routing.RegisterRoute("ReportPage", typeof(ReportPage));
        }
    }
}
