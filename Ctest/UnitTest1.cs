


namespace Ctest
    {
    public class UnitTest1
        {
        [Fact]
        public void Addition_test()
            {
            calculator cal = new  calculator();
            double x = cal.Addition(1, 2);
            Assert.Equal(x, 3);

            }
        [Fact]
        public void Addition_array_test()
            {
            double[] inp = { 1, 2, 3, 4 };
            calculator cal = new calculator();
            double x = cal.Addition(inp);
            Assert.Equal(x, 10);

            }
        [Fact]
        public void Subtraction_test()
            {
            calculator cal = new calculator();
            double x = cal.Subtraction(5, 2);
            Assert.Equal(x, 3);
            
            }
        [Fact]
        public void Subtraction_array_test()
            {
            calculator cal = new calculator();
            double[] inp = { 10, 2, 3, 4 };
            double x = cal.Subtraction(inp);
            Assert.Equal(x, 1);

            }
        [Fact]
        public void Multiplication_test()
            {
            calculator cal = new calculator();
            double x = cal.Multiplication(1, 2);
            Assert.Equal(x, 2);

            }
        [Fact]
        public void Division_test()
            {
            calculator cal = new calculator();
            double x = cal.Division(6, 2);
            Assert.Equal(x, 3);

            }
        [Fact]
        public void Division_ziro_test()
            {
            calculator cal = new calculator();
            double x = cal.Division(2, 0);
            Assert.Equal(x, 0);

            }

        }
    }