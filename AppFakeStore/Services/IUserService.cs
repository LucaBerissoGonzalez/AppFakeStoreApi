using AppFakeStore.Models;


namespace AppFakeStore.Services
{
    public interface IUserService
    {
        //Task<Usuario> GetUsuarioByIdAsync(int id);
        Task<IEnumerable<User>> GetUsersAsync();

        Task<User> GetUserByIdAsync(int id);
    }
}
