﻿﻿namespace Terceiro;
class Program
{
    static void Main(string[] args)
    {
        ContratoPessoaFisica n1 = new ContratoPessoaFisica();
        ContratoPessoaJuridica n2 = new ContratoPessoaJuridica();

        n1.Email = "fulano@gmail.com";
        n1.Nome = "Fulano";
        n1.Telefone = "(11) 91234-4321";
        n1.cpf = "000.111.222-33";
        n1.Idade = 19;
        n1.Prazo = 10;


        n2.Email = "informatic@gmail.com";
        n2.Nome = "Silva";
        n2.Telefone = "(11) 94090-8177";
        n2.cnpj = "12.345.678/0001-00";
        n2.ie = "142.270.790.110";
        n2.NomeEmpresa = "Empresa Informatic";
        n2.Prazo = 10;
        

        Console.WriteLine("Os dados Pessoa Física são: " + n1.MostraDados());
        Console.WriteLine("Os dados Pessoa Jurídica são: " + n2.MostraDados());
        Console.WriteLine("************************************");
        Console.WriteLine("O valor da prestação da Pessoa Física é de: " + n1.calcularPrestacao());
        Console.WriteLine("O valor da prestação da Pessoa Jurídica é de: " + n2.calcularPrestacao());
    }
}
