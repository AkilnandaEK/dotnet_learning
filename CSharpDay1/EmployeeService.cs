public class EmployeeService
{
    List<Employee> allEmp = new List<Employee>{};
    public void AddEmployee(string emp)
    {
        string[] parts = emp.Split(',');
        Employee Emp = new Employee();
        Emp.employeeId = int.Parse(parts[0]);
        Emp.employeeName = parts[1];
        Emp.department = parts[2];
        Emp.salary = double.Parse(parts[3]);

        allEmp.Add(Emp);
    }

    public void ShowAllEmployes()
    {
        foreach(Employee emp in allEmp)
        {
            Console.WriteLine($"{emp.employeeId}|{emp.employeeName}|{emp.department}|{emp.salary}");
        }
    }

    public Employee FindEmployee(int id)
    {
        foreach(Employee emp in allEmp)
        {
            if (emp.employeeId == id)
            {
                return emp;
            }
        }
        return new Employee();
    }
}