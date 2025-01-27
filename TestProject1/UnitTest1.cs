using Zadanie;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestowanieTworzeniaDzienniczka()
        {
            Dzienniczek dzienniczek = new Dzienniczek();
            Assert.IsNotNull(dzienniczek);
        }

        [TestMethod]
        public void TestowanieDodawaniaPrzedmiotu()
        {
            Dzienniczek dzienniczek = new Dzienniczek();
            string dodawany_przedmiot = "Matematyka";
            dzienniczek.AddClass(dodawany_przedmiot);
            Assert.AreEqual(true, dzienniczek.ClassExists(dodawany_przedmiot));
        }

        [TestMethod]
        public void PobraniePrzedmiotuZDzienniczka()
        {
            Dzienniczek dzienniczek = new Dzienniczek();
            string dodawany_przedmiot = "Matematyka";
            dzienniczek.AddClass(dodawany_przedmiot);
            List<int> oceny = dzienniczek.GetGrades(dodawany_przedmiot);
            Assert.IsNotNull(oceny);
        }

        [TestMethod]
        public void DodawanieOcenyDoPrzedmiotu()
        {
            Dzienniczek dzienniczek = new Dzienniczek();
            string dodawany_przedmiot = "Matematyka";
            dzienniczek.AddClass(dodawany_przedmiot);
            dzienniczek.AddGrade(dodawany_przedmiot, 5);
            dzienniczek.AddGrade(dodawany_przedmiot, 4);
            dzienniczek.AddGrade(dodawany_przedmiot, 1);
            List<int> oczekiwane_oceny = new List<int> { 5, 4, 1 };
            List<int> otrzymane_oceny = dzienniczek.GetGrades(dodawany_przedmiot);
            Assert.AreEqual(oczekiwane_oceny.ToString(), otrzymane_oceny.ToString());
        }

        [TestMethod]
        public void SredniaDlaPrzedmiotu()
        {
            Dzienniczek dzienniczek = new Dzienniczek();
            string dodawany_przedmiot = "Matematyka";
            dzienniczek.AddClass(dodawany_przedmiot);
            dzienniczek.AddGrade(dodawany_przedmiot, 5);
            dzienniczek.AddGrade(dodawany_przedmiot, 2);
            dzienniczek.AddGrade(dodawany_przedmiot, 2);

            Assert.AreEqual(oczekiwane_oceny.ToString(), dzienniczek.GetGrades(dodawany_przedmiot).ToString());
        }

        [TestMethod]
        public void SredniaDlaDzienniczka()
        {
            Dzienniczek dzienniczek = new Dzienniczek();
            string dodawany_przedmiot = "Matematyka";
            dzienniczek.AddClass(dodawany_przedmiot);
            dzienniczek.AddGrade(dodawany_przedmiot, 5);
            dzienniczek.AddGrade(dodawany_przedmiot, 4);
            dzienniczek.AddGrade(dodawany_przedmiot, 1);
            List<int> oczekiwane_oceny = new List<int> { 5, 4, 1 };
            Assert.AreEqual(oczekiwane_oceny.ToString(), dzienniczek.GetGrades(dodawany_przedmiot).ToString());
        }

    }
}