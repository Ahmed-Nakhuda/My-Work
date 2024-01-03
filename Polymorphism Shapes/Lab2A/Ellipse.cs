// Ahmed Nakhuda, 000878456
// October 7 2023
// This class represents a Ellipse object 
// I, Ahmed Nakhuda, 000878456 certify that this material is my original work. No other person's work has been used without due acknowledgement.

using System;

namespace Lab2A
{
    public class Ellipse : TwoDimensionalShape
    {
        protected double semiMajorAxis;
        protected double semiMinorAxis;

        /// <summary>
        /// Ellipse constructor 
        /// </summary>
        public Ellipse() 
        {
            SetData(); 
        }

        /// <summary>
        /// Calculate area of the ellipse
        /// </summary>
        /// <returns>Area of the ellipse</returns>
        public override double CalculateArea()
        {
            return PI * semiMajorAxis * semiMinorAxis;
        }

        /// <summary>
        /// Calculate volume of the ellipse
        /// </summary>
        /// <returns>Volume of the ellipse</returns>
        public override double CalculateVolume()
        {
            return base.CalculateVolume();
        }

        /// <summary>
        /// Get user to set the semi and major axis and parse the strings into a double value 
        /// </summary>
        public override void SetData()
        { 
                Console.Write("Enter the semi major axis: ");
                string semiMajorAxisInput = Console.ReadLine();
                if (double.TryParse(semiMajorAxisInput, out double parsedSemiMajorAxis))
                {
                    semiMajorAxis = parsedSemiMajorAxis;
                }
                
               
                Console.Write("Enter the semi minor axis: ");
                string semiMinorAxisInput = Console.ReadLine();
                if (double.TryParse(semiMinorAxisInput, out double parsedSemiMinorAxis))
                {
                    semiMinorAxis = parsedSemiMinorAxis;
                }

            }
        
        /// <summary>
        /// Prints the ellipse information 
        /// </summary>
        /// <returns>Ellipse, area, semi major axis, and semi minor axis</returns>
        public override string ToString()
        {
            return ($"Ellipse       {CalculateArea():F}                  {semiMajorAxis:F}s.major x {semiMinorAxis:F}s.minor ");
        }
    }
}
