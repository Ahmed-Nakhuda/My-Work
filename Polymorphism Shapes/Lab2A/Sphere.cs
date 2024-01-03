// Ahmed Nakhuda, 000878456
// October 7 2023
// This class represents a Sphere object 
// I, Ahmed Nakhuda, 000878456 certify that this material is my original work. No other person's work has been used without due acknowledgement.

using System;

namespace Lab2A
{
    public class Sphere : ThreeDimensionalShape
    {
        private double radius;

        /// <summary>
        /// Sphere constructor 
        /// </summary>
        public Sphere() 
        {
            SetData(); 
        }

        /// <summary>
        /// Calculate area of the sphere
        /// </summary>
        /// <returns>Area of the sphere</returns>
        public override double CalculateArea()
        {
            return 4 * PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Calculate the volume of the sphere
        /// </summary>
        /// <returns>Volume of the sphere</returns>
        public override double CalculateVolume()
        {
            return 4.0 / 3.0 * PI * Math.Pow(radius, 3);
        }

        /// <summary>
        /// Get user to set the radius and parse the string into a double value 
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the radius: ");
            string radiusInput = Console.ReadLine();
            if (double.TryParse(radiusInput, out double parsedRadius))
            {
                radius = parsedRadius;
            }
        }

        /// <summary>
        /// Print sphere information 
        /// </summary>
        /// <returns>Sphere, area, volume, and radius>
        public override string ToString()
        {
            return ($"Sphere        {CalculateArea():F}   {CalculateVolume():F}        {radius:F}r ");
        }
    }
}
