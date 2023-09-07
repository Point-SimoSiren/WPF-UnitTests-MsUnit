using WPFlakentaOhjelma;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Laskenta laske = new Laskenta();
            double tulos = laske.YhteenLasku(1.25, 2.50);
            Assert.AreEqual(tulos, 3.75);
        }
    }
}