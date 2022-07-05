using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
    {
    internal class unittest
        {
        input calculat  =new input();

        public unittest()
            {
            for (int i = 0; i < 10; i++)
                {
                double x = calculat.inmetning();
                char c = calculat.inmetningopp();
                }
            for (int i = 0; i < 10; i++)
                {
                double a = calculat.inmetning(2);
                }
            Console.ReadLine();
            }
      

        }
    }
