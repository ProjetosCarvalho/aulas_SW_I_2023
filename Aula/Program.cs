namespace Aula;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Console.ReadKey();

        // Instanciar um objeto a partir de uma classe
        Exemplo ex01 = new Exemplo();

        ex01.mostramsg();

        ex01.mostranome(" Giovanna");

        Console.WriteLine(ex01.msg());

        Console.WriteLine("A soma dos dois números é: " + ex01.somar(10,20));
    }
}
