using System;

namespace TriangleTracker.Models
{
  public class Triangle
  {
    public static void CheckedTriangle(int firstLength, int secondLength, int thirdLength)
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
}

