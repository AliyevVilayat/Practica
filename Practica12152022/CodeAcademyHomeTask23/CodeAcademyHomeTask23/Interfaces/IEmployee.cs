using CodeAcademyHomeTask23.Entity;

namespace CodeAcademyHomeTask23.Interfaces;

public interface IEmployee
{

    List<Employee> GetAllEmployees();

    Employee GetEmployeeById(int id);

    void CreateEmployee(Employee employee);
}
