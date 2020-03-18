using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class FireQualityTests
    {
        [TestMethod()]
        public void LevelCheckTest()
        {
            FireQuality fireQuality = new FireQuality();
            int level = 1;
            float height = 6f;
            //int result=fireQuality.LevelCheck(height);
            //Assert.Equals(level, result);
        }
    }
}