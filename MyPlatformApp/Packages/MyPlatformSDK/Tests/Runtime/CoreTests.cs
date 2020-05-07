using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


namespace MyPlatform.Tests {
    public class CoreTests {
        // A Test behaves as an ordinary method
        [Test]
        public void InitializationTest() {
            Assert.True(Core.Initialize());
        }
    }
}
