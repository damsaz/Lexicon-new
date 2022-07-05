using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

public class calculator
    {
    



    public calculator()
        {
        }

    public void Run()
        {
       bool  can = true;
       
        while (can)
            {
            input input1 = new input();
              input1.Run(); 
            




            switch (input1.opp)
                {
                case '+':
                        {
                        if(input1.inp.Length ==2)
                            printer(Addition(input1.inp[0], input1.inp[1]));
                        else
                            printer(Addition(input1.inp));

                        break;
                        }
                case '-':
                        {
                        if (input1.inp.Length == 2)
                           printer( Subtraction(input1.inp[0], input1.inp[1]));
                        else
                            printer(Subtraction(input1.inp));
          
                        break;
                        }
                case '*':
                        {

                        printer(Multiplication(input1.inp[0], input1.inp[1]));
                        break;

                        }
                case '/':
                        {
                        printer(Division(input1.inp[0], input1.inp[1]));

                        break;
                        }
                default:
                        {
                        Console.WriteLine("Ogiltig operation");
                        break;
                        }
                }


            Console.WriteLine("Vill du fortsätta? Om du inte vill ange siffran 0");
            
            if (Console.ReadLine().CompareTo("0")==0)
                can = false;
            }
        }

    private void printer(double v)
        {
        Console.WriteLine("Resultatet är: " + v.ToString());
        }

    public double Subtraction(double[] inp)
        {
        double sum = inp[0];
        for (int i = 1; i < inp.Length; i++)
            sum -= inp[i];
        return(sum);
        }




    public double Addition(double[] input)
        {
        double sum = 0;
        for (int i = 0; i < input.Length; i++)
            sum += input[i];
        return (sum);
        }



    public double Division(double x, double y)
        {
        if (y != 0)
            {

            return x / y;
            }
        else
            Console.WriteLine("Det är inte tillåtet att dividera med noll");
        return 0;   
        }

    public double Multiplication(double x, double y)
        {
        return (x * y);
        }

    public double Subtraction(double x, double y)
        {
         return(x - y);
        }

    public double Addition(double x, double y)
        {
        return x + y;
        }
    

  
    }