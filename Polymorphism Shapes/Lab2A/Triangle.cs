// Ahmed Nakhuda, 000878456
// October 7 2023 
// This class represents a Triangle object 
// I, Ahmed Nakhuda, 000878456 certify that this material is my original work. No other person's work has been used without due acknowledgement.

using System;

namespace Lab2A
{
    internal class Triangle : TwoDimensionalShape
    {
        protected double Base;
        protected double height;

        /// <summary>
        /// Triangle constructor 
        /// </summary>
        public Triangle() 
        {
            SetData(); 
        }

        /// <summary>
        /// Calculate area of the triangle 
        /// </summary>
        /// <returns>Area of the triangle</returns>
        public override double CalculateArea()
        {
            return Base * height / 2;
        }

        /// <summary>
        /// Calculate volume of the triangle 
        /// </summary>
        /// <returns>Volume of the triangle</returns>
        public override double CalculateVolume()
        {
            return base.CalculateVolume();
        }

        /// <summary>
        /// Get user to set the base and the height and parse strings into double value  
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the base: ");
            string baseInput = Console.ReadLine();
            if (double.TryParse(baseInput, out double parsedBase))
            {
                Base = parsedBase;
            }


            Console.Write("Enter the height: ");
            string heightInput = Console.ReadLine();
            if (double.TryParse(heightInput, out double parsedHeight))
            {
                height = parsedHeight;
            }
        }

        /// <summary>
        /// Print Triangle information 
        /// </summary>
        /// <returns>Triangle area, base, and height</returns>
        public override string ToString()
        {
            return ($"Triangle      {CalculateArea():F}                  {Base:F}b x {height:F}h ");
        }
    }
}

