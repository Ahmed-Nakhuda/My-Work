// Ahmed Nakhuda, 000878456
// October 7 2023
// This class represents a Circle object 
// I, Ahmed Nakhuda, 000878456 certify that this material is my original work. No other person's work has been used without due acknowledgement.

using System;

namespace Lab2A
{
    // Inherit Ellipse 
    public class Circle : Ellipse
    {
        protected double radius;

        /// <summary>
        /// Circle constructor 
        /// </summary>
        public Circle() 
        {
            SetData();
        }

        /// <summary>
        /// Calculate area of the circle 
        /// </summary>
        /// <returns>Area of the circle</returns>
        public override double CalculateArea()
        {
            return PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Calculate volume of the circle
        /// </summary>
        /// <returns>Volume of the circle</returns>
        public override double CalculateVolume()
        {
            return base.CalculateVolume();
        }

        /// <summary>
        /// Get the user to set the radius and parse the string into double value   
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
        /// Print circle information 
        /// </summary>
        /// <returns>Circle, area, and radius </returns>
        public override string ToString()
        {
            return ($"Circle        {CalculateArea():F}                  {radius:F}r ");
        }
    }
}
