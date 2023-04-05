namespace projeto_pessoa;
class Pessoa
{
  public Pessoa(){
    this.Nome = "Fulano";
    this.Sobrenome = "Silva";
    this.Idade = 18;
  }

  public Pessoa(string nome, int idade){
    this.Nome = nome;
    this.Idade = idade;
    this.Sobrenome = "NÃO INFORMADO";
  }

  private string? Nome {get;set;}
  private string? Sobrenome {get;set;}
  private int Idade {get;set;}

  public void insereNome(string nome){
    this.Nome = nome;
  }
  public void insereSobrenome(string sobrenome){
    this.Sobrenome = sobrenome;
  }
  public void insereIdade(int idade){
    this.Idade = idade;
  }
  public void mostraDados(){
    Console.WriteLine("Dados Cadastrados:");
    Console.WriteLine("O nome é: " + this.Nome);
    Console.WriteLine("O sobrenome é: " + this.Sobrenome);
    Console.WriteLine("A idade é: " + this.Idade);
  }
}
