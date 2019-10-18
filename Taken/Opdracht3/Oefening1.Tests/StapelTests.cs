using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Oefening1.Tests
{
    [TestClass]
    public class StapelTests
    {
        [TestMethod]
        public void StapelConstructorMakesDifferentStapel()
        {
            // arrange
            var intStapel1 = new Stapel<int>();
            var intStapel2 = new Stapel<int>();

            // assert
            Assert.AreNotEqual(intStapel1, intStapel2);
        }
    }
}
