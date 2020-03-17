using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class Role_FireTest
    {
        Role_Fire rf;
        [SetUp]
        public void SetUp()
        {
            rf = new Role_Fire();
            Role_Fire.blood = 0.8f;
            //rf.bloodBar =GameObject.Find("Slider");
        }
        // A Test behaves as an ordinary method
        [Test]
        public void Role_FireTestSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        [Test]
        public void decBloodTest()
        {
            float x = Role_Fire.blood;
            float ex = x - 0.01f;
            float result = rf.decBlood(0.01f);
            Assert.IsTrue(Mathf.Abs(ex-result)<0.01);
        }

        [Test]
        public void colorCheck()
        {
            GameObject fore = GameObject.FindGameObjectWithTag("Foreground");
            Color co = fore.GetComponent<UISprite>().color;
            bool yes =( co == Color.green || co == Color.red || co == Color.yellow);
            Assert.IsTrue(yes);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator Role_FireTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
