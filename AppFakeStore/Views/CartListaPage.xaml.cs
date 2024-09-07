using AppFakeStore.Services;
using AppFakeStore.ViewModels;

namespace AppFakeStore.Views;

public partial class CartListaPage : ContentPage
{
    public CartListaPage()
    {
        CartService service = new CartService();
        CartListaViewModel vm = new CartListaViewModel(service);
        InitializeComponent();
        this.BindingContext = vm;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        var vm = BindingContext as CartListaViewModel;

        if (vm != null)
        {
            await vm.GetCartsCommand.ExecuteAsync(null);
        }
    }
}