using System.Text;

namespace VendingMachine
    {
    public class Bank: Money
        {
        private Dictionary<int,int> Moneybanks;
        
        int Total;
        public Bank()
            {
            this.Total = 0;
            Moneybanks=new Dictionary<int,int>();   
            }

        public void add( int moneytype, int count)
            {
            if (!Moneybanks.ContainsKey(moneytype))
                Moneybanks.Add(moneytype, count);
            else
                Moneybanks[moneytype] += count;
            Total += ((int)moneytype) * count;
            }

        public void remove(int value ,ref bool ok)
            {
            if (value < Total) { 
            Total -= value;
                ok= true;
                }
            else { 
                Console.WriteLine("You don't have that much money! Purchase canceled! Enter any key ");
          Console.ReadKey();
                }
            }

        internal StringBuilder Pay_back_money()
            
           {
            var builder = new StringBuilder();
            int  count, i;
           
            for (i = 0; i < moneytype.Length; i++)
                {
                count = this.Total / moneytype[i];
                if (count != 0) { 
                    Console.WriteLine("Count of {0} cent(s) :{1}", moneytype[i], count);
                    builder.Append(moneytype[i], count)
                    }
                this.Total %= moneytype[i];
                }
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
            }

        public int Inventory()
            {
             return Total;  
            }
        }
    }