/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_02
/// Date: 1/17/2020 9:27:15 PM
/// <summary>
/// This is a program that displays the max and min values of different data types
/// </summary>
///  
/// I declare that the following code was written by me or provided
/// by the instructor for this project. I understand that copying source
/// code from any other source constitutes plagiarism, and that I will receive
/// a zero on this project if I am found in violation of this policy.
/// ---------------------------------------------------------------------------

using System;

public class Program
{
    /// <summary>
    /// Main function that displays on each line a data type and its min and max values.
    /// </summary>
    public static void Main()
    {
        Console.WriteLine($"sbyte values {sbyte.MaxValue} and {sbyte.MinValue}");
        Console.WriteLine($"short Max: {short.MaxValue}  MinValue: {short.MinValue}");
        Console.WriteLine($"ushort Max: {ushort.MaxValue}  MinValue: {ushort.MinValue}");
        Console.WriteLine($"int Max: {int.MaxValue}  MinValue: {int.MinValue}");
        Console.WriteLine($"long Max: {long.MaxValue}  MinValue: {long.MinValue}");
        Console.WriteLine($"ulong Max: {ulong.MaxValue} MinValue: {ulong.MinValue}");
        Console.WriteLine($"float Max: {float.MaxValue}  MinValue: {float.MinValue}");
        Console.WriteLine($"double Max: {double.MaxValue}  MinValue: {double.MinValue}");
        Console.WriteLine($"decimal Max: {decimal.MaxValue}  MinValue: {decimal.MinValue}");
        Console.WriteLine($"char Max: {Convert.ToInt32(char.MaxValue)}  MinValue: {Convert.ToInt32(char.MinValue)}");
        Console.ReadLine();
    }
} 