// Ahmed Nakhuda, 000878456
// October 7 2023
// This class represents a Cube object 
// I, Ahmed Nakhuda, 000878456 certify that this material is my original work. No other person's work has been used without due acknowledgement.

using System;

namespace Lab2A
{
    public class Cube : ThreeDimensionalShape
    {
        protected double length; 

        /// <summary>
        /// Cube constructor
        /// </summary>
        public Cube() 
        {
            SetData(); 
        }

        /// <summary>
        /// Calculate area of the cube
        /// </summary>
        /// <returns>Area of the cube</returns>
        public override double CalculateArea()
        {
            return 6 * Math.Pow(length, 2);
        }

        /// <summary>
        /// Calculate volume of the cube
        /// </summary>
        /// <returns>Volume of the cube</returns>
        public override double CalculateVolume()
        {
            return Math.Pow(length, 3);
        }

        /// <summary>
        /// Get user to set the length of the cube and parse the string into a double value 
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the length: ");
            string lengthInput = Console.ReadLine();
            if (double.TryParse(lengthInput, out double parsedLength))
            {
                length = parsedLength;
            }
        }

        /// <summary>
        /// Prints the cube information
        /// </summary>
        /// <returns>Cube, area, volume, and length</returns>
        public override string ToString()
        {
            return ($"Cube          {CalculateArea():F}   {CalculateVolume():F}        {length:F}l");
        }
    }
}
