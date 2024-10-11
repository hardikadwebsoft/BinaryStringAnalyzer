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
```

### Steps to Test
How It Works
Prefix Evaluation: The function processes the binary string character by character, keeping track of the count of 0s and 1s. If at any point, the number of 1s becomes less than the number of 0s, it immediately returns false.

Final Validation: If the prefix check passes, the function then checks whether the total number of 0s and 1s are equal. If both conditions are satisfied, the binary string is classified as "good" and the function returns true.

Installation and Setup
1. Clone this repository:

git clone <your-repository-url>

2. Open the project in your favorite C# IDE (Visual Studio, JetBrains Rider, etc.).

3. Build the project and run the Main method to test the functionality

Author
Name: Hardik Gohil
Organization: -
Role: Software Engineer specializing in microservices and scalable solutions
Email: hardik.gohil@live.co.uk


License
This project is licensed under the MIT License.

