using Microsoft.AspNetCore.Components;
using MudBlazortestApp.ViewModels;

namespace MudBlazortestApp.Components.Widgets;

public partial class GroupSelectionComponent
{
    [Parameter]
    public GroupViewModel SelectedGroup { get; set; }
}