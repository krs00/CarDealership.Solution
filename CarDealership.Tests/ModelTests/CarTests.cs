using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDealership.Models;

namespace CarDealership.Test
{ 
  [TestClass]
  public class CarTest
  { 

    [TestMethod] 
    public void CarConstructor_CreateInstanceOfCar_Car() 
    { 
    Car newCar = new Car("Honda", "Civic", 2000, "Tan");  
    Assert.AreEqual(typeof(Car), newCar.GetType()); 
    }
    
}
}