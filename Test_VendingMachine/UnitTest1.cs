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
            Chips chips = new Chips("Chips Sourcream & Onion", "Estrella Sourcream & Onion är krispiga finräfflade potatischips med smak av gräddfil och lök.", 25, false, 1);
         


            Assert.Equal(Done, String.Equals(value, chips.Examine()));

            }
        [Theory]
        [InlineData("2-Product name Mixer Fruktdryck Mojito : Price:10 ", true)]
       
        public void TestDrinks(string value, bool Done)
            {
                       Drink drink = new Drink("Mixer Fruktdryck Mojito", "Drinken är serverad!Mojito kommer ursprungligen från Brasilien men har spridit sig över hela världen och är omåttligt populär.", 10, false, 2);
         


            Assert.Equal(Done, String.Equals(value, drink.Examine()));
            }

        [Theory]

        [InlineData("3-Product name Mjölkchoklad : Price:10 ", true)]
        public void Testsweets(string value, bool Done)
            {
             Sweets sweets = new Sweets("Mjölkchoklad", "Marabou Mjölkchoklad, en riktig klassiker! En chokladkaka med vår älskade Marabou Mjölkchoklad i 200g som passar för alla tillfällen.", 10, false, 3);



          
            Assert.Equal(Done, String.Equals(value, sweets.Examine()));
          
            }
        }
    }