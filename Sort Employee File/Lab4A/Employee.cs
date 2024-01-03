/* 
 * Ahmed Nakhuda, 000878456
 * November 19 2023 
 * I, Ahmed Nakhuda, 000878456 certify that this material is my original work. No other person's work has been used without due acknowledgement. 
 * 
 * Purpose: This class represents a single employee object 
 */

namespace Lab4A 
{
    public class Employee
    {
        private string name; 
        private int number;
        private decimal rate;
        private double hours;
        private decimal gross; 

        /// <summary>
        /// Four argument constructor for the Employee
        /// </summary>
        /// <param name="name">Name of the employee</param>
        /// <param name="number">Number of the employee</param>
        /// <param name="rate">Pay rate of the employee</param>
        /// <param name="hours">Numbers of hours the employee worked</param>
        public Employee(string name, int number, decimal rate, double hours)
        {
            Name = name;
            Number = number;
            Rate = rate;
            Hours = hours;
        }

        /// <summary>
        /// Get and set name
        /// </summary>
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }


        /// <summary>
        /// Get and set number
        /// </summary>
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        

        /// <summary>
        /// Get and set rate
        /// </summary>
        public decimal Rate
        {
            get { return rate; }
            set { rate = value; }
        }


        /// <summary>
        /// Get and set hours 
        /// </summary>
        public double Hours
        {
            get { return hours; }
            set { hours = value; }
        }


        /// <summary>
        /// Get the gross pay of the employee and calculate for overtime pay 
        /// </summary>
        public decimal Gross
        {
            get 
            {
                double normalHours;
                double overtimeHours;

                // regular hours worked 
                if (Hours <= 40)
                {
                    normalHours = Hours;
                    overtimeHours = 0;
                }
                
                // overtime hours worked 
                else
                {
                    normalHours = 40;
                    overtimeHours = Hours - 40;
                }
                
                // calculate regular pay 
                double normalPay = (double)Rate * normalHours;
                double overtimePay = 0;

                // calculate overtime pay 
                if (overtimeHours > 0)
                {
                    overtimePay = (double)Rate * 1.5 * overtimeHours;
                }
                
                // calculate gross pay 
                gross = (decimal)normalPay + (decimal)overtimePay;
                return gross;
            }
        }

        /// <summary>
        /// Use ToString method to display the information in a table 
        /// </summary>
        /// <returns>A string of the employee information</returns>
        public override string ToString()
        {
            return string.Format($" {Name,-20} {Number,6} {Rate,5:C2} {Hours,6:F2} {Gross,5:C2}");
        }
    }
}
