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
