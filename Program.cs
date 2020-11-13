using System;

namespace Exercicio_Idade_Convite
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Qual sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            
            if(idade >=18){
                Console.WriteLine("Você gostria de participar do time de CS?  -Sim ou Não-");
                string resposta = Console.ReadLine();
                if(resposta == "Sim"){
                    Console.WriteLine("Compareça a Secretária - Falar com a Sara");
                }else{
                    Console.WriteLine("Obrigada pela participação!");
                }
            }else{
                Console.WriteLine("Você gostaria de participar do Time de LOL?  -Sim ou Não-");
                string resposta = Console.ReadLine();
                if(resposta == "Sim"){
                    Console.WriteLine("Compareça à Secretária - Falar com Juscelino");
                }else{
                    Console.WriteLine("Obrigada pela participação!!");
                }
            }
        }
    }
}
