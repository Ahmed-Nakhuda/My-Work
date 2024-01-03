// Ahmed Nakhuda, 000878456
// October 7 2023
// This class represents a Tetrahedron object 
// I, Ahmed Nakhuda, 000878456 certify that this material is my original work. No other person's work has been used without due acknowledgement.

using System;

namespace Lab2A
{
    public class Tetrahedron : ThreeDimensionalShape
    {
        protected double length;

        /// <summary>
        /// Tetrahedron constructor 
        /// </summary>
        public Tetrahedron() 
        {
            SetData(); 
        }

        /// <summary>
        /// Calculate area of the tetrahedron 
        /// </summary>
        /// <returns>Area of the tetrahedron</returns>
        public override double CalculateArea()
        {
            return Math.Sqrt(3) * Math.Pow(length, 2);
        }

        /// <summary>
        /// Calculate volume of the tetrahedron
        /// </summary>
        /// <returns>Volume of the tetrahedron</returns>
        public override double CalculateVolume()
        {
            return Math.Pow(length, 3) / (6 * Math.Sqrt(2));
        }

        /// <summary>
        /// Get user to set the length and parse the string into a double value 
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
        /// Print tetrahedron information 
        /// </summary>
        /// <returns>Tetrahedron, area, volume, and length</returns>
        public override string ToString()
        {
            return ($"Tetrahedron   {CalculateArea():F}    {CalculateVolume():F}         {length:F}l ");
        }
    }
}
