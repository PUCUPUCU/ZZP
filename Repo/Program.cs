
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

        public List<int> GetGrades(string name)
        {
            if (!classes_grades.ContainsKey(name))
                return new List<int> ();

            return classes_grades[name];
        }

        public bool AddGrade(string name, int grade)
        {
            if (classes_grades.ContainsKey(name))
            {
                classes_grades[name].Add(grade);
                return true;
            }

            return false;
        }

        public double GetMean(string name)
        {
            int sum = 0;
            int count = 0;
            foreach (string s in classes_grades.Keys)
            {
                sum += classes_grades[s].Sum();
                count++;
            }

            return sum / count;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
