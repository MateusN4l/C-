using System;
class Aula1
{
    static void Main(){
       string nome = "fernando";
       int idade = 19;
       char sangue = 'O';
       float cartiera = 76.90f;

        Console.WriteLine("Nome:"+nome);
        Console.WriteLine("Idade:"+idade);
        Console.WriteLine("Tipo do sangue:"+sangue);
        Console.WriteLine("Saldo da carteira:"+cartiera);

        Calculo.Somar();
        Texto.Falar();
    }
 
}

class Calculo
{
    public static void Somar()
    {
        int n1 = 9;
        int n2 = 9;
        var soma = n1+n2;
        Console.WriteLine("\nA soma de "+ n1 + " + " + n2 + " é igual a: "+ soma);
    }
}
class Texto
{
    public static void Falar()
    {
        string texto = "\nFinal do programa";
        Console.WriteLine(texto);
    }
}