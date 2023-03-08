namespace Aula;
class Exemplo
{
    // Atributos
    public string nome = "";
    public int idade = 0;
    public bool vacinado = false;

    // Métodos
    // sem retorno, sem parametro
    public void mostramsg(){
        Console.WriteLine("Oi 2F!");
    }

    // sem retorno, com parametro
    public void mostranome(string texto){
        Console.WriteLine("Oi" + texto);
    }

    // com retorno, sem parametro
    public string msg(){
        return "Olá, tudo bem?";
    }

    // com retorno, com parametro ou (public double somar(double,int))
    public int somar(int a, int b){
        return a+b;
    }

}
