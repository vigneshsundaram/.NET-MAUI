using SampleService.View;

namespace SampleService
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TeamPage());
        }
    }
}
