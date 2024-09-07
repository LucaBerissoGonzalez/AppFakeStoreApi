using AppFakeStore.Models;
using System.Net.Http.Headers;
using System.Text.Json;
using AppFakeStore.Utils;
using System.Net.Http.Json;


namespace AppFakeStore.Services
{
    public class CartService : ICartService
    {
        HttpClient client;

        private static JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public CartService()
        {
            client = new HttpClient();

            client.BaseAddress = new Uri(Constants.ApiDataServer);
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<IEnumerable<Cart>> GetCartsAsync()
        {
            var response = await client.GetAsync(Constants.CartEndpoint);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<IEnumerable<Cart>>(options);

            return default;
        }
    }
}
