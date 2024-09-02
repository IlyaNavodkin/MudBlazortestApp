using Microsoft.AspNetCore.Components;
using MudBlazortestApp.ViewModels;
using System.Collections.ObjectModel;

namespace MudBlazortestApp.Components.Widgets;

public partial class GroupListComponent
{
    [Parameter]
    public ObservableCollection<GroupViewModel> Groups { get; set; }

    [Parameter]
    public EventCallback<GroupViewModel> OnGroupSelected { get; set; }

    private async Task SelectGroup(GroupViewModel group)
    {
        await OnGroupSelected.InvokeAsync(group);
    }
}