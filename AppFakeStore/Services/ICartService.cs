using AppFakeStore.Models;

namespace AppFakeStore.Services
{
    public interface ICartService
    {
        Task<IEnumerable<Cart>> GetCartsAsync();
    }
}
