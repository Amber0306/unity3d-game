using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class LevelCheckTests
    {
        [TestMethod()]
        public void LevelCheckTest()
        {
            FireQuality fq=new FireQuality();
            float inner= 4.5f;
            int outer = 1;
            int result=fq.LevelCheck(inner);
            //FireQuality.LevelCheck(inner);
            Assert.Equals(outer, result);
        }
    }
}