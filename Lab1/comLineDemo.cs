/// Project Prolog
/// Name: Daniel Wood
/// CS3260 Section 001
/// Project: Lab_01
/// Date: 1/10/2020 7:15:30 PM
/// <summary>
/// This is a program that takes text input and returns a message, using the text inputs
/// </summary>
///  
/// I declare that the following code was written by me or provided
/// by the instructor for this project. I understand that copying source
/// code from any other source constitutes plagiarism, and that I will receive
/// a zero on this project if I am found in violation of this policy.
/// ---------------------------------------------------------------------------

using System;

namespace CommandLineDemo
{
  class comLineDemo
  {
    /// <summary>
    /// main entry method to grab text inputs
    /// </summary>
    /// <param name="args">input string arguments</param>
    static void Main(string[] args)
    {
      // check if there are less than two arguments, and if there are, throw an error
      if(args.Length < 2) {
        throw new ArgumentException("Arguments cannot be less than two", "args.Length");
      }
      // marks the first argument as indicating name
      Console.WriteLine("Welcome to my home, your name is:");
      // print first argument
      Console.WriteLine(args[0]);
      // marks the rest of the arguments as being the body of the message
      Console.WriteLine("What you have to say is:");
      int argsLeft = args.Length - 1; // int: how many arguments left to go through
      int position = 1; // int: how far into the args array
      // while there are still arguments to go through, print them with a space afterwards
      while (argsLeft > 0) {
       Console.Write(args[position] + " ");
       position++; // push the args position forward
       argsLeft--; // reduce the number of args left to go through
      }
      // push off of the line that the text inputs were writing to
      Console.WriteLine();
      // hold the console window open with a ReadLine
      Console.ReadLine();
    }
  }
}