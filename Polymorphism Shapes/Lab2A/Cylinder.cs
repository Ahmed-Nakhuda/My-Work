// Ahmed Nakhuda, 000878456
// October 7 2023 
// This class represents a Cylinder object 
// I, Ahmed Nakhuda, 000878456 certify that this material is my original work. No other person's work has been used without due acknowledgement.

using System;

namespace Lab2A
{
    public class Cylinder : ThreeDimensionalShape
    {
        protected double height;
        protected double radius;

        /// <summary>
        /// Cylinder constructor
        /// </summary>
        public Cylinder() 
        {
            SetData();
        }

        /// <summary>
        /// Calculate area of the cylinder 
        /// </summary>
        /// <returns>Area of the the cylinder</returns>
        public override double CalculateArea()
        {
            return 2.0 * PI * radius * height + 2.0 * PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Calculate volume of the cylinder
        /// </summary>
        /// <returns>Volume of the cylinder</returns>
        public override double CalculateVolume()
        {
            return PI * Math.Pow(radius, 2) * height;
        }

        /// <summary>
        /// Get user to set the radius and the height and parse the strings into a double value  
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the radius: ");
            string radiusInput = Console.ReadLine();
            if (double.TryParse(radiusInput, out double parsedRadius))
            {
                radius = parsedRadius;
            }

            Console.Write("Enter the height: ");
            string heightInput = Console.ReadLine();
            if (double.TryParse(heightInput, out double parsedHeight))
            {
                height = parsedHeight;
            }
        }

        /// <summary>
        /// Print cylinder information 
        /// </summary>
        /// <returns>Cylinder, area, volume, radius, and height</returns>
        public override string ToString()
        {
            return ($"Cylinder      {CalculateArea():F}   {CalculateVolume():F}        {radius:F}r * {height:F}h ");
        }
    }
}
