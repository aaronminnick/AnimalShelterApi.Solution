using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;

namespace AnimalShelterConsumer.Models
{
  public static class ApiHelper
  {
    static RestClient client = new RestClient("http://localhost:5000/api");

    public static async Task<string> GetAnimal(int id)
    {
      RestRequest request = new RestRequest($"animals/{id}", Method.Get);
      var response = await client.ExecuteGetAsync(request);
      return response.Content;
    }

    public static async Task<string> GetAnimals()
    {
      RestRequest request = new RestRequest($"animals", Method.Get);
      var response = await client.ExecuteGetAsync(request);
      return response.Content;
    }

    public static async void UpdateAnimal(int id, string body)
    {
      RestRequest request = new RestRequest($"animals/{id}", Method.Put);
      request.AddStringBody(body, DataFormat.Json);
      await client.ExecutePutAsync(request);
    }
  }
}