namespace Primeiro;
class Gato:Animal
{
    public string Nome = "";
      public override string Fala(){
        return base.Fala() + " Miau";
    }
}
