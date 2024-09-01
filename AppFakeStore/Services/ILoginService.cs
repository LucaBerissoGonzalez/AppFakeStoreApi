using AppFakeStore.Models;

namespace AppFakeStore.Services
{
    public interface ILoginService
    {
        Task<string> AuthenticateAsync(Login login);

        //Como AppFakeStore no tiene para validar el token este no es necesario
        //Task<bool> ValidateTokenAsync(string token);
    }
}
