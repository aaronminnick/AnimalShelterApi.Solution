using RestSharp;
using System.Threading.Tasks;

namespace AnimalShelterConsumer.Models
{
  public static class ApiHelper
  {
    static RestClient client = new RestClient("http://localhost:5000/api");
    public static async Task<string> Get()
    {
      RestRequest request = new RestRequest($"animals", Method.Get);
      var response = await client.ExecuteGetAsync(request);
      return response.Content;
    }
  }
}