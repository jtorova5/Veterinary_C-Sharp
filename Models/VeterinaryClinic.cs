using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace PruebaC_sharp_JhonatanToro.Models;

public class VeterinaryClinic
{
    public string Name { get; set; }
    public string Address { get; set; }
    public static List<Dog> Dogs { get; set; } = [];
    public static List<Cat> Cats { get; set; } = [];

    public VeterinaryClinic()
    {
    }
    public VeterinaryClinic(string name, string address)
    {
        Name = name;
        Address = address;
    }

    public static void SaveDog(Dog newDog)
    {
        Dogs.Add(newDog);
        Console.WriteLine($"Perro agregado con éxito.");
    }

    public static void SaveCat(Cat newCat)
    {
        Cats.Add(newCat);
        Console.WriteLine($"Gato agregado con éxito.");
    }

    public static void UpdateDog()
    {
        Console.Write("Ingrese el nombre del perro a actualizar: ");
        string newName = Console.ReadLine().Trim().ToLower();
        Console.Clear();
        Console.WriteLine("----------------------------------");
        Console.WriteLine("|            Opciones            |");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("| 1.  Nombre                     |");
        Console.WriteLine("| 2.  Fecha de nacimiento        |");
        Console.WriteLine("| 3.  Raza                       |");
        Console.WriteLine("| 4.  Color                      |");
        Console.WriteLine("| 5.  Peso                       |");
        Console.WriteLine("| 6.  ¿Castrado?                 |");
        Console.WriteLine("| 7.  Temperamento               |");
        Console.WriteLine("| 8.  Número microchip           |");
        Console.WriteLine("| 9.  Volumen ladrido            |");
        Console.WriteLine("| 10. Pelo                       |");
        Console.WriteLine("----------------------------------");
        Console.WriteLine();
        Console.Write("Elija una opción para actualizar: ");
        string input = Console.ReadLine();

        Dog dog = Dogs.FirstOrDefault(d => d.NamePublic() == newName);

        if (int.TryParse(input, out int opcion))
        {
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el nuevo nombre: ");
                    newName = Console.ReadLine().Trim().ToLower();
                    dog.UpdateName(newName);
                    break;
                case 2:
                    Console.Write("Ingrese la nueva fecha de nacimiento (DD/MM/AAAA): ");
                    string newBirthDateString = Console.ReadLine();
                    dog.UpdateBirthDate(DateOnly.Parse(newBirthDateString));
                    break;
                case 3:
                    Console.Write("Ingrese la nueva raza: ");
                    dog.UpdateBreed(Console.ReadLine());
                    break;
                case 4:
                    Console.Write("Ingrese el nuevo color: ");
                    dog.UpdateColor(Console.ReadLine());
                    break;
                case 5:
                    Console.Write("Ingrese el nuevo peso (kg): ");
                    dog.UpdateWeightInKg(double.Parse(Console.ReadLine()));
                    break;
                case 6:
                    Console.Write("¿Está castrado? (s/n): ");
                    dog.BreedingStatus = bool.Parse(Console.ReadLine());
                    break;
                case 7:
                    Console.Write("Ingrese el nuevo temperamento (tímido/normal/agresivo): ");
                    dog.Temperament = Console.ReadLine();
                    break;
                case 8:
                    Console.Write("Ingrese el nuevo número del microchip: ");
                    dog.MicrochipNumber = Console.ReadLine();
                    break;
                case 9:
                    Console.Write("Ingrese el nuevo volumen del ladrido: ");
                    dog.BarkVolume = Console.ReadLine();
                    break;
                case 10:
                    Console.Write("Ingrese el nuevo tipo de pelo: ");
                    dog.CoatType = Console.ReadLine();
                    break;
                default:
                    Console.Clear();
                    Console.Write("Opción inválida. Intente nuevamente.");
                    Console.ReadKey();
                    Console.Clear();
                    UpdateDog();
                    break;
            }
            Console.Write("Actualizado");
        }
        else
        {
            Console.Clear();
            Console.Write("Opción inválida. Solo se permiten números.");
            Console.WriteLine();
            UpdateDog();
        }
    }

    public static void UpdateCat()
    {
        Console.Write("Ingrese el nombre del gato a actualizar: ");
        string newName = Console.ReadLine().Trim().ToLower();
        Console.Clear();
        Console.WriteLine("----------------------------------");
        Console.WriteLine("|            Opciones            |");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("| 1.  Nombre                     |");
        Console.WriteLine("| 2.  Fecha de nacimiento        |");
        Console.WriteLine("| 3.  Raza                       |");
        Console.WriteLine("| 4.  Color                      |");
        Console.WriteLine("| 5.  Peso                       |");
        Console.WriteLine("| 6.  ¿Castrado?                 |");
        Console.WriteLine("| 7.  Pelo                       |");
        Console.WriteLine("----------------------------------");
        Console.WriteLine();
        Console.Write("Elija una opción para actualizar: ");

        string input = Console.ReadLine();
        Cat catToUpdate = Cats.FirstOrDefault(c => c.NamePublic() == newName);

        if (int.TryParse(input, out int opcion))
        {
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el nuevo nombre: ");
                    newName = Console.ReadLine().Trim().ToLower();
                    catToUpdate.UpdateName(newName);
                    break;
                case 2:
                    Console.Write("Ingrese la nueva fecha de nacimiento (DD/MM/AAAA): ");
                    string newBirthDateString = Console.ReadLine();
                    catToUpdate.UpdateBirthDate(DateOnly.Parse(newBirthDateString));
                    break;
                case 3:
                    Console.Write("Ingrese la nueva raza: ");
                    string newBreed = Console.ReadLine();
                    catToUpdate.UpdateBreed(newBreed);
                    break;
                case 4:
                    Console.Write("Ingrese el nuevo color: ");
                    catToUpdate.UpdateColor(Console.ReadLine());
                    break;
                case 5:
                    Console.Write("Ingrese el nuevo peso (kg): ");
                    double newPeso = Convert.ToDouble(Console.Read());
                    catToUpdate.UpdateWeightInKg(newPeso);
                    break;
                case 6:
                    Console.Write("¿Está castrado? (s/n): ");
                    var option = Console.ReadLine().Trim().ToLower();
                    if (option == "s")
                    {
                        catToUpdate.BreedingStatus = true;
                    }
                    else
                    {
                        catToUpdate.BreedingStatus = false;
                    }
                    break;
                case 7:
                    Console.Write("Ingrese el nuevo tipo de pelo: ");
                    catToUpdate.FurLenght = Console.ReadLine();
                    break;
            }
            Console.Write("Actualizado");
        }
    }

    public void DeleteDog(int id)
    {

    }

    public void DeleteCat(int id)
    {

    }

    public static void ShowDogs()
    {
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("|                                               Perros registrados                                                |");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("| Id |        Nombre        |       Raza       |    Color    | Edad(m) | ¿Castrado? | Temperamento |     Pelo     |");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
        foreach (var dog in Dogs)
        {
            dog.ShowInformacion();
        }
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
    }

    public static void ShowCats()
    {
        Console.WriteLine("----------------------------------------------------------------------------------------------------");
        Console.WriteLine("|                                        Gatos registrados                                         |");
        Console.WriteLine("----------------------------------------------------------------------------------------------------");
        Console.WriteLine("| Id |        Nombre        |       Raza       |    Color    | Edad(m) | ¿Castrado? |     Pelo     |");
        Console.WriteLine("----------------------------------------------------------------------------------------------------");
        foreach (var cat in Cats)
        {
            cat.ShowInformacion();
        }
        Console.WriteLine("----------------------------------------------------------------------------------------------------");
    }

    public static void ShowAllPatients()
    {
        ShowDogs();
        Console.WriteLine();
        Console.WriteLine();
        ShowCats();
    }

    public void ShowAnimal(string type)
    {

    }

    public void ShowPatient(string name)
    {

    }
}
