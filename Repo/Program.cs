
namespace Zadanie
{
    public class Dzienniczek
    {
        Dictionary<string, List<int>> classes_grades = new Dictionary<string, List<int>>();

        public Dzienniczek() {}
        public void AddClass(string name)
        {
            if (classes_grades.ContainsKey(name))
                return;

            classes_grades[name] = new List<int>();
        }

        public bool ClassExists(string name)
        {
            return classes_grades.ContainsKey(name);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
