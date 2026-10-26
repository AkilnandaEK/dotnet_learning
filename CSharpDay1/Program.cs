
using System;

public class Program
{
    public static void Main(string[] args)
    {
        EmployeeService service = new EmployeeService();

        while (true)
        {
            Console.WriteLine("\n===== Employee Management =====");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Show All Employees");
            Console.WriteLine("3. Find Employee");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write(
                        "Enter employee details (ID,Name,Department,Salary): ");

                    string? input = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        service.AddEmployee(input);
                    }
                    else
                    {
                        Console.WriteLine("Input cannot be empty.");
                    }

                    break;

                case "2":
                    service.ShowAllEmployes();
                    break;

                case "3":
                    Console.Write("Enter employee ID to search: ");

                    if (int.TryParse(Console.ReadLine(), out int id))
                    {
                        Employee? employee = service.FindEmployee(id);

                        if (employee != null)
                        {
                            Console.WriteLine(
                                $"ID: {employee.employeeId}\n" +
                                $"Name: {employee.employeeName}\n" +
                                $"Department: {employee.department}\n" +
                                $"Salary: {employee.salary}");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid employee ID.");
                    }

                    break;

                case "4":
                    Console.WriteLine("Exiting application...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
