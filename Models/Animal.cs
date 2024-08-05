using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace PruebaC_sharp_JhonatanToro.Models;

public class Animal
{
    protected int Id { get; set; }
    protected string Name { get; set; }
    protected DateOnly Birthdate { get; set; }
    protected string Breed { get; set; }
    protected string Color { get; set; }
    protected double WeightInKg { get; set; }
    protected int Age { get; set; }

    public Animal(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg)
    {
        Id = id;
        Name = name;
        Birthdate = birthdate;
        Age = CalculateAgeInMonths();
        Breed = breed;
        Color = color;
        WeightInKg = weightInKg;
    }

    public void ShowInformacion()
    {
        BasicReview();
    }

    protected void BasicReview()
    {
        Console.Write($"|{Id}|{Name}|{Breed}|{Color}|{Age}|");
    }

    protected int CalculateAgeInMonths()
    {
        var ageInMonths = (DateTime.Today.Year - Birthdate.Year) * 12;
        ageInMonths += DateTime.Today.Month - Birthdate.Month;
        return ageInMonths;
    }
}
