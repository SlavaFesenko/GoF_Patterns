﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoF_Patterns.Facade;
using GoF_Patterns.Decorator;
using GoF_Patterns.Utils;

namespace GoF_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonPresenter.Present(PatternType.Facade, PresentType.OwnExample);

            Console.ReadLine();
        }
    }
}
