using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomoAssessment
{
    public static class Question2
    {
        /// <summary>
        /// Calculate the area of a triangle based on the lengths of the three sides.
        /// </summary>
        /// <param name="sideLengths">The three lengths of the triangle's three sides.</param>
        /// <returns>The area of the specified triangle</returns>
        /// <remarks>Using Heron's formula from 
        /// <a href="https://www.omnicalculator.com/math/triangle-area#triangle-area-formula"></a>
        /// <para/>Assuming output is supposed to be a double/decimal value.</remarks>
        public static double calculateTriangleArea(int[] sideLengths)
        {
            int a, b, c;
            a = sideLengths[0];
            b = sideLengths[1];
            c = sideLengths[2];
            // if any of the sides are 0 or negative
            if (a < 1 || b < 1 || c < 1)
            {
                throw new InvalidTriangleException();
            }

            // if the side lengths are not a valid triangle
            /* see triangle inequality theorem: 
             * https://www.wikihow.com/Determine-if-Three-Side-Lengths-Are-a-Triangle */
            for (int i = 0; i < 3; i++)
            {
                int sideToCompare = sideLengths[i];
                int[] tmpSides = sideLengths.Where(x => x != sideToCompare).ToArray();

                if (tmpSides[0] + tmpSides[1] <= sideToCompare)
                {
                    throw new InvalidTriangleException();
                }
            }
            
            double area = 0.25 * Math.Sqrt((a + b + c) * (-a + b + c) * (a - b + c) * (a + b - c));
            return area;
        }

        public class InvalidTriangleException : Exception { }
    }
}
