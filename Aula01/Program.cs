using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int escolha;
        
        do
        {
            Console.WriteLine("------------CALCULADORA------------");
            Console.WriteLine("Qual tipo de conta deseja fazer.");
            Console.WriteLine("Digite o numero correspondente");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- divisão");
            Console.WriteLine("3- multiplicação");
            Console.WriteLine("4- subtração");
            Console.WriteLine("5- contas salvas");
            Console.WriteLine("6- sair");
            escolha = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (escolha)
            {
                case 1:
                    somar ();
                    break;
                case 2:
                    dividir ();
                    break;
                case 3:
                    multiplicar ();
                    break;
                case 4:
                    subtrair ();
                    break;
                case 5:
                    contasSalvas();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Fim do programa...");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Numero incorreto, reeleia as intruções\ne coloque a opção válida !!");
                    break;



            }
        } while (escolha != 6);
    }

    static void somar (int n1=0, int n2 =0)
        {
    iniciosoma:
        int soma;
        string resposta;

        Console.Clear();
        Console.WriteLine("Digite o primeiro numero");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero");
        n2 = int.Parse(Console.ReadLine());

        soma = n1 + n2;
        Console.Clear();

        Console.WriteLine("A soma de {0}+{1}={2}", n1, n2, soma);
        Console.WriteLine("Deseja salvar está conta?[s/n]");


    errosoma:
        Console.WriteLine("Quer fazer mais alguma soma?");
        Console.WriteLine("( Sim / Não )");
        resposta = Console.ReadLine();
        resposta = resposta.ToLower();

        if (resposta == "sim" || resposta == "s")
        {
            goto iniciosoma;
        }
        else if (resposta == "nao" || resposta == "n" || resposta == "não")
        {
            Console.Clear();
            Console.WriteLine("Fim da soma....");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Resposta incorreta Tente novamente");
            goto errosoma;

        }
    }
    static void dividir(double n1 = 0, double n2 = 0)
    {
    iniciodiv:
        double divisao = 0;
        string resposta;

        Console.Clear();
        Console.WriteLine("Digite o primeiro numero");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero");
        n2 = int.Parse(Console.ReadLine());

        
        Console.Clear();

        if (n2 == 0)
        {
            Console.WriteLine("Não é possivel dividir por Zero (0)");
        }
        else
        {
            divisao = n1 / n2;
            Console.WriteLine("A divisão de {0}/{1}={2}", n1, n2, divisao.ToString("f2"));
            Console.WriteLine("Deseja salvar está conta?[s/n]");
        }

    errodiv:
        Console.WriteLine("Quer fazer mais alguma divisão?");
        Console.WriteLine("( Sim / Não )");
        resposta = Console.ReadLine();
        resposta = resposta.ToLower();

        if (resposta == "sim" || resposta == "s")
        {
            goto iniciodiv;
        }
        else if (resposta == "nao" || resposta == "n" || resposta == "não")
        {
            Console.Clear();
            Console.WriteLine("Fim da divisão....");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Resposta incorreta Tente novamente");
            goto errodiv;

        }
    }
    static void multiplicar(int n1 = 0, int n2 = 0)
    {
    iniciomult:
        int mult;
        string resposta;

        Console.Clear();
        Console.WriteLine("Digite o primeiro numero");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero");
        n2 = int.Parse(Console.ReadLine());

        mult = n1 * n2;
        Console.Clear();

        Console.WriteLine("A multiplicação de {0}x{1}={2}", n1, n2, mult);
        Console.WriteLine("Deseja salvar está conta?[s/n]");


    erromult:
        Console.WriteLine("Quer fazer mais alguma multiplicação?");
        Console.WriteLine("( Sim / Não )");
        resposta = Console.ReadLine();
        resposta = resposta.ToLower();
        if (resposta == "sim" || resposta == "s")
        {
            goto iniciomult;
        }
        else if (resposta == "nao" || resposta == "n" || resposta == "não")
        {
            Console.Clear();
            Console.WriteLine("Fim da multiplicação....");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Resposta incorreta Tente novamente");
            goto erromult;

        }
    }
    static void subtrair(int n1 = 0, int n2 = 0)
    {
    iniciosub:
        int subtrair;
        string resposta;

        Console.Clear();
        Console.WriteLine("Digite o primeiro numero");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero");
        n2 = int.Parse(Console.ReadLine());

        subtrair = n1 - n2;
        Console.Clear();

        Console.WriteLine("A subtração de {0}-{1}={2}", n1, n2, subtrair);
        Console.WriteLine("Deseja salvar está conta?[s/n]");


    errosub:
        Console.WriteLine("Quer fazer mais alguma subtração?");
        Console.WriteLine("( Sim / Não )");
        resposta = Console.ReadLine();
        resposta = resposta.ToLower();
        if (resposta == "sim" || resposta == "s")
        {
            goto iniciosub;
        }
        else if (resposta == "nao" || resposta == "n" || resposta == "não")
        {
            Console.Clear();
            Console.WriteLine("Fim da subtração....");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Resposta incorreta Tente novamente");
            goto errosub;

        }
    }
    static void contasSalvas()
    {

        Console.WriteLine("A Programar !!");
        Console.ReadLine();
        
    }
}