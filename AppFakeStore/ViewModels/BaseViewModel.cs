using CommunityToolkit.Mvvm.ComponentModel;

namespace AppFakeStore.ViewModels;
//primera clase.
public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    private bool isBusy;  

    [ObservableProperty]
    private string title;
}
