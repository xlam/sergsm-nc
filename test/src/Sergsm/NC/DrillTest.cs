using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Sergsm.NC.Test
{
    [TestFixture]
    public class DrillTest
    {
        private Drill drill = new Drill();

        [Test]
        public void TestTrue()
        {
            Assert.IsTrue(drill.isDrill());
        }
        
        [Test]
        public void TestFalse()
        {
            Assert.IsFalse(false);
        }
    }
}
