int x = 0;
Console.WriteLine("Ange hur många steg din groda vill gå:");
hopp(int.Parse(Console.ReadLine()));
Console.WriteLine("Din groda kan ta sig fram på " + x.ToString() + " sätt:");
void hopp(int kvarande)
    {
    if (kvarande == 0)
        ++x;
    else if (kvarande < 0)
        {
        return;
        }
    hopp(kvarande - 1);
    hopp(kvarande - 2);
    }