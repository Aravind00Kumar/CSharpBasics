using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLibrary;

namespace GameUnitTest
{
    [TestClass]
    public class FlightTests
    {
        [TestMethod]
        public void FlightShouldBeInit()
        {
            Flight ft = new Flight(10, 20);
            Assert.IsTrue(ft.XPos == 10);
            Assert.IsTrue(ft.YPos == 20);
        }
        [TestMethod]
        public void MoveToLeftShouldStopAtPositionOne()
        {
            Flight ft = new Flight(1, 20);
            ft.Move(Direction.Left);
            Assert.IsTrue(ft.XPos == 1);
        }
        [TestMethod]
        public void MoveToLeftShouldMoveTheFlight()
        {
            Flight ft = new Flight(3, 20);
            ft.Move(Direction.Left);
            Assert.IsTrue(ft.XPos == 2);
        }

    }
}
