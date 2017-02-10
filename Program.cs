using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vehicle myVehicle = new Vehicle(7);
            Console.WriteLine($"My vehicle can hold {myVehicle.numPassengers} people");
        }
    }
}