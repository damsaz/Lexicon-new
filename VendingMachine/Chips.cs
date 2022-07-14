using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
    {
    public  class Chips : Product
        {
        public Chips(string name, string description, int pris, bool used, int id) : base(name, description, pris, used,id)
            {
            Used = false;
            }
        public  override string Examine(bool Type) {
            if(Type)
           return  $"{Id}-Product name {Name} : Price:{Pris} ";
            else
                return $"Product name {Name} \nDescription:{Description}";
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
