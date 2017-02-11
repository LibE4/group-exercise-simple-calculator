using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StorageTests
    {
        [TestMethod]
        public void TestStorageClassExist()
        {
            Storage storage = new Storage();
            Assert.IsNotNull(storage);
        }

        [TestMethod]
        public void TestLast()
        {
            Storage storage = new Storage();
            storage.last = 10;
            var expect = 10;
            var actual = storage.last;
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void TestLastq()
        {
            Storage storage = new Storage();
            storage.lastq = "abcd";
            var expect = "abcd";
            var actual = storage.lastq;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMyConstants()
        {
            //Storage storage = new Storage();
            Storage.myConstants["a"] = 3;
            var expect =3;
            var actual = Storage.myConstants["a"];
            Assert.AreEqual(expect, actual);
            Assert.IsTrue(Storage.myConstants.ContainsKey("a"));
            Assert.IsTrue(Storage.myConstants.ContainsValue(3));
        }
    }
}
