using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Part1
{
    public class Prods
    {
        public static void Main(string[] args)
        {
            // Print the result of calling Prod(1, 4)
            Console.WriteLine(Prod(1, 4));
        }
        /*
        // Prod method: Computes the product of integers from m to n
        public static int Prod(int m, int n)
        {
            // Base case: If m equals n, return n
            if (m == n)
            {
                return n;
            }
            else
            {
                // Recursive case:
                // 1. Compute Prod(m, n-1) recursively
                int recurse = Prod(m, n - 1);
                // 2. Multiply n by the result of Prod(m, n-1)
                int result = n * recurse;
                // 3. Return the computed result
                return result;
            }
        }
        */

        /* 1. Draw a stack diagram showing the state of the program just before the last instance
            of Prod completes.What is the output of this program? */

        /* 
         * Prod(1, 4)
        | 
        |  -> Prod(1, 3)
        |      |
        |      |  -> Prod(1, 2)
        |      |      |
        |      |      |  -> Prod(1, 1) => returns 1
        |      |      |
        |      |      |  recurse = 1
        |      |      |  result = 2 * 1 = 2 => returns 2
        |      |      |
        |      |      recurse = 2
        |      |      result = 3 * 2 = 6 => returns 6
        |      |
        |      recurse = 6
        |      result = 4 * 6 = 24 => returns 24
        |
        recurse = 24 (final result)
         */

        /* Stack Diagram
         * 1. Initial Call: 'Prod(1, 4)'
         *  - Parameters: 'm = 1', 'n = 4'
         *  - Execution proceeds to 'Prod (1, 3)
         *  
         * 2. Call: 'Prod (1, 3)'
         *  - Parameters: 'm = 1', 'n = 3'
         *  - Execution proceeds to 'Prod (1, 2)
         *  
         * 3. Call: 'Prod (1, 2)'
         *  - Parameters: 'm = 1', 'n = 2'
         *  - Execution proceeds to 'Prod (1, 1)
         *  
         * 4. Call: 'Prod (1, 2)'
         *  - Parameters: 'm = 1', 'n = 1'
         *  - Base case reached, return '1'
         *  
         * Stacking after returning from 'Prod (1, 1)':
         * Prod(1, 1) -> 1
         * 
         * Backtracking Execution:
         * After 'Prod(1, 1)' returns '1', the recursion backtracks:
         *  - 'Prod(1, 2)' calculates '2 * 1 = 2' and return '2'
         *  
         * Stacking after returning from 'Prod (1, 2)':
         * Prod(1, 1) -> 1
         * Prod(1, 2) -> 2
         *
         *  - 'Prod(1, 3)' calculates '3 * 2 = 6' and return '6'
         *  
         * Stacking after returning from 'Prod (1, 3)':
         * Prod(1, 1) -> 1
         * Prod(1, 2) -> 2
         * Prod(1, 3) -> 6
         * 
         * - 'Prod(1, 4)' calculates '4 * 6 = 24' and return '24'
         *
         * Stacking after returning from 'Prod (1, 4)':
         * Prod(1, 1) -> 1
         * Prod(1, 2) -> 2
         * Prod(1, 3) -> 6
         * Prod(1, 4) -> 24 (this is the final result).
         * 
         * The output of this program is 24
         */

        // 2. Explain in a few words what Prod does.

        /*
         * The function 'Prod' calculates the product of the integers from
         * a starting number 'm' to an ending number 'n' using recursion.
         * It computes this product by recursuvely multiplying the current
         * number 'n' with the result of 'Prod(m, n-1)' until it reaches
         * the bae case where 'm' equals 'n', returning 'n' as the base case result.
         */

        // 3. Rewrite Prod without using the temporary variables recurse and result.

        public static int Prod(int m, int n)
        {
            if (m == n)
            {
                return n;
            }
            else
            {
                //int recurse = Prod(m, n - 1);
                //int result = n * recurse;
                return n * Prod(m, n - 1);
            }
        }
    }
}
