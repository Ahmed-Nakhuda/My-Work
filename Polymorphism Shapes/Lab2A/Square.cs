// Ahmed Nakhuda, 000878456
// October 7 2023
// This class represents a Square object 
// I, Ahmed Nakhuda, 000878456 certify that this material is my original work. No other person's work has been used without due acknowledgement.

using System;

namespace Lab2A
{
    // Inherit Rectangle 
    public class Square : Rectangle
    {

        /// <summary>
        /// Square constructor 
        /// </summary>
        public Square() 
        {
            SetData();
        }

        /// <summary>
        /// Calculate area of the square 
        /// </summary>
        /// <returns>Area of the square</returns>
        public override double CalculateArea()
        {
            return Math.Pow(length, 2);
        }

        /// <summary>
        /// Calculate volume of the square 
        /// </summary>
        /// <returns>Volume of the square</returns>
        public override double CalculateVolume()
        {
            return base.CalculateVolume();
        }

        /// <summary>
        /// Get the user to set the length and parse the string into double value 
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
        /// Print square information 
        /// </summary>
        /// <returns>Square, area and length</returns>
        public override string ToString()
        {
            return ($"Square        {CalculateArea():F}                  {length:F}l ");
        }
    }
}
