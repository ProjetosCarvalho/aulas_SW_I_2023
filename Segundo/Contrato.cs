namespace Segundo;
class Contrato
{
    public string? Nome;
    public string? Email;
    public string? Telefone;

    public virtual string MostraDados(){
         return "Nome:" + this.Nome + "Email:" + this.Email + "Telefone:" + this.Telefone;
    }
}