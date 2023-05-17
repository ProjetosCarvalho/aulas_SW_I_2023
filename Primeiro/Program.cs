namespace Primeiro;
class Program
{
    static void Main(string[] args)
    {
        Homem n1 = new Homem();
        Cao n2 = new Cao();
        Gato n3 = new Gato();

        n1.Nome = "Homem.";
        n2.Nome = "Cão.";
        n3.Nome = "Gato.";

        Console.WriteLine("Este é o: " + n1.Nome + " " + n1.Fala());
        Console.WriteLine("Este é o: " + n2.Nome + " " + n2.Fala());
        Console.WriteLine("Este é o: " + n3.Nome + " " + n3.Fala());
    }
}
