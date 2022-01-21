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

    public static Animal GetAnimal(int id)
    {
      var response = ApiHelper.GetAnimal(id).Result;
      return JsonConvert.DeserializeObject<Animal>(response);
    }

    public static List<Animal> GetAnimals()
    {
      var response = ApiHelper.GetAnimals().Result;
      return JsonConvert.DeserializeObject<List<Animal>>(response);
    }

    public static void EditAnimal(Animal animal)
    {
      string body = JsonConvert.SerializeObject(animal);
      ApiHelper.UpdateAnimal(animal.AnimalId, body);
    }
  }
}