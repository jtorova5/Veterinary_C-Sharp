using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JhonatanToro.Models;

public static class ManagerApp
{
    public static Dog CreateDog()
    {
        Console.WriteLine("Ingrese los datos del perro:");
        Console.Write("Id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nombre: ");
        string name = Console.ReadLine();
        Console.Write("Fecha de nacimiento (DD/MM/AAAA): ");
        string birthdate = Console.ReadLine();
        DateTime validateBirthdate = DateTime.Parse(birthdate);
        var flagB = true;
        while (flagB)
        {
            if (validateBirthdate > DateTime.Now)
            {
                Console.WriteLine("Fecha de nacimiento no válida. Ingrese una fecha válida (DD/MM/AAAA).");
            }
            else
            {
                flagB = false;
            }
        }
        DateOnly birthdateValidated = DateOnly.Parse(birthdate);
        Console.Write("Raza: ");
        string breed = Console.ReadLine();
        Console.Write("Color: ");
        string color = Console.ReadLine();
        Console.Write("Peso (kg): ");
        double weightInKg = Convert.ToDouble(Console.ReadLine());
        Console.Write("¿Está castrado? (s/n):");
        string validateStatus = Console.ReadLine().Trim().ToLower();
        bool breedingStatus;
        if (validateStatus == "s")
        {
            breedingStatus = true;
        }
        else
        {
            breedingStatus = false;
        }
        Console.Write("Temperamento (tímido/normal/agresivo): ");
        string validateTemperament = Console.ReadLine().Trim().ToLower();
        var flag = true;
        while (flag)
        {
            if (validateTemperament == "tímido" || validateTemperament == "normal" || validateTemperament == "agresivo" || validateTemperament == "timido")
            {
                flag = false;
            }
            else
            {
                Console.WriteLine("Temperamento no válido. Ingrese un temperamento válido.");
            }
        }
        string temperament = validateTemperament;
        Console.Write("Número de microchip: ");
        string microchipNumber = Console.ReadLine();
        Console.Write("Volumen del ruido del ladrido (bajo/medio/alto): ");
        string validateBarkVolume = Console.ReadLine().Trim().ToLower();
        var flag2 = true;
        while (flag2)
        {
            if (validateBarkVolume == "bajo" || validateBarkVolume == "medio" || validateBarkVolume == "alto")
            {
                flag2 = false;
            }
            else
            {
                Console.WriteLine("Volumen del ruido del ladrido no válido. Ingrese un volumen válido.");
            }
        }
        string barkVolume = validateBarkVolume;
        Console.Write("Tipo de pelo (sin pelo/pelo corto/pelo mediano/pelo largo): ");
        string validateFurLenght = Console.ReadLine().Trim().ToLower();
        var flag3 = true;
        while (flag3)
        {
            if (validateFurLenght == "sin pelo" || validateFurLenght == "pelo corto" || validateFurLenght == "pelo mediano" || validateFurLenght == "pelo largo")
            {
                flag3 = false;
            }
            else
            {
                Console.WriteLine("Tipo de pelo no válido. Ingrese un tipo de pelo válido.");
            }
        }
        string furLenght = validateFurLenght;

        return new Dog(id, name, birthdateValidated, breed, color, weightInKg, breedingStatus, temperament, microchipNumber, barkVolume, furLenght);
    }

    public static Cat CreateCat()
    {
        Console.WriteLine("Ingrese los datos del gato:");
        Console.Write("Id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nombre: ");
        string name = Console.ReadLine();
        Console.Write("Fecha de nacimiento (DD/MM/AAAA): ");
        string birthdate = Console.ReadLine();
        DateTime validateBirthdate = DateTime.Parse(birthdate);
        var flagB = true;
        while (flagB)
        {
            if (validateBirthdate > DateTime.Now)
            {
                Console.WriteLine("Fecha de nacimiento no válida. Ingrese una fecha válida (DD/MM/AAAA).");
            }
            else
            {
                flagB = false;
            }
        }
        DateOnly birthdateValidated = DateOnly.Parse(birthdate);
        Console.Write("Raza: ");
        string breed = Console.ReadLine();
        Console.Write("Color: ");
        string color = Console.ReadLine();
        Console.Write("Peso (kg): ");
        double weightInKg = Convert.ToDouble(Console.ReadLine());
        Console.Write("¿Está castrado? (s/n):");
        string validateStatus = Console.ReadLine().Trim().ToLower();
        bool breedingStatus;
        if (validateStatus == "s")
        {
            breedingStatus = true;
        }
        else
        {
            breedingStatus = false;
        }
        Console.Write("Longitud de pelo (sin pelo/pelo corto/pelo mediano/pelo largo): ");
        string validateFurLenght = Console.ReadLine().Trim().ToLower();
        var flag3 = true;
        while (flag3)
        {
            if (validateFurLenght == "sin pelo" || validateFurLenght == "pelo corto" || validateFurLenght == "pelo mediano" || validateFurLenght == "pelo largo")
            {
                flag3 = false;
            }
            else
            {
                Console.WriteLine("Longitud de pelo no válida. Ingrese un longitud de pelo válida.");
            }
        }
        string furLenght = validateFurLenght;

        return new Cat(id, name, birthdateValidated, breed, color, weightInKg, breedingStatus, furLenght);
    }

    // public static void ShowHeader()
    // {
    // }

    // public static void ShowFooter()
    // {
    // }

    // public static void ShowSeparator()
    // {
    // }
}
