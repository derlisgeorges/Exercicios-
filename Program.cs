using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para paricipar do time de CS o aluno precisar ter media  ao igual a 80
            // E Faltas menor ou igual a 10% dos dias letivos<Project Sdk="Microsoft.NET.Sdk.Web">
        Console.WriteLine("_________________________________________________");
        Console.WriteLine("Bem vindo a seletiva para time de Counter-Strike");
        Console.WriteLine("_________________________________________________");
        Console.WriteLine("Voce gostaria de participar? Sim ou Nao");
        string resposta = Console.ReadLine();
        if(resposta == "Sim"){
            Console.WriteLine("Que legal! Agora vamos analisar seu currículo");
            Console.WriteLine("Insira sua média escolar");
            int media = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua quantidade de faltas");
            int faltas = int.Parse(Console. ReadLine());
            if (media>=50 && faltas <= 10){
                Console.WriteLine("Parabens seja bem vindo");
            }else{
                Console.WriteLine("Que pena, você precisa melhorar suas notas e faltas");
            }
        }else{
            Console.WriteLine("Blz, passar bem!");
        } //fim if           
        }
    }
}
