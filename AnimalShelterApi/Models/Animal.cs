using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalShelterApi.Models
{
  public enum Species
  {
    Bird,
    Cat,
    Dog,
    Ferret,
    Hamster,
    Horse,
    Pig,
    Rabbit,
    Rodent
  }

  public class Animal
  {
    public int AnimalId {get; set;}
    public string Name {get; set;}

    [Column(TypeName = "varchar(16)")]
    public Species Species {get; set;}

    public string Breed {get; set;}
  }
}