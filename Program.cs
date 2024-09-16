Console.WriteLine("Velkommen til Kalkulatorapp!");

// Addisjon 
Console.WriteLine("Skriv inn første tall for addisjon");
double tall1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Skriv inn andre tall for addisjon");
double tall2 = Convert.ToDouble(Console.ReadLine());

double sum = tall1 + tall2;

Console.WriteLine($"Resultat av addisjon: {sum}");
