using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyrnaEF1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyrnaEF1.Model1 db = new Model1())
            {
                List<Show> allShows = db.Shows.ToList();

                foreach(Show s in allShows)
                {
                    Console.WriteLine("{0} {1} {2}", s.ShowID, s.Title, s.Price);
                }

                //Employee employeePersonToAdd = new Employee { FirstName = "Mark", LastName = "Thompson", EmployeeID = 369, DateOfBirth = DateTime.Parse("1990-01-15"), Email = "fartSniffer@gmail.com", Phone = "405-568-7654", Street= "369 Lil John Lane", City = "Helena", State = "MT", Zipcode = "59601" };
                //db.Employees.Add(employeePersonToAdd);
                //db.SaveChanges();

                List<Employee>  allEmployees = db.Employees.ToList();

                //foreach (Employee e in allEmployees)
                //{
                //    Console.WriteLine("{0} {1} {2}", e.EmployeeID, e.FirstName, e.LastName);
                //}

                Employee employee5 = db.Employees.Where(e => e.EmployeeID == 5).SingleOrDefault();
                if (employee5 != null)
                {
                    Console.WriteLine("ID: {0} FirstName: {1} LastName: {2}", employee5.EmployeeID, employee5.FirstName, employee5.LastName);
                }

                Employee employeeToDelete = db.Employees.ToArray().Last();
                if (employeeToDelete != null)
                {
                    db.Employees.Remove(employeeToDelete);
                    db.SaveChanges();
                }

                Console.ReadLine();
            }
        }
    }
}
