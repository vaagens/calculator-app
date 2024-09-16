Console.WriteLine("Velkommen til Kalkulatorapp!");

// Addisjon 
Console.WriteLine("Skriv inn første tall for addisjon");
double tall1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Skriv inn andre tall for addisjon");
double tall2 = Convert.ToDouble(Console.ReadLine());

double sum = tall1 + tall2;

Console.WriteLine($"Resultat av addisjon: {sum}");


// finn Rejwans alder
int year = DateTime.Now.Year;
Console.WriteLine($"Rejwan's alder er {year - 1997}");

// Substraksjon 

Console.WriteLine("Skriv inn første tall for Substraksjon");
double tall3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Skriv inn andre tall for Substraksjon");
double tall4 = Convert.ToDouble(Console.ReadLine());

double differanse = tall3 - tall4;

Console.WriteLine($"Resultatet av Substraksjon er {differanse}");
Console.WriteLine("Siste linje med kode");

