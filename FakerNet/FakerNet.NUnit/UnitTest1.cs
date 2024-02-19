namespace FakerNet.NUnit
{
    [TestClass]
    public class UnitTest1 : FakerNUnitBase
    {
        [TestMethod]
        public void TestMethod1()
        {
            FakerForEveryLocale(f => f.Emotion.Adjective());
        }
    }
}