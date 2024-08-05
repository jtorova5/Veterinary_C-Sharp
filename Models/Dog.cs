using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JhonatanToro.Models;

public class Dog : Animal
{
    public bool BreedingStatus { get; set; }
    public string Temperament { get; set; }
    public string MicrochipNumber { get; set; }
    public string BarkVolume { get; set; }
    public string CoatType { get; set; }

    public Dog(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string temperament, string microchipNumber, string barkVolume, string coatType) : base(id, name, birthdate, breed, color, weightInKg)
    {
        BreedingStatus = breedingStatus;
        Temperament = temperament;
        MicrochipNumber = microchipNumber;
        BarkVolume = barkVolume;
        CoatType = coatType;
    }

    public void CastrateAnimal()
    {

    }

    public void Hairdress()
    {

    }

    public override void ShowInformacion()
    {
        BasicReview();
        Console.WriteLine($" {BreedingStatus,-11}| {Temperament,-13}| {CoatType,-13}|");
    }
}
