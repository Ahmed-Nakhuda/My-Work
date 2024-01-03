// Ahmed Nakhuda, 000878456
// October 7 2023
// This class represents a Box object 
// I, Ahmed Nakhuda, 000878456 certify that this material is my original work. No other person's work has been used without due acknowledgement.

using System;

namespace Lab2A
{
    public class Box : ThreeDimensionalShape
    {
        protected double length;
        protected double height;
        protected double width;

        /// <summary>
        /// Box constructor
        /// </summary>
        public Box() 
        {
            SetData(); 
        }

        /// <summary>
        /// Calculate area of the box
        /// </summary>
        /// <returns>Area of the box</returns>
        public override double CalculateArea()
        {
            return 2 * (length * width) + 2 * (length * height) + 2 * (height * width);
        }

        /// <summary>
        /// Calculate volume of the box
        /// </summary>
        /// <returns>Volume of the box</returns>
        public override double CalculateVolume()
        {
            return length * width * height;
        }

        /// <summary>
        /// Get user to set the length, width and height and parse the strings into a double value  
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

            Console.Write("Enter the height: ");
            string heightInput = Console.ReadLine();
            if (double.TryParse(heightInput, out double parsedHeight))

                height = parsedHeight;
        }


        /// <summary>
        /// Print box information 
        /// </summary>
        /// <returns>Box, area, volume, length, width, and height</returns>
        public override string ToString()
        {
            return ($"Box           {CalculateArea():F}   {CalculateVolume():F}        {length:F}l x {width:F}w x {height:F}h");
        }
    }
}
