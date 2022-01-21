using Newtonsoft.Json;
using System.Collections.Generic;


namespace AnimalShelterConsumer.Models
{
  public class Animal
  {
    public int AnimalId {get; set;}
    public string Name {get; set;}
    public string Species {get; set;}
    public string Breed {get; set;}

    public static List<Animal> GetAnimals()
    {
      var response = ApiHelper.Get().Result;
      return JsonConvert.DeserializeObject<List<Animal>>(response);
    }
  }
}