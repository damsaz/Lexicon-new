﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
    {
    public class Machine :IVending
        {
        Bank bank=new Bank();
        private string Key2;
        private bool Keep;
       // Chips chips = new Chips("Chips", "", 25, false,1);
      //  Drink drink = new Drink("Drink", "", 10, false,2);
     //   Sweets sweets = new Sweets("Sweets", "", 10, false,3);

        private List<Product> Prodocts;

        public string? Key { get; private set; }
        public int Cointype { get; private set; }
        public Machine()
            {
             Prodocts = new List<Product>();
           
            Prodocts.Add(new Chips("Chips Sourcream & Onion", "Estrella Sourcream & Onion är krispiga finräfflade potatischips med smak av gräddfil och lök.", 25, false, 1));
            Prodocts.Add(new Drink("Mixer Fruktdryck Mojito", "Drinken är serverad!Mojito kommer ursprungligen från Brasilien men har spridit sig över hela världen och är omåttligt populär.", 10, false, 2));
            Prodocts.Add(new Sweets("Mjölkchoklad", "Marabou Mjölkchoklad, en riktig klassiker! En chokladkaka med vår älskade Marabou Mjölkchoklad i 200g som passar för alla tillfällen.", 10, false, 3));
            Prodocts.Add(new Chips("Chips Grill", "Estrella Grillchips är krispiga grovräfflade chips med bastant och fyllig smak av gul lök.", 25, false, 4));
            Prodocts.Add(new Drink("Tonic water", "Originalet. När Jacob Schweppes tog fram sitt originalrecept 1783 blev detta resultatet", 10, false, 5));
            Prodocts.Add(new Sweets("Toblerone", "Den Schweiziska Toblerone är en sann ikon som funnits i mer än 100 år och är lika populär nu som då. ", 10, false, 6));
            Prodocts.Add(new Chips("Chips Havssalt Räfflade", "INGREDIENSER: Potatis 73%, solrosolja, havssalt. Förpackad i en skyddande atmosfär. Potatisens ursprungsland anges vid Bäst Före-datumet. ", 25, false, 7));
            Prodocts.Add(new Drink("Tonic water Raspberry & Rhubarb", "Kolsyrat källvatten, socker, syra: citronsyra, naturlig rabarberarom, naturlig hallonarom, naturlig kininarom,", 10, false, 8));
            Prodocts.Add(new Sweets("Vegan Ljus Choklad EKO", "Marabou Oreo är en Marabou Mjölkchoklad med bitar av OREO-kex som passar för alla olika tillfällen. ", 10, false, 9));
            }


        void  IVending.ShowAll() {

            foreach (var product in Prodocts)
                {
                product.Details();
               
                }
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
                }



        void IVending.InsertMoney() {
          
       
            do

                {
                Console.WriteLine("Which coin do you want to enter?");
                Console.WriteLine("1kr, 5kr,10kr,20kr, 50kr, 100kr, 500kr and 1000kr");
                Key = Console.ReadLine();
                Cointype = 0;
               
                switch (Key)
                    {
                    case "1kr":
                
                        Cointype = 1;
                        break;
                    case "5kr":
                       
                        Cointype = 5;
                        break;
                    case "10kr":
                       
                        Cointype = 10;
                        break;
                    case "20kr":
                     
                        Cointype = 20;
                        break;
                    case "50kr":
                       
                        Cointype = 50;
                        break;
                    case "100kr":
                      
                        Cointype = 100;
                        break;
                    case "500kr":
                      
                        Cointype = 500;
                        break;
                    case "1000kr":
                      
                        Cointype = 1000;
                        break;
                    default:
                        Console.WriteLine("Invalid denomination...");
                        break;
                    }
                if (Cointype != 0)
                    {
                    
                    bank.add(Cointype, 1);
                    }
                Console.WriteLine("Do you want to put more coins in the machine? press y ");
                Key2 = Console.ReadLine();
                 Keep = Key2 switch
                    {
                        "y" => true,
                        _ => false
                        };

                Key = null;

                } while (Keep);
            }
        void IVending.Purchase() {
           
            bool ok = false;
            Console.WriteLine($"Your balance is {bank.Inventory()}kr ");
            Console.WriteLine("What product are you planning to buy? Enter the product number");
            foreach (var product in Prodocts)
                {
                product.Details();

                }
            int id = int.Parse(Console.ReadLine())-1;
                    bank.remove(Prodocts[id].Pris,ref ok);
                    Prodocts[id].Use(); 




            }
        void IVending.EndTransaction() {
            Console.WriteLine($"Your balance is {bank.Inventory()}kr ");
            Console.WriteLine("Do you want to stop shopping? y or n ");
            Key2 = Console.ReadLine();
            Keep = Key2 switch
                {
                    "y" => true,
                    "n" => true,
                    _ => false
                    };
            if(Keep)
                bank.Pay_back_money();
            }

        public void insert() 
            {
            (this as IVending).InsertMoney();
            }
        public void Buy()
            {

            (this as IVending).Purchase();
            }
        public void Show() 
            {
            (this as IVending).ShowAll();
            }
        public void EndT()
            {
            (this as IVending).EndTransaction();
            }

        internal object DS()
            {
            return bank.Inventory();
            }
        }
    }