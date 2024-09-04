using SampleService.View;

namespace SampleService
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TeamPage),typeof(TeamPage));
            Routing.RegisterRoute(nameof(TeamsDetail),typeof(TeamsDetail));
        }
    }
}
