using System;
using System.IO;
using System.Text.Json;

public class Inventory
{
    public required List<Car> Cars { get; set; }
}

public class Car
{
    public required string Make { get; set; }
    public required string Model { get; set; }
    public int Year { get; set; }
    public double Cost { get; set; }
}

class Program
{
    static void Main()
    {
        string jsonFile = File.ReadAllText("inventory.json");
        Inventory inventory = JsonSerializer.Deserialize<Inventory>(jsonFile);
        Console.WriteLine("Current Inventory:");
        Console.WriteLine("------------------");
        foreach (Car car in inventory.Cars)
        {
            Console.WriteLine($"Make: {car.Make}\tModel: {car.Model}\tYear: {car.Year}\t{car.Cost}");
        }

    }
}