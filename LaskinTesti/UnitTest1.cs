using WPFlakentaOhjelma;

namespace LaskinTesti
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Laskenta laskutesti = new Laskenta();
            double tulos = laskutesti.YhteenLasku(3.5, 10.1);
            Assert.AreEqual(tulos, 13.6); // verrataan onko tulos oikein
        }
    }
}