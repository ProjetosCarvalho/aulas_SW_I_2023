namespace exerc_aviao;
class Aviao
{
 public string modelo = "";
 public int velocidade;
 public int altitude; 
 public string marca = "";

 public void reduzir(){
    velocidade --;
}  
 public void subir(){
    altitude ++;
}  
 public void descer(){
    altitude --;
}  
public void acelerar(){
    velocidade ++;
}  

public void mostrar(){
   Console.WriteLine("Modelo: " + modelo);
   Console.WriteLine("Marca: " + marca);
   Console.WriteLine("Velocidade Atual: " + velocidade);
   Console.WriteLine("Altitude Atual: " + altitude);
}
}
