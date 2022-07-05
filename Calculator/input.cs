internal class input
    {
    
   public double[] inp = new double[2];
    public char opp;

    public input()
        {

        

       
        
        }
    public void Run()
        {



        opp = inmetningopp();


        if (opp == '/' || opp == '*')
            {
            Console.WriteLine("Ange den första siffran");
            inp[0] = inmetning();
            Console.WriteLine("Ange den andra siffran");
            inp[1] = inmetning();
            }
        else
            {
            Console.WriteLine("ange siffrorna med komma separerade till ex 1,2,3");
            inp = inmetningcoma();
           
            }

        }
    public double inmetning()
        {
        while (true)
            {
            string inpd="";
            try
                {
                 inpd = Console.ReadLine();
                return double.Parse(inpd);
                }
            catch (Exception ex)
                {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Inmatningen är inte giltig ,Ange numret igen");
                }
            }
        }
    public double inmetning(int i)
        {
        while (true)
            {
            try
                {
                Console.WriteLine($"skriv in {i+1} siffran ");
                
                return double.Parse(Console.ReadLine());
                }
            catch
                {
                Console.WriteLine("Inmatningen är inte giltig ,Ange numret igen");
                }
            }
        }
    public double[] inmetningcoma()
        {
        while (true)
            {
            try
                {
                

                return ToIntArray(Console.ReadLine(),',');
                   
                }
            catch
                {
                Console.WriteLine("Inmatningen är inte giltig ,Ange numret igen");
                }
            }
        }

    private double[] ToIntArray(string? value, char separator)
        {

            return Array.ConvertAll(value.Split(separator), s => double.Parse(s));
            

        }

    public char inmetningopp()
        {
        while (true)
            {
            try
                {
                
                
                
                
                Console.WriteLine("Vilken operation vill du göra? + , - , / eller *");
                string input = Console.ReadLine();  
                char x = char.Parse(input);
                if (x== '+' || x == '/' || x == '-' || x == '*' )
                    return x;
                 else
                    Console.WriteLine("opprationet är inte giltig ,Ange  igen");
                }
            catch
                {
                Console.WriteLine("opprationet är inte giltig ,Ange  igen");
                }
            }
        }

    }