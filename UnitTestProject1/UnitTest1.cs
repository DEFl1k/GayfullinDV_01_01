using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestMethod1()
        {
            GayfullinDV_01_01.Pitanie pitanie = new GayfullinDV_01_01.Pitanie();
            pitanie.Belok = 100.5;
            pitanie.Uglevods = 25;
            Assert.AreEqual(pitanie.Uglevods * 4 + pitanie.Belok * 4, pitanie.Q());
        }

        [TestMethod]
        public void TestMethod2()
        {
            GayfullinDV_01_01.Potomok potomok = new GayfullinDV_01_01.Potomok();
            potomok.Belok = 100.5;
            potomok.Uglevods = 25;
            potomok.Zhiri = 73.56;

            Assert.AreEqual(potomok.Q() * 1.5 + potomok.Zhiri * 10, potomok.Qp());
        }

    }
}
