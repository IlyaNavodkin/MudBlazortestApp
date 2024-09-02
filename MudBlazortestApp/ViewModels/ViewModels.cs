using Blazing.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MudBlazortestApp.ViewModels;

public partial class PageViewModel : ViewModelBase
{
    [ObservableProperty]
    private ObservableCollection<ManufactureViewModel> _sourceManufactures;

    [ObservableProperty]
    private ObservableCollection<GroupViewModel> _groups;
}

public partial class GroupViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private bool _isVisible;

    [ObservableProperty]
    private ObservableCollection<ManufactureViewModel> _manufactures;

    [ObservableProperty]
    private ManufactureViewModel _selectedManufacture;

    [ObservableProperty]
    private CatalogViewModel _selectedCatalog;
}

public partial class ManufactureViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private ObservableCollection<CatalogViewModel> _catalogs;
}

public partial class CatalogViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _name;
}