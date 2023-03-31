using System.ComponentModel;

namespace Assessment2_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine()!;
            Console.Write("Enter number of agents: ");
            int nAgents = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the names of other people: ");
            string others = Console.ReadLine()!;
            Console.WriteLine(License(name, nAgents, others));
        }
        public static int License(string name, int nAgents, string others)
        {
            List<string> allNames = new() { name };
            foreach (string n in others.Split(" "))
            {
                allNames.Add(n);
            }
            allNames.Sort();
            int ind = allNames.IndexOf(name);
            int batch = ind / nAgents + 1;
            int time = batch * 20;
            return time;
        }
    }
}