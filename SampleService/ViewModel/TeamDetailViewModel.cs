using CommunityToolkit.Mvvm.ComponentModel;
using SampleService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleService.ViewModel
{
    public partial class TeamDetailViewModel:ObservableObject
    {
        [ObservableProperty]
        Team team;
    }
}
