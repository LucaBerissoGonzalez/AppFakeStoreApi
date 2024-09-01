using AppFakeStore.Models;
using AppFakeStore.Services;
using AppFakeStore.ViewModels;

namespace AppFakeStore.Views;

public partial class UserDetallePage : ContentPage
{
    private readonly UserDetalleViewModel _viewModel;

    public UserDetallePage(int userId)
    {
        InitializeComponent();
        var userService = new UserService(); // Aseg�rate de usar tu m�todo de inyecci�n de dependencias si lo tienes
        _viewModel = new UserDetalleViewModel(userService);
        BindingContext = _viewModel;
        _viewModel.LoadUserDetailsAsync(userId);
    }
}