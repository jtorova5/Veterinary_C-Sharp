using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace PruebaC_sharp_JhonatanToro.Models;

public abstract class Animal
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

    public abstract void ShowInformacion();

    protected void BasicReview()
    {
        Console.Write($"| {Id,-3}| {Name,-21}| {Breed,-17}| {Color,-12}|   {Age,-6}|");
    }

    protected int CalculateAgeInMonths()
    {
        var ageInMonths = (DateTime.Today.Year - Birthdate.Year) * 12;
        ageInMonths += DateTime.Today.Month - Birthdate.Month;
        return ageInMonths;
    }

    public int IdPublic()
    {
        return Id;
    }
    public string NamePublic()
    {
        return Name;
    }
    public DateOnly BirthDatePublic()
    {
        return Birthdate;
    }
    public string BreedPublic()
    {
        return Breed;
    }
    public string ColorPublic()
    {
        return Color;
    }
    public double WeightInKgPublic()
    {
        return WeightInKg;
    }

    public void UpdateName(string newName)
    {
        Name = newName;
    }
    public void UpdateBirthDate(DateOnly newBirthDate)
    {
        Birthdate = newBirthDate;
    }
    public void UpdateBreed(string newBreed)
    {
        Breed = newBreed;
    }
    public void UpdateColor(string newColor)
    {
        Color = newColor;
    }
    public void UpdateWeightInKg(double newWeightInKg)
    {
        WeightInKg = newWeightInKg;
    }
}
