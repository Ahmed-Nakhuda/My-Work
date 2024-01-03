/* 
 * Ahmed Nakhuda, 000878456
 * November 19 2023 
 * I, Ahmed Nakhuda, 000878456 certify that this material is my original work. No other person's work has been used without due acknowledgement. 
 * 
 * Purpose: Read the employees.txt file, create a method to sort the employees using lambda expressions,
 *          and allows the user to choose how they want to sort the employees and display it to the console window. 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab4A
{   
    public class Program
    {
        /// <summary>
        /// Sorts the employees based on the user's choice
        /// </summary>
        /// <param name="employees">List of employees</param>
        /// <param name="sortBy">The option the user wants to sort by</param>
        public static void Sort(List<Employee> employees, string sortBy)
        {
            // Name ascending 
            if (sortBy == "name")
            {
                employees.Sort((e1, e2) => e1.Name.CompareTo(e2.Name));
            }

            // Number ascending 
            else if (sortBy == "number")
            {
                employees.Sort((e1, e2) => e1.Number.CompareTo(e2.Number));
            }

            // Rate descending
            else if (sortBy == "rate")
            {
               employees.Sort((e1, e2) => e2.Rate.CompareTo(e1.Rate));
            }
            
            // Hours descending 
            else if (sortBy == "hours")
            {
                employees.Sort((e1, e2) => e2.Hours.CompareTo(e1.Hours));
            }
           
            // Gross pay descending 
            else if (sortBy == "gross")
            {
                employees.Sort((e1, e2) => e2.Gross.CompareTo(e1.Gross));
            }
        }


        /// <summary>
        /// Read the file and add the employees to the list 
        /// </summary>
        /// <returns>List of employees</returns>
        public static List<Employee> Read()
        {
            var employees = new List<Employee>(100);

            // Read the file to get the employee information 
            FileInfo fileProps = new FileInfo("employees.txt");

            if (fileProps.Exists)
            {
                FileStream file = new FileStream("employees.txt", FileMode.Open, FileAccess.Read);
                StreamReader data = new StreamReader(file);

                string line;

                while ((line = data.ReadLine()) != null)
                {
                    // Split each line to get the different values
                    List<string> values = line.Split(',').ToList();

                    // Extract the values 
                    string name = values[0];
                    int number = Int32.Parse(values[1]);
                    decimal rate = Decimal.Parse(values[2]);
                    double hours = Double.Parse(values[3]);

                    // Create an employee object and add the employee to the list 
                    Employee employee = new Employee(name, number, rate, hours);
                    employees.Add(employee);
                }

                data.Close();
                file.Close();

            }
          
            // Exception handling 
            else
            {
                Console.WriteLine("File does not exist");
            }

            return employees;
        }


        /// <summary>
        /// Prints the top row of the table 
        /// </summary>
        public static void Row()
        {
            Console.WriteLine("\n    Name              Number  Rate   Hours  Gross");
            Console.WriteLine("====================================================");
        }

        
        /// <summary>
        /// Method to get the user input 
        /// </summary>
        public static void UserInput()
        {
            // Read the file 
            List<Employee> employees = Read();

            // Cycle through options until user exits 
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Sort by Employee Name (ascending)");
                Console.WriteLine("2. Sort by Employee Number (ascending)");
                Console.WriteLine("3. Sort by Employee Pay Rate (descending)");
                Console.WriteLine("4. Sort by Employee Hours (descending)");
                Console.WriteLine("5. Sort by Employee Gross Pay (descending) \n");
                Console.WriteLine("6. Exit \n");
                Console.Write("Choose one option: ");

                string input = Console.ReadLine();

                // User input  
                if (input == "1")
                {
                    Row();
                    Sort(employees, "name");
                }

                else if (input == "2")
                {
                    Row();
                    Sort(employees, "number");
                }

                else if (input == "3")
                {
                    Row();
                    Sort(employees, "rate");
                }

                else if (input == "4")
                {
                    Row();
                    Sort(employees, "hours");
                }

                else if (input == "5")
                {
                    Row();
                    Sort(employees, "gross");
                }

                else if (input == "6")
                {
                    Console.WriteLine("Exiting application...");
                    break;
                }

                // Error 
                else
                {
                    Console.WriteLine("\nPlease Enter a Number 1 - 6\n");
                }

                // Print sorted employees
                foreach (Employee employee in employees)
                {
                    Console.WriteLine(employee);
                }
            }
        }

        public static void Main(string[] args)
        {
            UserInput();   
        }
    }
}

    

