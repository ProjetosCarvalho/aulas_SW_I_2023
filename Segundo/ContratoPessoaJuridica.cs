namespace Segundo;
class ContratoPessoaJuridica:Contrato
{
   public string? cnpj;
   public string? ie;
   public string? NomeEmpresa;

   public override string MostraDados(){
        return base.MostraDados() + "CNPJ:" + this.cnpj + "IE:" + this.ie + "NomeEmpresa:" + this.NomeEmpresa;
    }
}