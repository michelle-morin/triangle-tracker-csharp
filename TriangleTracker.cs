using System;

public static class Triangle
{
  public static void Main()
  {
    int firstLength = AskForSideLength("first");
    int secondLength = AskForSideLength("second");
    int thirdLength = AskForSideLength("third");
    CheckedTriangle(firstLength, secondLength, thirdLength);
  }
  static int AskForSideLength(string side) 
  {
    Console.WriteLine("Enter a " + side + " side length.");
    string sideLength = Console.ReadLine();
    int length = int.Parse(sideLength);
    return length;
  }
  static void CheckedTriangle(int firstLength, int secondLength, int thirdLength)
  {
    if ((firstLength > secondLength + thirdLength) || (secondLength > firstLength + thirdLength) || (thirdLength > firstLength + secondLength))
    {
      Console.WriteLine("Those sides don't form a triangle!");
    }
    else if (firstLength != secondLength && firstLength != thirdLength && secondLength != thirdLength)
    {
      Console.WriteLine("Those sides form a scalene triangle");
    }
    else if ((firstLength == secondLength && firstLength != thirdLength) || (secondLength == thirdLength && secondLength != firstLength) || (firstLength == thirdLength && firstLength != secondLength))
    {
      Console.WriteLine("Those sides form an isosceles triangle");
    }
    else if (firstLength == secondLength && firstLength == thirdLength)
    {
      Console.WriteLine("Those sides form an equilateral triangle");
    }
  }
}

