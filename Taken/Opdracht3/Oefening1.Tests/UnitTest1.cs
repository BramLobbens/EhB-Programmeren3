using System;
using System.Diagnostics;
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

        [TestMethod]
        public void StapelLeegmakenTest()
        {
            // arrange
            var stringStapel = new Stapel<string>();
            stringStapel.Toevoegen("test");

            // act
            stringStapel.Leegmaken();

            // assert
            Assert.IsTrue(stringStapel.Count == 0);
        }

        [TestMethod]
        public void StapelIsAanwezigTest()
        {
            // arrange
            var stringStapel = new Stapel<string>();
            stringStapel.Toevoegen("test");
            string testString = "test";

            // act
            bool result = stringStapel.IsAanwezig(testString);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void StapelCopyCreatesIndependentCopy()
        {
            // arrange
            var origineel = new Stapel<int>();
            origineel.Toevoegen(1);
            origineel.Toevoegen(2);
            origineel.Toevoegen(3);

            // act
            var copy = origineel.Copy();
            copy.Verwijderen();

            // assert
            Assert.AreNotEqual(origineel.Count, copy.Count);
        }
    }
}
