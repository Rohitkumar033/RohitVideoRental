using Microsoft.VisualStudio.TestTools.UnitTesting;
using RohitVideoRental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohitVideoRental.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void reloadTest()
        {
            Form1 frm = new Form1();
            frm.reload();
            Assert.Fail();
        }
        public void alltest()
        {
            Form1 frm = new Form1();
            Assert.Fail();

        }

        [TestMethod()]
        public void SrchQueryTest()
        {
            Assert.Fail();
        }
    }
}