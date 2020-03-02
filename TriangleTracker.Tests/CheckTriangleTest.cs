using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;
using TriangleTracker.Models;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void CheckTriangle_DeterminesNotTriangle_String()
    {
      string response = "Those sides don't form a triangle!";
      Assert.AreEqual(response, Triangle.CheckTriangle(3, 9, 22));
    }
    [TestMethod]
    public void CheckTriangle_DeterminesScaleneTriangle_String()
    {
      string response = "Those sides form a scalene triangle";
      Assert.AreEqual(response, Triangle.CheckTriangle(4, 5, 7));
    }
    [TestMethod]
    public void CheckTriangle_DeterminesIsoscelesTriangle_String()
    {
      string response = "Those sides form an isosceles triangle";
      Assert.AreEqual(response, Triangle.CheckTriangle(5, 5, 7));
    }
    [TestMethod]
    public void CheckTriangle_DeterminesEquilateralTriangle_String()
    {
      string response = "Those sides form an equilateral triangle";
      Assert.AreEqual(response, Triangle.CheckTriangle(5, 5, 5));
    }
  }
}