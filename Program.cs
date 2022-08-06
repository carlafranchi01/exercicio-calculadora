//Criar métodos para cada operação, recebendo por parâmetro os dois valores e retornando o resultado dessa operação
//- deve mostrar o resultado do processamento baseado nas entradas e a operação informada

namespace Calculadora; 
public class Calculadora{              //criacao da classe base Caluladora 
    public static void Main()
    {

        Console.WriteLine("Ola, seja bem vindo a calculadora");

        string[] operacoes = new string[5];

        operacoes[0] = "1 - Adicao";
        operacoes[1] = "2 - Subtracao";
        operacoes[2] = "3 - Multiplicacao";
        operacoes[3] = "4 - Divisao";
        operacoes[4] = "5 - SAIR";

        Console.WriteLine(operacoes[0]);
        Console.WriteLine(operacoes[1]);
        Console.WriteLine(operacoes[2]);
        Console.WriteLine(operacoes[3]);
        Console.WriteLine(operacoes[4]);

        Console.WriteLine("Escreva a operacao que voce quer fazer");
        string operacaoEscolhida = Console.ReadLine();

        Console.WriteLine("Digite os numeros que voce quer calcular:");
        string numero1 = Console.ReadLine();
        string numero2 = Console.ReadLine();

        int numero1_ = int.Parse(numero1); 
        int numero2_ = int.Parse(numero2);

        if (operacaoEscolhida == operacoes[0]) {
            Console.WriteLine($"A operacao escolhida foi soma e seu resultado é: {Somar(numero1_, numero2_)}");  
        } else if (operacaoEscolhida == operacoes[1]) {
            Console.WriteLine($"A operacao escolhida foi subtracao e seu resultado é: {Subtrair(numero1_, numero2_)}");
        } else if (operacaoEscolhida == operacoes[2]) {
            Console.WriteLine($"A operacao escolhida foi multiplicacao e seu resultado é: {Multiplicar(numero1_, numero2_)}");
        } else if (operacaoEscolhida == operacoes[3]) {
            Console.WriteLine($"A operacao escolhida foi divisao e seu resultado é: {Dividir(numero1_, numero2_)}");
        } else {
            Console.WriteLine("Voce está saindo do sistema");
        }

    }
    public static int Somar(int numero1_, int numero2_){
        int resultadoDaSoma = numero1_ + numero2_;
        return resultadoDaSoma;
    }
    public static int Subtrair(int numero1_, int numero2_){
        int resultadoDaSubtracao = numero1_ - numero2_;
        return resultadoDaSubtracao;
    }
    public static int Multiplicar(int numero1_, int numero2_){
        int resultadoDaMultiplicacao = numero1_ * numero2_;
        return resultadoDaMultiplicacao;
    }
    public static int Dividir(int numero1_, int numero2_){
        int resultadoDaDivisao = numero1_ / numero2_;
        return resultadoDaDivisao;
    }
}
