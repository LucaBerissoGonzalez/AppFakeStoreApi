using AppFakeStore.Views;
using CommunityToolkit.Mvvm.Input;

namespace AppFakeStore.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    public MainViewModel()
    {
        Title = "ITES - Demo MVVM";
    }

    [RelayCommand]
    public async Task GoToProductoLista()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new ProductoListaPage());
    }

    [RelayCommand]
    public async Task GoToCartLista()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new CartListaPage());
    }

    [RelayCommand]
    public async Task GoToUserLista()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new UserListaPage());
    }

    [RelayCommand]
    public async Task GoToAcerca()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new AboutView());
    }

    [RelayCommand]
    public async Task CerrarSesion()
    {
        bool answer = await Application.Current.MainPage.DisplayAlert("Cerrar Sesión", "¿Desea terminar la sesión?", "Aceptar", "Cancelar");
        if (answer)
        {


            await Application.Current.MainPage.Navigation.PopToRootAsync();
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new LoginPage()));


        }


    }

    [RelayCommand]
    public async Task Exit()
    {
        bool answer = await Application.Current.MainPage.DisplayAlert("Salir", "¿Desea Salir de la Aplicación?", "Aceptar", "Cancelar");
        if (answer)
        {
            Application.Current.Quit();

        }
    }
}
