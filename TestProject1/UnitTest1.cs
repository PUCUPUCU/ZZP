using Zadanie;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestowanieDodawania()
        {
            Dzienniczek dzienniczek = new Dzienniczek();
            string dodawany_przedmiot = "Matematyka";
            dzienniczek.AddClass(dodawany_przedmiot);
            Assert.AreEqual(true, dzienniczek.ClassExists(dodawany_przedmiot));
        }
    }
}