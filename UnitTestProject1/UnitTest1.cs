using GayfullinDV_01_01;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static GayfullinDV_01_01.Program;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestMethod1()
        {
            Pitanie pitanie = new Pitanie();
            pitanie.Belok = 100;
            pitanie.Uglevods = 25;
            Assert.AreEqual(pitanie.Uglevods * 4 + pitanie.Belok * 4, pitanie.Q());
        }

        [TestMethod]
        public void TestMethod2()
        {
            Potomok potomok = new Potomok();
            potomok.Belok = 24.5;
            potomok.Uglevods = 78;
            potomok.Zhiri = 26.27;

            Assert.AreEqual(potomok.Q() * 1.5 + potomok.Zhiri * 10, potomok.Qp());
        }

        [TestMethod]
        public void TestMethod3()
        {
            Pitanie pitanie = new Pitanie();
            pitanie.Belok = 692.15;
            pitanie.Uglevods = 8;
            pitanie.Name = "Молоко";

            Assert.AreEqual($"Название: Молоко, Кол-во белка: 692,15г, Кол-во углеводов: 8г, Q: 2800,6", pitanie.Info());
        }
    }
}
