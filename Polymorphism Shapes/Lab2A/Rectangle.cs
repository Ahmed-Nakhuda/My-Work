// Ahmed Nakhuda, 000878456
// October 7 2023 
// This class represents a Rectangle object 
// I, Ahmed Nakhuda, 000878456 certify that this material is my original work. No other person's work has been used without due acknowledgement.

using System;

namespace Lab2A
{
    public class Rectangle : TwoDimensionalShape
    {
        protected double length; 
        protected double width;

        /// <summary>
        /// Rectangle constructor 
        /// </summary>
        public Rectangle() 
        {
            SetData(); 
        }

        /// <summary>
        /// Calculate area of the rectangle
        /// </summary>
        /// <returns>Area of the rectangle</returns>
        public override double CalculateArea()
        {
            return length * width;
        }

        /// <summary>
        /// Calculate volume of the rectangle
        /// </summary>
        /// <returns>Volume of the rectangle</returns>
        public override double CalculateVolume()
        {
            return base.CalculateVolume();
        }

        /// <summary>
        /// Get user to set the length and the width and parse the strings into a double value   
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the length: ");
            string lengthInput = Console.ReadLine();
            if (double.TryParse(lengthInput, out double parsedLength))
            {
                length = parsedLength;
            }

            Console.Write("Enter the width: ");
            string widthInput = Console.ReadLine();
            if (double.TryParse(widthInput, out double parsedWidth))
            {
                width = parsedWidth;
            }
        }

        /// <summary>
        /// Print rectangle information 
        /// </summary>
        /// <returns>Rectangle, area, length, and width</returns>
        public override string ToString()
        {
            return ($"Rectangle     {CalculateArea():F}                  {length:F}l x {width:F}w");
        }
    }
}

