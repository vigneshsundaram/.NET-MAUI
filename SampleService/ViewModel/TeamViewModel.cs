using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SampleService.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleService.ViewModel
{
   public partial class TeamViewModel :ObservableObject
    {
        [ObservableProperty]
        Team team=new();
        [ObservableProperty]
       ObservableCollection<Team> teams=new();
        [RelayCommand]
        void AddTeam()
        {
           
            Teams.Add(Team);
           
        }
    }
}
