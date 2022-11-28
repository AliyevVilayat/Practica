namespace Practica7.Entity;

public abstract class Vehicle
{

    public string Color { get; set; }
    public int Year { get; set; }

    public Vehicle(int year)
    {
        Year = year;
    }

    public abstract void ShowInfo();
}
