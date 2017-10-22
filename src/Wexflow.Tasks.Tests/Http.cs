﻿using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wexflow.Tasks.Tests
{
    [TestClass]
    public class Http
    {
        private static readonly string Dest = @"C:\WexflowTesting\Http\logo.png";

        [TestInitialize]
        public void TestInitialize()
        {
            if(File.Exists(Dest)) File.Delete(Dest);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            File.Delete(Dest);
        }

        [TestMethod]
        public void Run()
        {
            Assert.AreEqual(false, File.Exists(Dest));
            Helper.StartWorkflow(25);
            Assert.AreEqual(true, File.Exists(Dest));
        }
    }
}
