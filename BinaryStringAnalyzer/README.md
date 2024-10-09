# Binary String Analysis Function

## Overview

This C# project contains a function that evaluates binary strings based on two specific criteria:

1. The number of `0`s and `1`s in the binary string are equal.
2. For every prefix of the string, the number of `1`s is not less than the number of `0`s.

The function is designed to help analyze binary strings for patterns and properties useful in various computational tasks.

## Function Details

### `IsGoodBinaryString(string binaryString) -> bool`

This function checks if a binary string satisfies the two conditions:
- The number of `0`s and `1`s must be equal.
- For every prefix of the binary string, the number of `1`s must not be less than the number of `0`s.

### Example

```csharp
public static void Main(string[] args)
{
    Console.WriteLine(IsGoodBinaryString("1100")); // True
    Console.WriteLine(IsGoodBinaryString("1001")); // True
    Console.WriteLine(IsGoodBinaryString("1010")); // False
    Console.WriteLine(IsGoodBinaryString("111000")); // False
}

