using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class FireQualityTest
    {
        FireQuality fq;

        [SetUp]
        public void SetUp()
        {
            fq = new FireQuality();
        }

        // A Test behaves as an ordinary method
        [Test]
        public void SampleTestSimplePasses()
        {
            // Use the Assert class to test conditions
            int a = 1;
            float inner = 6f;
            int result = fq.LevelCheck(inner);
            //Assert.Equals(a, result);
            Assert.IsTrue(a == result);
        }

        [Test]
        public void LevelShowTest()
        {
            //fq.LevelShow(2);
            //bool result = GameObject.Find("Fire2").activeSelf;
            //Assert.IsTrue(result == true);
            //Assert.AreEqual(true, result);
           // Assert
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator SampleTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
          
            yield return null;
        }
    }
}
