using System;

namespace TriangleTracker.Models
{
  public class Triangle
  {
    public static string CheckTriangle(int firstLength, int secondLength, int thirdLength)
    {
      string response = "";
      if ((firstLength > secondLength + thirdLength) || (secondLength > firstLength + thirdLength) || (thirdLength > firstLength + secondLength))
      {
       response = "Those sides don't form a triangle!";
      }
      else if (firstLength != secondLength && firstLength != thirdLength && secondLength != thirdLength)
      {
        response = "Those sides form a scalene triangle";
      }
      else if ((firstLength == secondLength && firstLength != thirdLength) || (secondLength == thirdLength && secondLength != firstLength) || (firstLength == thirdLength && firstLength != secondLength))
      {
        response = "Those sides form an isosceles triangle";
      }
      else if (firstLength == secondLength && firstLength == thirdLength)
      {
        response = "Those sides form an equilateral triangle";
      }
      return response;
    }
  }
}

