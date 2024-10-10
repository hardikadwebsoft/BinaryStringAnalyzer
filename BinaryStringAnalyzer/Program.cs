using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryStringAnalyzer;
public class BinaryStringAnalyzer
{
    public static bool IsGoodBinaryString(string binaryString)
    {
        int zeroCount = binaryString.Count(bit => bit == '0');
        int oneCount = binaryString.Count(bit => bit == '1');

        // Check if the total counts are equal
        if (zeroCount != oneCount)
            return false;

        // Check if for every prefix, the number of 1's is not less than the number of 0's
        int runningZeroCount = 0, runningOneCount = 0;

        foreach (char bit in binaryString)
        {
            if (bit == '0')
                runningZeroCount++;
            else if (bit == '1')
                runningOneCount++;
            else
                throw new ArgumentException("The string contains non-binary characters.");

            if (runningOneCount < runningZeroCount)
                return false;
        }

        return true; // If all checks are passed
    }

    public static void Main(string[] args)
    {
        // Test cases
        Console.WriteLine(IsGoodBinaryString("1100"));      // True
        Console.WriteLine(IsGoodBinaryString("1001"));      // False
        Console.WriteLine(IsGoodBinaryString("1010"));      // False
        Console.WriteLine(IsGoodBinaryString("111000"));    // False
        Console.WriteLine(IsGoodBinaryString(""));          // True (an empty string is considered good)
        Console.WriteLine(IsGoodBinaryString("00001111"));  // False
        Console.WriteLine(IsGoodBinaryString("1110000"));   // False
    }
}
