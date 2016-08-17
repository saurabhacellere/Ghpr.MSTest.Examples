﻿using System;
using System.ComponentModel;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ghpr.MSTest.Examples.Cat1
{
    [TestClass]
    public class TestClass1
    {
        [TestMethod]
        public void SimpleFailedTest()
        {
            Console.WriteLine("This is test output, we are logging some stuff!");
            Assert.AreEqual(1, 2);
        }
        
        [TestMethod]
        public void RandomDurationPassedTest()
        {
            var r = new Random();
            Thread.Sleep(r.Next(700));
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void LongLogTest()
        {
            Console.WriteLine("Testing log writing 1");
            Thread.Sleep(100);
            Console.WriteLine("Testing log writing 2");
            Thread.Sleep(200);
            Console.WriteLine("Testing log writing 3");
            Thread.Sleep(100);
            Console.WriteLine("Testing log writing 4");
            Thread.Sleep(200);
            Console.WriteLine("Testing log writing 5");
            for (var i = 6; i < 55; i++)
            {
                Console.WriteLine("Testing log writing " + i);
            }
            Assert.AreEqual(1, 2);
        }

        [TestMethod]
        public void SuccessTest()
        {
            Thread.Sleep(200);
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void ErrorExpected()
        {
            Thread.Sleep(300);
            throw new Exception("Some error occured!");
        }

        [TestMethod]
        public void TestMethodInconclusive()
        {
            Thread.Sleep(300);
            Assert.Inconclusive("Inconc. test :)");
        }

        [Ignore]
        [TestMethod]
        public void TestMethodIgnored()
        {
            Thread.Sleep(300);
        }

        [Ignore]
        [TestMethod]
        public void TestMethodIgnored2()
        {
            Thread.Sleep(300);
        }
    }
}