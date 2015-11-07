using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;
using System.Data;

namespace Ushtrime_4
{
     [TestFixture]
    class UnitTests
    {
        [TestCase]
        public void LexoTest()
        {
            Skedar sk = new Skedar();
            DataTable result = sk.Lexo("C:\\Users\\GRKN\\Documents\\Ushtrime_4\\Ushtrime_4\\Emails.csv");
            Assert.AreEqual(result, result);
        }

        [TestCase]
        public void ShtoNeTabeleTest()
        {
            Ruaj r = new Ruaj();
            int result = r.ShtoNeTabele("gridikono@gmail.com", "subjekt test", "trup test");
            Assert.AreEqual(1, result);
        }
    }
}
