using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputationClass Comp = new ComputationClass();
            DisplayClass Disp = new DisplayClass();
            
            string Answer = Comp.Comp();
            Console.WriteLine(Disp.display(Answer));
            Console.ReadKey();
        }
    }
}
