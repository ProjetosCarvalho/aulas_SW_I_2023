namespace Desafio;
class Aluno
{
    public string nome = "";
    public double nota1, nota2;

public double obterMedia(){
    double media = (nota1+nota2)/2;
    return media;
}

public string obterSituacao(double media){
    string situacao = "";
    if(media>=6){
        situacao = "APROVADO";
    }else{
        situacao = "REPROVADO";
    }
    return situacao;
}

public void mensagem(){
    double mediaCalculadora = obterMedia();
    string resultadoSituacao = obterSituacao(mediaCalculadora);
    Console.WriteLine(nome + " está " + resultadoSituacao + " com média: " + mediaCalculadora);
}
}