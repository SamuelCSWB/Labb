using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace Labb
{
    public class UserDataImporter : IUserDataAccess
    {
        private readonly HttpClient _httpClient = new HttpClient();


        public async Task<IEnumerable<User>> GetUsers()
        {
            var jsonUser = await _httpClient.GetFromJsonAsync<List<User>>("https://jsonplaceholder.typicode.com/users");
            return jsonUser ?? new List<User>();
        }

    }

}
