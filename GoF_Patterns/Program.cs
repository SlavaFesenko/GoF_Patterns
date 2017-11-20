using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoF_Patterns.Facade;

namespace GoF_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IClient client = new ProgrammerClient();
            client.UsePattern();

            Console.ReadLine();
        }
    }
}
