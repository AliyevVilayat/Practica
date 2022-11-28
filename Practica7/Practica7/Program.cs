
using Practica7.Entity;

Car car = new Car("Mercedes","S-Class 6.3 AMG",2022);
car.MaxSpeed = 200;

Car car1 = new Car("Mercedes","S-Class 6.3 AMG",2022);
car1.MaxSpeed = 360;

Console.WriteLine(car1>car);

/*Bus bus = new Bus(10, 2015);

Vehicle[] vehicles = {car,bus };

foreach (var vehicle in vehicles)
{

    vehicle.ShowInfo();
}*/
