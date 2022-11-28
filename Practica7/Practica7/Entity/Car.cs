using System;

namespace Practica7.Entity;

public class Car:Vehicle
{

    public string Brand { get; set; }
    public string Model { get; set; }
    public int MaxSpeed { get; set; }

    
    public Car(string brand, string model, int year):base(year)
    {
        Brand = brand;
        Model = model;
        MaxSpeed = 0;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Color:{base.Color}, Year:{base.Year}, Brand:{this.Brand},Model:{this.Model}, MaxSpeed: {this.MaxSpeed} ");
    }

    public static bool operator >(Car car1, Car car2) => car1.MaxSpeed > car2.MaxSpeed;
    public static bool operator <(Car car1, Car car2) => car1.MaxSpeed < car2.MaxSpeed;
}
