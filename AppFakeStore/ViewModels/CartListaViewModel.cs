using AppFakeStore.Models;
using AppFakeStore.Services;
using AppFakeStore.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace AppFakeStore.ViewModels
{
    public partial class CartListaViewModel : BaseViewModel
    {
        public ObservableCollection<Cart> Carts { get; } = new();

        [ObservableProperty]
        bool isRefreshing;

        ICartService _cartService;
        public CartListaViewModel(ICartService cartService)
        {
            Title = "Lista de Carritos";
            _cartService = cartService;
        }

        [RelayCommand]
        private async Task GetCartsAsync()
        {
            if (!IsBusy)
            {
                try
                {
                    IsBusy = true;

                    // consultamos lista de productos
                    var carts = await _cartService.GetCartsAsync();

                    if (carts != null)
                    {
                        if (Carts.Count != 0)
                            Carts.Clear();

                        foreach (var cart in carts)
                            Carts.Add(cart);
                    }

                    IsBusy = false;
                }
                catch (Exception ex)
                {
                    await App.Current.MainPage.DisplayAlert("Error!", ex.Message, "Ok");
                }
                finally
                {
                    IsBusy = false;
                }

            }
        }
    }
}
