using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace OOP_Generic_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapade objekt
            Employee employee1 = new Employee(1254, "Sven", "male", 30000);
            Employee employee2 = new Employee(5664, "Eric", "male", 35000);
            Employee employee3 = new Employee(1888, "Sandra", "female", 40000);
            Employee employee4 = new Employee(1233, "Emma", "female", 35000);
            Employee employee5 = new Employee(1356, "Gustav", "male", 30000);

            //Skapade stack
            Stack<Employee> employeesStack = new Stack<Employee>();
            employeesStack.Push(employee1);
            employeesStack.Push(employee2);
            employeesStack.Push(employee3);
            employeesStack.Push(employee4);
            employeesStack.Push(employee5);

            foreach (var employee in employeesStack) //Skriver ut alla objekt i stack samt hur många element som är kvar
            {
                Console.WriteLine($"Antal element i stacken {employeesStack.Count}");
                Console.WriteLine($"{employee.Id} {employee.Name} {employee.Gender} {employee.Salary}");

            }

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Hämtar objekt med POP metoden");

            while (employeesStack.Count > 0) //Hämtar alla objekt i stack via POP
            {
                var employee = employeesStack.Pop();
                Console.WriteLine($"{employee.Id} {employee.Name} {employee.Gender} {employee.Salary}");
                Console.WriteLine($"Totalt antal anställda kvar i stacken = {employeesStack.Count}");

            }

            //lägger till objekten igen i Stack
            employeesStack.Push(employee1);
            employeesStack.Push(employee2);
            employeesStack.Push(employee3);
            employeesStack.Push(employee4);
            employeesStack.Push(employee5);




            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Hämtar med PEEK metoden");

            //Hämtar två objekt med hjälp av PEEK metoden

            while (employeesStack.Count > 0) //Hämtar alla objekt i stack via Peek
            {
                var employee = employeesStack.Peek();
                Console.WriteLine($"{employee1.Id} {employee1.Name} {employee1.Gender} {employee1.Salary}");
                Console.WriteLine($"Totalt antal anställda kvar i stacken = {employeesStack.Count}");

                Console.WriteLine($"{employee2.Id} {employee2.Name} {employee2.Gender} {employee2.Salary}");
                Console.WriteLine($"Totalt antal anställda kvar i stacken = {employeesStack.Count}");
                break;
            }

                if (employeesStack.Contains(employee3)) //Om employee 3 finns med i listan eller inte
                {
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.WriteLine("Employee 3 finns i stacken");
                    Console.WriteLine("--------------------------------------------------------------------");
                }

                else
                {
                    Console.WriteLine("Employee 3 finns inte i stack");
                }
               

            //--------------------------------------------------------------------------------------------------------



            //Skapar andra delen som handlar om listan med employee
            List<Employee> emp = new List<Employee>();
            emp.Add(employee1);
            emp.Add(employee2);
            emp.Add(employee3);
            emp.Add(employee4);
            emp.Add(employee5);

            if (emp.Contains(employee2)) //Använder Contians för och se se om employee 2 finns med i listan
            {
                Console.WriteLine("Employee 2 finns med i listan");
            }

            else
            {
                Console.WriteLine("Employee 2 finns inte med i listan");
            }

            //Använder Find()-metoden för att hitta och skriva ut det första objektet i listan som har "male som gender
            Employee firstMaleEmployee = emp.Find(emp => emp.Gender == "male");
            Console.WriteLine($"Id:{firstMaleEmployee.Id}, Name: {firstMaleEmployee.Name}, Gender: {firstMaleEmployee.Gender}, Salary: {firstMaleEmployee.Salary}");
            Console.WriteLine("--------------------------------------------------------------------");
            //Använder FindAll()-metoden för att hitta och skriva ut alla objekt i listan som har Gender = "Male" 
            List<Employee> maleEmployeesList = emp.FindAll(emp => emp.Gender == "male");
            foreach (Employee allMales in maleEmployeesList)
            {
                Console.WriteLine($"id:{allMales.Id}, Name: {allMales.Name}, Gender: {allMales.Gender}, Salary: {allMales.Salary}");
            }


        }

    }
}