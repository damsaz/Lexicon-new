using VendingMachine;
namespace Test_VendingMachine
    {
    public class UnitTest1
        {
       
       
        [Fact]
        public void Testadd()
            {
            Bank bank = new Bank();
            bank.add(1, 1);
            int x=bank.Inventory();
            Assert.Equal(x, 1);
            }
       
        [Theory]
        [InlineData(1, true)]
        [InlineData(25, false)]
        public void Testremove(int value,bool Done)
            {
            Bank bank = new Bank();
            bool res=false;
            bank.add(1, 1);
            bank.remove(value, ref res);
            Assert.Equal(Done,res);
            }

        [Theory]
        [InlineData("25kr", false)]
        public void Testkeyswitcher(string value, bool Done)
            {
            Machine Machine = new Machine();
           
            bool res = false;
            Machine.keyswitcher(value,ref res);
            Assert.Equal(Done, res);
            }
    
     
        [Theory]
        [InlineData("1-Product name Chips Sourcream & Onion : Price:25 ", true)]
        public void Testchips(string value, bool Done)
            {
            Chips chips = new Chips("Chips Sourcream & Onion", "Estrella Sourcream & Onion �r krispiga finr�fflade potatischips med smak av gr�ddfil och l�k.", 25, false, 1);
         


            Assert.Equal(Done, String.Equals(value, chips.Examine()));

            }
        [Theory]
        [InlineData("2-Product name Mixer Fruktdryck Mojito : Price:10 ", true)]
       
        public void TestDrinks(string value, bool Done)
            {
                       Drink drink = new Drink("Mixer Fruktdryck Mojito", "Drinken �r serverad!Mojito kommer ursprungligen fr�n Brasilien men har spridit sig �ver hela v�rlden och �r om�ttligt popul�r.", 10, false, 2);
         


            Assert.Equal(Done, String.Equals(value, drink.Examine()));
            }

        [Theory]

        [InlineData("3-Product name Mj�lkchoklad : Price:10 ", true)]
        public void Testsweets(string value, bool Done)
            {
             Sweets sweets = new Sweets("Mj�lkchoklad", "Marabou Mj�lkchoklad, en riktig klassiker! En chokladkaka med v�r �lskade Marabou Mj�lkchoklad i 200g som passar f�r alla tillf�llen.", 10, false, 3);



          
            Assert.Equal(Done, String.Equals(value, sweets.Examine()));
          
            }
        }
    }