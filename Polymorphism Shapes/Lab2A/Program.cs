// Ahmed Nakhuda, 000878456
// October 7 2023 
// Allows the user to enter values for the shapes and then print out the information in a table 
// I, Ahmed Nakhuda, 000878456 certify that this material is my original work. No other person's work has been used without due acknowledgement.

using System;
using System.Collections.Generic;

namespace Lab2A
{
    public class Program
    {
        static void Main(string[] args)
        {
            // List of shapes
            List<Shape> shapes = new List<Shape>();


            // Cycle through options until user quits 
            while (true)
            {
                // User input 
                Console.WriteLine("A - Rectangle    E - Ellipse     I = Triangle");
                Console.WriteLine("B - Square       F - Circle      J - Tetrahedron");
                Console.WriteLine("C - Box          G - Cylinder");
                Console.WriteLine("D - Cube         H - Sphere \n");

                Console.WriteLine("0 - List all shapes and exit \n");

                // Keep count of the shapes 
                Console.WriteLine($"{Shape.GetCount()} shapes entered so far\n");

                // Get user input 
                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();


                // Get the user to choose a shape, set the data for the shape, and than add the shape to the list 

                if (input == "a" || input == "A")
                {
                    Rectangle rectangle = new Rectangle();
                    Console.WriteLine("\n"); 
                    shapes.Add(rectangle);
                    Console.Clear();

                }

                else if (input == "b" || input == "B")
                {
                    Square square = new Square();
                    Console.WriteLine("\n");
                    shapes.Add(square);
                    Console.Clear();

                }

                else if (input == "c" || input == "C")
                {
                    Box box = new Box();
                    Console.WriteLine("\n");
                    shapes.Add(box);
                    Console.Clear();
                }

                else if (input == "d" || input == "D")
                {
                    Cube cube = new Cube();
                    Console.WriteLine("\n");
                    shapes.Add(cube);
                    Console.Clear();
                }

                else if (input == "e" || input == "E")
                {
                    Ellipse ellipse = new Ellipse();
                    Console.WriteLine("\n");
                    shapes.Add(ellipse);
                    Console.Clear();

                }

                else if (input == "f" || input == "F")
                {
                    Circle circle = new Circle();
                    Console.WriteLine("\n");
                    shapes.Add(circle);
                    Console.Clear();
                }

                else if (input == "g" || input == "G")
                {
                    Cylinder cylinder = new Cylinder();
                    Console.WriteLine("\n");
                    shapes.Add(cylinder);
                    Console.Clear();
                }

                else if (input == "h" || input == "H")
                {
                    Sphere sphere = new Sphere();
                    Console.WriteLine("\n");
                    shapes.Add(sphere);
                    Console.Clear();
                }

                else if (input == "i" || input == "I")
                {
                    Triangle triangle = new Triangle();
                    Console.WriteLine("\n");
                    shapes.Add(triangle);
                    Console.Clear();
                }

                else if (input == "j" || input == "J")
                {
                    Tetrahedron tetrahedron = new Tetrahedron();
                    Console.WriteLine("\n");
                    shapes.Add(tetrahedron);
                    Console.Clear();

                }

                // Print the shape list
                else if (input == "0")
                {
                    Console.Clear();
                    Console.WriteLine($"There {(Shape.GetCount() == 1 ? "is" : "are")} {(Shape.GetCount())} object{(Shape.GetCount() == 1 ? "" : "s")}\n");
                    Console.WriteLine();
                    Console.WriteLine("Shape         Area     Volume        Details");
                    Console.WriteLine("================================================================");
                    foreach (Shape shape in shapes)
                    {
                        Console.WriteLine(shape);
                    }

                    break;
                }

                // Invalid input 
                else
                {
                    Console.Write("That is not a valid choice, please try again \n");
                    Console.WriteLine("Press enter to continue . . .");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            // Keep window open after table is shown 
            Console.ReadLine();
        }
    }
}
