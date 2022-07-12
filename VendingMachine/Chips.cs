using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
    {
    internal  class Chips : Product
        {
        public Chips(string name, string description, int pris, bool used, int id) : base(name, description, pris, used,id)
            {
            Used = false;
            }
        public override void Examine() {

            Console.WriteLine($"The price of this product is {Pris} SEK ");
            Console.WriteLine($"Description: {Description} ");
            }
        public override void Use()
            {
            Used = true;
            Console.WriteLine("Eat the Chips");
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
            }


        }
    }
