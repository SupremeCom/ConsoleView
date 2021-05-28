using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Bl
{
    public class Logic
    {
        public List<Employee> Employees { set; get; } = new List<Employee>();

        
        public string GetMenu(string cmd)
        {
            Console.WriteLine(cmd);
            string result = Console.ReadLine();
            return result;
        }


        public void AddEmployee(string name, int age, int salary, string position) // добавление нового сотрудника в список
        {
            Employee employee = new Employee()
            {
                Name = name,
                Age = age,
                Salary = salary,
                Position = position
            };
            Employees.Add(employee);
        }


        public void GetWrite() // вывод списка сотрудников
        {
            foreach (Employee p in Employees)
            {
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Age);
                Console.WriteLine(p.Salary);
                Console.WriteLine(p.Position);
            }
        }

        public void DeleteEmployee(int u)  // удаление сотрудника по id списка начиная с 0
        {
            Employees.RemoveAt(u);
        }


        public int SredVozr() // вычисление среднего возраста всех сотрудников
        {
            
            var sum = 0;
            foreach (Employee p in Employees)
            { sum += p.Age; }
            int result = sum / Employees.Count();
            return result;

        }


        public int FullVozr() // вычисление среднего возраста всех сотрудников
        {

            var sum = 0;
            foreach (Employee p in Employees)
            { sum += p.Age; }
            return sum;

        }

    }
}
