namespace Practica7.Entity;

public class Bus:Vehicle
{
    public Bus(int passangerCount, int year) : base(year)
    {
        PassangerCount = passangerCount;
    }

    public int PassangerCount { get; set; }

    public override void ShowInfo()
    {
        Console.WriteLine($"Color:{base.Color}, Year:{base.Year}, Passanger Count:{PassangerCount} ");
    }
}
