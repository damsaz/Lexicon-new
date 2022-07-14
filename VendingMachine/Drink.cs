using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
    {
    public class Drink : Product
        {
        public Drink(string name, string description, int pris, bool used, int id) : base(name, description, pris,used, id)
            {
            }
        public override string Examine(bool Type)
            {
            if (Type)
                return $"{Id}-Product name {Name} : Price:{Pris} ";
            else
                return $" Product name {Name} \n Description:{Description} ";
            }
        public override void Use()
            {
            Used = true;
            Console.WriteLine("(Drink the drink");
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
            }

        }
    }
