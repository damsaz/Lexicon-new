// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Text;

int cont = 0;
int max = 10;
//https://random-word-api.herokuapp.com/word
HttpClient client = new HttpClient();
client.DefaultRequestHeaders.Accept.Clear();
var stringTask = client.GetStringAsync("https://random-word-api.herokuapp.com/word");
var msg = await stringTask;
char inpchar;
bool flag = true;
StringBuilder sb = new StringBuilder();
StringBuilder resultat = new StringBuilder();
StringBuilder anv = new StringBuilder();
StringBuilder anv2 = new StringBuilder();
string ss = "(?<open>\").*?(?<final-open>\")";
var reg = new Regex(@ss);
var input = reg.Matches(msg).Cast<Match>()
    .Select(m => m.Groups["final"].Value).ToList();
sb.Append(input[0]);

int rep = sb.Length;
for (int j = 0; j < rep; j++)
    resultat.Append('_');




Console.WriteLine($"Det dolda ordet är {sb.Length} bokstäver långt och ordet är: {sb}");
while (cont < max)
    {
    flag = true;

    Console.WriteLine($"Du har {max - cont} försök till.");
    Console.WriteLine("Ange en bokstav eller en mening");
    String inp = Console.ReadLine();
    if (inp.Length > 1)
        heltext(sb, ref cont, max, inp, ref anv2, anv);
    else
        {
        Console.Clear();
        inpchar = inp[0];
        if (!anv.ToString().Contains(inp))
            {
            for (int i = 0; i < rep; i++)
                if (sb[i] == inpchar)
                    {
                    resultat.Replace('_', inpchar, i, 1);
                    Console.Clear();
                    Console.WriteLine("bra jobbat bokstavet var rätt");
                    flag = false;


                    }
            Console.WriteLine();
            Console.WriteLine(resultat);

            if (flag)
                {
                cont++;
                Console.WriteLine("bokstavet var inte rätt");
                anv.Append(inp + " ");
                }

            Console.WriteLine($"felaktiga bokstavär  är:{anv} och felaktiga angivit ord är {anv2}");

            }

        else
            {
            Console.WriteLine("felaktiga bokstäver: " + anv);
            Console.WriteLine("bokstavet är redan testad försök igen");
            }
        }
    }
Console.Write(sb);

void heltext(StringBuilder sb, ref int cont, int max, string input, ref StringBuilder anv2, StringBuilder anv)
    {
    Console.Clear();

    if (String.Equals(sb.ToString(), input))
        {
        Console.WriteLine("bra jobbat det var rätt");
        cont = max;

        }
    else
        {
        Console.WriteLine("svaret var fel");
        cont++;
        anv2.Append(input + " ");
        Console.WriteLine($"felaktiga bokstavär  är:{anv} och felaktiga angivit ord är {anv2}");
        }

    }