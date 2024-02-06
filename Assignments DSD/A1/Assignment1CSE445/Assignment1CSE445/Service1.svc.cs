using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment1CSE445
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int c2f(int c)
        {
            return (c * 9 / 5 + 32);
        }

        public int f2c(int f)
        {
            return ((f - 32) *5 / 9);
        }

        public string sort(string s)
        {
            // Split the input string into individual numbers
            string[] inputNumbers = s.Split(' ');

            // Array to store parsed double values
            double[] doubleArray = new double[inputNumbers.Length];

            for (int i = 0; i < inputNumbers.Length; i++)
            {

                // Attempt to parse the processed string into a double and add it to the array
                if (double.TryParse(inputNumbers[i], out double doubleValue))
                {
                    doubleArray[i] = doubleValue;
                }
            }

            // Sort the double array
            Array.Sort(doubleArray);

            // Convert double array to a string separated by commas
            string sortedString = string.Join(",", doubleArray);

            return sortedString;
        }
    }
}
