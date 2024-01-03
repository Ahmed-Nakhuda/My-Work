// Ahmed Nakhuda, 000878456
// October 7 2023 
// This class represents a Three Dimensional Shape, purpose is so other classes can inherit from it
// I, Ahmed Nakhuda, 000878456 certify that this material is my original work. No other person's work has been used without due acknowledgement.

using System;

namespace Lab2A
{
    public class ThreeDimensionalShape : Shape
    {
        /// <summary>
        /// Calculate the area of the three dimensional shape 
        /// </summary>
        /// <returns>Area of the three dimensional shape</returns>
        /// <exception cref="NotImplementedException">Not implemented</exception>
        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculate the volume of the three dimensional shape
        /// </summary>
        /// <returns>Volume of the three dimensional shape</returns>
        /// <exception cref="NotImplementedException">Not implemented</exception>
        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Set the data of the three dimensional shape 
        /// </summary>
        /// <exception cref="NotImplementedException">Not implemented</exception>
        public override void SetData()
        {
            throw new NotImplementedException();
        }
    }
}
