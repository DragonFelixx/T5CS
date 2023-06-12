using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace T5CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Football football1 = new Football(11, 200, "Shi", "Tu", "Korea", "China");
            football1.AddScore(0);
            football1.AddScore(0);
            football1.AddScore(1);
            football1.AddScore(0);
            Football football2 = new Football(11, 200, "Meni", "Namf", "Italy", "Germany");
            football2.AddScore(0);
            football2.AddScore(1);
            football2.AddScore(1);
            Console.WriteLine(football1.toString());
            Console.WriteLine(football2.toString());

            List<ISport> sports = new List<ISport> { football1, football2 };
            foreach (var sport in sports)
            {
                Console.WriteLine("Победитель: {0}", sport.GetWinner());
            }

            Console.ReadLine();

        }
    }
}
