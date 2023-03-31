using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assessment2_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2_2.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void LicenseTest_A()
        {
            Assert.AreEqual(Program.License("Eric", 2, "Adam Caroline Rebecca Frank"), 40);
        }
        [TestMethod()]
        public void LicenseTest_B()
        {
            Assert.AreEqual(Program.License("Zebediah", 1, "Bob Jim Becky Pat"), 100);
        }
        [TestMethod()]
        public void LicenseTest_C()
        {
            Assert.AreEqual(Program.License("Aaron", 3, "Jane Max Olivia Sam"), 20);
        }
    }
}