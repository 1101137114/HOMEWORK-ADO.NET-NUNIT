using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebApplication1.Tests
{
    [TestFixture]
    public class Class3
    {
        [Test]
        public void Cal()
        {
            ClassLibrary.Cal cal = new ClassLibrary.Cal();
            int inputUSD = 10;
            int expect = 300;

            Assert.AreEqual(expect, cal.GetResult(inputUSD, ClassLibrary.Cal.CurrencySelect.TWD));
        }
    }
}
