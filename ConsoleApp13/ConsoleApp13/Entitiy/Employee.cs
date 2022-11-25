using ConsoleApp13.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Entitiy;

public class Employee : IPerson
{
    private static int _id;
    public string Name { get ; set ; }
    public int Age { get ; set ; }
    public int Salary { get ; set ; }

    public int Id { get; }

    public Employee(string name,int age,int salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
        _id++;
        Id = _id;
    }

    public string ShowInfo()
    {

        return $"ID:{Id} Name:{Name} , Age:{Age} , Salary:{Salary}";
    }

    public override string ToString()
    {
        return this.ShowInfo();
    }
}
