using System.ComponentModel;
using PruebaC_sharp_JhonatanToro.Models;

var dog1 = new Dog(1, "grecia", new DateOnly(2021, 04, 15), "criolla", "panela", 17, true, "tímido", "100200", "medio", "pelo corto");
var dog2 = new Dog(2, "pepito", new DateOnly(2022, 05, 10), "bulldog", "blanco", 20, false, "normal", "100300", "alto", "pelo mediano");

VeterinaryClinic.SaveDog(dog1);
VeterinaryClinic.SaveDog(dog2);

var cat1 = new Cat(1, "hidraulico", new DateOnly(2020, 12, 24), "siames", "vainilla", 5, true, "pelo corto");
var cat2 = new Cat(2, "alaska", new DateOnly(2021, 06, 10), "persa", "nieve", 4, false, "pelo largo");

VeterinaryClinic.SaveCat(cat1);
VeterinaryClinic.SaveCat(cat2);

void getMenu()
{
    Console.Write(@"
Presione cualquier tecla para volver al menú principal.");
    Console.ReadKey();
    Menu();
}

void addDog()
{
    var newDog = ManagerApp.CreateDog();
    VeterinaryClinic.SaveDog(newDog);
}

void addCat()
{
    var newCat = ManagerApp.CreateCat();
    VeterinaryClinic.SaveCat(newCat);
}

void Menu()
{
    Console.Clear();
    Console.WriteLine("----------------------------------");
    Console.WriteLine("|       Centro veterinario       |");
    Console.WriteLine("----------------------------------");
    Console.WriteLine("| 1.  Mostrar animales           |");
    Console.WriteLine("| 2.  Agregar perro              |");
    Console.WriteLine("| 3.  Agregar gato               |");
    Console.WriteLine("| 4.  Actualizar perro           |");
    Console.WriteLine("| 5.  Actualizar gato            |");
    Console.WriteLine("| 6.  Eliminar perro             |");
    Console.WriteLine("| 7.  Eliminar gato              |");
    Console.WriteLine("| 0.  Salir                      |");
    Console.WriteLine("----------------------------------");
    Console.WriteLine();
    Console.Write("Elija una opción: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int opcion))
    {
        switch (opcion)
        {
            case 1:
                Console.Clear();
                VeterinaryClinic.ShowAllPatients();
                getMenu();
                break;
            case 2:
                Console.Clear();
                VeterinaryClinic.ShowDogs();
                addDog();
                getMenu();
                break;
            case 3:
                Console.Clear();
                VeterinaryClinic.ShowCats();
                addCat();
                getMenu();
                break;
            case 4:
                Console.Clear();
                VeterinaryClinic.ShowDogs();
                VeterinaryClinic.UpdateDog();
                getMenu();
                break;
            case 5:
                Console.Clear();
                VeterinaryClinic.ShowCats();
                VeterinaryClinic.UpdateCat();
                getMenu();
                break;
            case 6:
                Console.Clear();
                VeterinaryClinic.ShowDogs();
                VeterinaryClinic.DeleteDog();
                getMenu();
                break;
            case 7:
                Console.Clear();
                VeterinaryClinic.ShowCats();
                VeterinaryClinic.DeleteCat();
                getMenu();
                break;
            case 0:
                Console.Clear();
                Console.WriteLine("Saliendo del sistema...");
                Console.ReadKey();
                Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Console.Write("Opción inválida. Intente nuevamente.");
                Console.WriteLine();
                getMenu();
                break;
        }
    }
    else
    {
        Console.Clear();
        Console.Write("Opción inválida. Solo se permiten números.");
        Console.WriteLine();
        getMenu();
    }

}

Menu();