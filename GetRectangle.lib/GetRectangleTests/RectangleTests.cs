using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetRectangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRectangle.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void GetAreaTest()
        {
            //1.Arange
            int high = 10;
            int width = 20;
            decimal expected = 200;

            //2.Act
            Rectangle rectangle = new Rectangle();
            decimal act =  rectangle.GetArea(high, width);
               

            //3.Assert
            Assert.AreEqual(expected, act); 
            
        }
    }
}