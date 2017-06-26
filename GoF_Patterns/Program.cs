using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new PanelDeveloper("ООО КирпичСтрой");
            House panelHouse = dev.Create();

            dev = new WoodDeveloper("Частный застройщик");
            House woodHouse = dev.Create();

            Console.ReadLine();
        }
    }
}
