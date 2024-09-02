using MudBlazortestApp.ViewModels;
using System.Collections.ObjectModel;

namespace MudBlazortestApp.Components.Pages;

public partial class Counter
{
    private PageViewModel PageVM;
    private GroupViewModel selectedGroup;

    private void OnGroupSelected(GroupViewModel group)
    {
        selectedGroup = group;
    }

    protected override void OnInitialized()
    {
        InitializePageViewModel();
    }

    private void InitializePageViewModel()
    {
        PageVM = new PageViewModel();

        // Инициализация производителей в PageViewModel
        var redManufacture = new ManufactureViewModel
        {
            Name = "Red",
            Catalogs = new ObservableCollection<CatalogViewModel>
            {
                new CatalogViewModel { Name = "Red - Lion" },
                new CatalogViewModel { Name = "Red - Elephant" },
            },
        };

        var blueManufacture = new ManufactureViewModel
        {
            Name = "Blue",
            Catalogs = new ObservableCollection<CatalogViewModel>
            {
                new CatalogViewModel { Name = "Blue - Tiger" },
                new CatalogViewModel { Name = "Blue - Giraffe" },
            },
        };

        PageVM.SourceManufactures = new ObservableCollection<ManufactureViewModel>
        {
            redManufacture,
            blueManufacture,
        };

        PageVM.Groups = new ObservableCollection<GroupViewModel>
        {
            new GroupViewModel
            {
                Name = "Group 1",
                Manufactures = new ObservableCollection<ManufactureViewModel>
                {
                    redManufacture,
                    blueManufacture,
                },
            },
            new GroupViewModel
            {
                Name = "Group 2",
                Manufactures = new ObservableCollection<ManufactureViewModel>
                {
                    redManufacture,
                    blueManufacture,
                },
            },
        };
    }

}