using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week2Demos;

namespace Week2DemoTests
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void Vehicle_Can_Be_Constructed()
        {
            Vehicle v = new Bus();

            Assert.IsInstanceOfType(v, typeof(Vehicle));
        }

        [TestMethod]
        public void Vehicle_Can_Be_Started()
        {
            Vehicle v = new Bus();

            v.Start(true);
        }
    }
}
