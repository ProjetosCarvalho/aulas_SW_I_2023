namespace Segundo;
class ContratoPessoaFisica:Contrato
{
    public string? cpf;
    public int? Idade;

    public override string MostraDados(){
        return base.MostraDados() + "CPF:" + this.cpf + "Idade:" + this.Idade;
    }
}