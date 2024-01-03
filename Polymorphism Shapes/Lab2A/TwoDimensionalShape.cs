// Ahmed Nakhuda, 000878456
// October 7 2023 
// This class represents a Two Dimensional Shape, purpose is so other classes can inherit from it
// I, Ahmed Nakhuda, 000878456 certify that this material is my original work. No other person's work has been used without due acknowledgement.

using System;

namespace Lab2A
{
    public class TwoDimensionalShape : Shape
    {
        /// <summary>
        /// Calculate area of the two dimensional shape
        /// </summary>
        /// <returns>Area of the two dimensional shape</returns>
        /// <exception cref="NotImplementedException">Not implemented</exception>
        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculate volume of the two dimensional shape
        /// </summary>
        /// <returns>Volume of the two dimensional shape</returns>
        public override double CalculateVolume()
        {
            return 0; // all 2D shapes have 0 volume 
        }

        /// <summary>
        /// Get user to set the data of the two dimensional shape 
        /// </summary>
        /// <exception cref="NotImplementedException">Not implemented</exception>
        public override void SetData()
        {
            throw new NotImplementedException();
        }
    }
}
