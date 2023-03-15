namespace exerc_aviao;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        Aviao aviao1 = new Aviao();

        aviao1.modelo = "Boeing 747";
        aviao1.marca = "Azul";

        aviao1.acelerar();
        aviao1.subir();
        aviao1.mostrar();
        aviao1.descer();
        aviao1.mostrar();
    } 
}