double x, y;
char opp;
bool can = true;
while (can)
    {

    Console.WriteLine("Ange den första siffran");
    x = inmetning();
    Console.WriteLine("Ange den andra siffran");
    y = inmetning();
    Console.WriteLine("Vilken operation vill du göra? + , - , / eller *");
    opp = char.Parse(Console.ReadLine());


    switch (opp)
        {
        case '+':
                {
                Addition(x, y);
                break;
                }
        case '-':
                {
                Subtraction(x, y);
                break;
                }
        case '*':
                {
                Multiplication(x, y);

                break;
                }
        case '/':
                {
                Division(x, y);

                break;
                }
        default:
                {
                Console.WriteLine("Ogiltig operation");
                break;
                }
        }


    Console.WriteLine("Vill du fortsätta? Om du inte vill ange siffran 0");
    if (int.Parse(Console.Read().ToString()) == 0)
        can = false;
    }

double inmetning()
    {
    while (true)
        {
        try
            {
            return double.Parse(Console.ReadLine());
            }
        catch
            {
            Console.WriteLine("Inmatningen är inte giltig ,Ange numret igen");
            }
        }
    }

void Division(double x, double y)
    {
    if (y != 0)
        {

        Console.WriteLine($"Svaret är:{(double)x / (double)y}");
        }
    else
        Console.WriteLine("Det är inte tillåtet att dividera med noll");
    }

void Multiplication(double x, double y)
    {
    Console.WriteLine((x * y).ToString());
    }

void Subtraction(double x, double y)
    {
    Console.WriteLine((x - y).ToString());
    }

void Addition(double x, double y)
    {
    Console.WriteLine((x + y).ToString());
    }