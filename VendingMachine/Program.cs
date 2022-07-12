// See https://aka.ms/new-console-template for more information
using VendingMachine;

Machine Machine = new Machine();

bool keep = true;
do

    {

    Mprinter();
    int? key = int.Parse(Console.ReadLine());
    switch (key)
        {
        case 1:

            Machine.insert();
            break;
        case 2:
            Machine.Show();
            
            break;
        case 3:

            Machine.Buy();
            break;
        case 4:
            Machine.EndT();
            keep = false;

            break;
       
        default:
            Console.WriteLine("Invalid denomination...");
            break;
        }
 
    Console.Clear();
    } while (keep);

void Mprinter()
    {
    Console.WriteLine($"Your balance is {Machine.DS()}kr ");
    Console.WriteLine("What do you want to do? Enter from 1 - 4 ");
    Console.WriteLine("1-Do you want to put money in the device?");
    Console.WriteLine("2-Do you want to see all the products?");
    Console.WriteLine("3-Do you want to buy something?");
    Console.WriteLine("4-Is your purchase finished?");
    }