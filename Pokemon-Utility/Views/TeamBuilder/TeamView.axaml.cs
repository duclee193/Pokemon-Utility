using System.Collections.Generic;
using Avalonia.Controls;

namespace Pokemon_Utility.Views.TeamBuilder;

public partial class TeamView : Panel
{
    private TeamTopBar _teamTopBar = new TeamTopBar();
    private TeamPage _teamPage = new TeamPage();


    public TeamView()
    {
        InitializeComponent();
        grid.Children.Add(_teamTopBar);
        grid.Children.Add(_teamPage);
        Grid.SetRow(_teamTopBar,0);
        Grid.SetRow(_teamPage,1);
    }

    public void SetUp()
    {
        grid.Children.Clear();
        grid.Children.Add(_teamTopBar);
        grid.Children.Add(_teamPage);
        Grid.SetRow(_teamTopBar,0);
        Grid.SetRow(_teamPage,1);
        grid.Children.Add(new TeamTopBar(new List<string>{ "First team","Second Team"})) ;
        grid.Children.Add(new TeamPage());
    }
}