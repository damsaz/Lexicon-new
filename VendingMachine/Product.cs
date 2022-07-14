using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
    {
    public abstract class Product
        {
        public Product(string name, string description, int pris, bool used, int id)
            {
            Name = name;
            Description = description;
            Pris = pris;
            Used = used;
            Id = id;
            }
        public virtual string Examine() {
            return "";
            }
        public virtual void Use() { }
        public virtual void Details() {
            Console.WriteLine(Examine());
            }
        public virtual void Add(int number ) { }
       
        public virtual int Prisof() {
            return Pris;

            }
        public virtual void Remove(int number) { }
        public string Name { get; }
        public string Description { get; }
        public int Pris { get; }
        public bool Used { get; set; }
        public int Id { get; }
        }
    }
