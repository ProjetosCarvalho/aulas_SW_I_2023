namespace Segundo;
class Program
{
    static void Main(string[] args)
    {
        ContratoPessoaFisica n1 = new ContratoPessoaFisica();
        ContratoPessoaJuridica n2 = new ContratoPessoaJuridica();
        Contrato n3 = new Contrato();

        n3.Email = "fulano@gmail.com";
        n3.Nome = "Fulano";
        n3.Telefone = "(11) 91234-4321";
        n2.cnpj = "12.345.678/0001-00";
        n2.ie = "";
        n2.NomeEmpresa = "Empresa X";
        n1.cpf = "000.111.222-33";
        n1.Idade = 19;

        Console.WriteLine("Os dados Pessoa Física são: " + n1.MostraDados());
        Console.WriteLine("Os dados Pessoa Jurídica são: " + n2.MostraDados());
    }
}
