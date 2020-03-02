using System;
using TriangleTracker.Models;

namespace TriangleTracker
{
  public class Program
  {
    public static void Main()
    {
      int firstLength = AskForSideLength("first");
      int secondLength = AskForSideLength("second");
      int thirdLength = AskForSideLength("third");
      string response = Triangle.CheckTriangle(firstLength, secondLength, thirdLength);
      Console.WriteLine(response);
    }

    static int AskForSideLength(string side) 
    {
      Console.WriteLine("Enter a " + side + " side length.");
      string sideLength = Console.ReadLine();
      int length = int.Parse(sideLength);
      return length;
    }
  }
}