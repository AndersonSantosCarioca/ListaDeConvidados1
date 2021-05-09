using System;

namespace ListaDeConvidados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do convidado:");
            var nome = Console.ReadLine();

            if(string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Desculpe, Informe um dado válido para seguir com o programa.");
                return;
            }

            Console.WriteLine("Informe a idade do convidado:");
            var idadeString = Console.ReadLine();
            int idade;

            bool idadeInformada = int.TryParse(idadeString, out idade);
            if(idadeInformada == false)
            {
                Console.WriteLine("Idade não é válida para seguir com o programa.");
                return;
            }

            bool estaConvidado;
            switch (nome)
            {
                case "Anderson":
                    estaConvidado = true;
                    break;
                case "Julia":
                    estaConvidado = true;
                    break;
                case "Paulo":
                    estaConvidado = true;
                    break;
                case "Maria":
                    estaConvidado = true;
                    break;
                case "Eunice":
                    estaConvidado = true;
                    break;
                default:
                    estaConvidado = false;
                    break;


            }
            

            if(estaConvidado == true && idade > 18)
            {
                Console.WriteLine("Bem vindo à nossa festa:");
            }
            else if(estaConvidado == false)
            {
                Console.WriteLine("Você não está na lista de convidaos:");
            }
            else
            {
                Console.WriteLine("Você não tem 18 anos para entrar na festa");
            }
        }
    }
}
