namespace Primeiro;
class Homem:Animal

{
    public string Nome = "";

     public override string Fala(){
        return base.Fala() + " Oi";
    }
}
