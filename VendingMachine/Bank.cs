using System.Text;

namespace VendingMachine
    {
    public class Bank: Money
        {
        
        
        int Total;
        public Bank()
            {
            this.Total = 0;
          
            
            }

        public void add( int moneytype, int count)
            {
          
            Total += ((int)moneytype) * count;
            }

        public void remove(int value ,ref bool ok)
            {
            if (value <= Total) { 
            Total -= value;
                ok= true;
                }
            else { 
ok= false;  
                }
            }

        internal Dictionary<int, int> Pay_back_money_fun()
            
           {
            int  count, i;
            Dictionary<int,int> moneyback  = new Dictionary<int, int>(); ;
            for (i = 0; i < moneytype.Length; i++)
                {
                count = this.Total / moneytype[i];
                if (count != 0) { 
                   // Console.WriteLine("Count of {0} cent(s) :{1}", moneytype[i], count);
                    moneyback.Add(moneytype[i], count);
                    }
                this.Total %= moneytype[i];
                }
            return moneyback;

            }

        internal void Pay_back_money_print()
            {
            Dictionary<int, int> moneyback = Pay_back_money_fun();
            foreach (var item in moneyback)
                {
                Console.WriteLine("Count of {0} SKR(s) :{1}", item.Key, item.Value);
 
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