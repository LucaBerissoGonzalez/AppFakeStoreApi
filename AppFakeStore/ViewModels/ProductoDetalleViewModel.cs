using AppFakeStore.Models;
using AppFakeStore.Utils;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppFakeStore.ViewModels;

public partial class ProductoDetalleViewModel : BaseViewModel
{
    [ObservableProperty]
    Producto producto;

    public ProductoDetalleViewModel()
    {
        Title = "Detalle de Producto";
    }

    [RelayCommand]
    private async Task GoBack()
    {
        //volver a la lista completa
        await Application.Current.MainPage.Navigation.PopAsync();
    }

    
}
