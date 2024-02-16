using System.Text.Json;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Service
{
    internal class Request<T> where T : IRequestable
    {
        private readonly HttpClient _client = new();

        public async Task<T?> Post(T model)
        {
            const string url = "https://jsonplaceholder.typicode.com/posts";
            var data = JsonSerializer.Serialize<T>(model);

            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(url, content);

            if (!response.IsSuccessStatusCode) return default;
            var result = await response.Content.ReadAsStringAsync();
            var serialized = JsonSerializer.Deserialize<T>(result);

            return serialized;
        }
    }
}
