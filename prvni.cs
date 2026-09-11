Console.WriteLine("Hello, World!");

int cislo = 10;
string vstup = "100";

bool uspech = int.TryParse(text, out cislo);

if (uspech && cislo < 10)
{
    Console.WriteLine("Konverzace se zdařila tvoje číslo je" + cislo)

    Console.WritLine("Dvojnásobek čísla je" + cislo * 2);
} else if (uspech &&cislo >= 10)
  { 
    Console.Writeline("Číslo je větší nebo rovno 10")
  }
else
{
    Console.WriteLine("Konverzace se nezdařila");
}


switch (cislo)
{
    case 0: Console.WriteLine("nula"); break;
    case 10: Console.WriteLine("deset"); break;
    default: Console.WriteLine("Něco jiného"); break;
}

for int i = 0; i < 10; i++) // cyklus vypis lichych cisel
{
    Console.WriteLine(i);
}

while (cislo > 0)
{
    Console.WriteLine(cislo);
    cislo = cislo - 1;
    // opakuje dokud podminka
}

do
{
    Console.WriteLine("Cyklus se provede vždy jednou");

} while (cislo > 0); // podminka se kontroluje po provedeni bloku

string[] ovoce = { "jablko", "hruska", "banan" };

for (int i = 0; i < ovoce.Lenght; i++)
{
    Console.WriteLine(ovoce[i]);
}

foreach (var item in ovoce)
{
    Console.WriteLine(item);
}

for(int j = 0, j < 10; j++)
{
    Console.Writeline(j);
}