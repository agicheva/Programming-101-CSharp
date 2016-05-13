using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HackCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["HackCompany"].ConnectionString;
            DatabaseCommunicator dbCommunicator = new DatabaseCommunicator(connectionString);

            List<Employee> listOfEmployees = dbCommunicator.GetEmployees();

            foreach (var item in listOfEmployees)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.EmployeeId);
            }

            Console.WriteLine("--------");

            dbCommunicator.UpdateOrInsert(new Category("MVS", "Movies"));

            List<Category> listOfCategories = dbCommunicator.GetCategories();

            foreach (var item in listOfCategories)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }

            Console.WriteLine("---------");

            dbCommunicator.DeleteCategory("MVS");

            List<Category> listOfCategoriesCheckIfDelete = dbCommunicator.GetCategories();

            foreach (var item in listOfCategoriesCheckIfDelete)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
        }
    }
}
