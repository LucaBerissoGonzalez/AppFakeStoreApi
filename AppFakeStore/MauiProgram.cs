using AppFakeStore.Services;
using AppFakeStore.ViewModels;
using AppFakeStore.Views;
using Microsoft.Extensions.Logging;

namespace AppFakeStore
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialDesignIcons");
                });

            builder.Services.AddSingleton<ILoginService, LoginService>();
            builder.Services.AddSingleton<IProductoService, ProductoService>();
            builder.Services.AddSingleton<IUserService, UserService>();

            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<ProductoListaViewModel>();
            builder.Services.AddTransient<UserListaViewModel>();
            builder.Services.AddTransient<UserDetalleViewModel>();

            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<ProductoListaPage>();
            builder.Services.AddTransient<UserListaPage>();
            builder.Services.AddTransient<UserDetallePage>();

            //Cuando pasabas el objeto completo, no necesitabas registrar el servicio en MauiProgram porque estabas creando y
            //pasando las instancias manualmente. Sin embargo, al pasar solo el ID y cargar los detalles del usuario desde la API,
            //necesitas un servicio para manejar esa lógica, y es aquí donde la inyección de dependencias se vuelve útil.

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
