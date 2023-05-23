namespace Segundo;
class ContratoPessoaJuridica:Contrato
{
   public string? cnpj {get;set;}
   public string? ie {get;set;}
   public string? NomeEmpresa {get;set;}

   public override string MostraDados(){
        return base.MostraDados() + " - CNPJ:" + this.cnpj + " - IE:" + this.ie + " - NomeEmpresa:" + this.NomeEmpresa;
    }
}