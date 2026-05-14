using System;

namespace CarApplication
{
    public class Car
    {
        public string make;
        public string model;
        public int year;
        public double cost;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

         public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get {return year;}
            set {year = value;}
        }

        public double Cost
        {
            get {return cost;}
            set {cost = value;}
        }
        public void DisplayCarInfo()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"Make: \t{make}");
            Console.WriteLine($"Model: \t{model}");
            Console.WriteLine($"Year: \t{year}");
            Console.WriteLine($"Cost: \t${cost}");
        }
    }

    class carInventory
    {
        static void Main()
        {
            Car ford = new Car();
            ford.Make = "Ford";
            ford.Model = "Ranger";
            ford.Year = 2026;
            ford.Cost = 60000;

            Car toyota = new Car();
            toyota.Make = "Toyota";
            toyota.Model = "Camry";
            toyota.Year = 2020;
            toyota.Cost = 15000;

            Car nissan = new Car();
            nissan.Make = "Nissan";
            nissan.Model = "GTR";
            nissan.Year = 2005;
            nissan.Cost = 80000;

            ford.DisplayCarInfo();
            toyota.DisplayCarInfo();
            nissan.DisplayCarInfo();
        }
    }
}