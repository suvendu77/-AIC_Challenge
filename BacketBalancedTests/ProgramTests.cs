using Microsoft.VisualStudio.TestTools.UnitTesting;
using BacketBalanced;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacketBalanced.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void IsBalancedTest()
        {
            var result = Program.IsBalanced("{");
            Assert.IsFalse(result);

            result = Program.IsBalanced("[{(1+2)*(3*4)}]");
            Assert.IsTrue(result);

            result = Program.IsBalanced("[{(1+2}*{3*4)}]");
            Assert.IsFalse(result);

            result = Program.IsBalanced("[{(1+2}*)3*4}]");
            Assert.IsFalse(result);
        }
    }
}