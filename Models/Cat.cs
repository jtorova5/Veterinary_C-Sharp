using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JhonatanToro.Models;

public class Cat : Animal
{
    public bool BreedingStatus { get; set; }
    public string FurLenght { get; set; }

    public Cat(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string furLenght) : base(id, name, birthdate, breed, color, weightInKg)
    {
        BreedingStatus = breedingStatus;
        FurLenght = furLenght;
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
        Console.WriteLine($" {BreedingStatus,-11}| {FurLenght,-12} |");
    }
}
