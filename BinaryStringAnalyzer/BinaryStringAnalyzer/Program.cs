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
        int zeroCount = 0, oneCount = 0;

        foreach (char bit in binaryString)
        {
            if (bit == '0')
                zeroCount++;
            else if (bit == '1')
                oneCount++;
            else
                throw new ArgumentException("The string contains non-binary characters.");

            // Check if the number of 1's is less than 0's in any prefix
            if (oneCount < zeroCount)
                return false;
        }

        // Check if the total number of 1's equals the total number of 0's
        return zeroCount == oneCount;
    }

    public static void Main(string[] args)
    {
        // Test cases
        Console.WriteLine(IsGoodBinaryString("1100")); // True
        Console.WriteLine(IsGoodBinaryString("1001")); // True
        Console.WriteLine(IsGoodBinaryString("1010")); // False
        Console.WriteLine(IsGoodBinaryString("111000")); // False
    }
}
