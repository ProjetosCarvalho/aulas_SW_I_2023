namespace Desafio;
class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();

        Console.WriteLine("Insira o nome do aluno: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("O nome é: " + nome);

        Console.WriteLine("Insira a primeira nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("A primeira nota é: " + nota1);

        Console.WriteLine("Insira a segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("A segunda nota é: " + nota2);

        aluno1.nome = nome;
        aluno1.nota1 = nota1;
        aluno1.nota2 = nota2;

        aluno1.mensagem();
    }
}