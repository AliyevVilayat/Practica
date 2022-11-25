using ConsoleApp13.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Entitiy
{
    public class Departament
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        private Employee[] emplooyesArr;

        public Departament(int EmployeeLimit)
        {
            emplooyesArr = new Employee[EmployeeLimit];
        }

        public Employee this[int index] {
            get{ return emplooyesArr[index]; } 
            set{ emplooyesArr[index] = value; }
       }

        public void AddEmployee(Employee employee)
        {
            if (emplooyesArr[emplooyesArr.Length - 1] ==null)
            {
                for (int i = 0; i < emplooyesArr.Length; i++)
                {
                    if (emplooyesArr[i] == null)
                    {
                        this[i] = employee;
                    }
                }
            }
            else
            {
                throw new CapacityLimitException("Employee Limiti kecdiniz");
            }
        }
    }
}
