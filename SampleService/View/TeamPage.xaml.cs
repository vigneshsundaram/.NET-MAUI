using SampleService.Model;
using SampleService.ViewModel;

namespace SampleService.View;

public partial class TeamPage : ContentPage
{
	public TeamPage()
	{
		InitializeComponent();
		BindingContext = new TeamViewModel();
	}

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {

		var teamSelected = (Team)e.Item;
		TeamDetailViewModel teamDetailViewModel = new TeamDetailViewModel() { Team = teamSelected };
		TeamsDetail teamsDetail = new TeamsDetail();
		teamsDetail.BindingContext = teamDetailViewModel;
		Navigation.PushAsync(teamsDetail);

    }
}