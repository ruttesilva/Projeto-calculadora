string opcaoDesejada;

Console.WriteLine("--- Calculadora ---\n");

Console.WriteLine("(+) Soma");
Console.WriteLine("(-) Subtração");
Console.WriteLine("(x) Multiplicação");
Console.WriteLine("(/) Divisão");
Console.WriteLine("(e) Exponenciação");
Console.WriteLine("(R) Radiciação");
Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
        double soma, somaA, somaB;

        Console.WriteLine("Você selecionou soma");

        Console.WriteLine("Digite os valores para A + B: ");

        Console.Write("A = ");
        somaA = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("B = ");
        somaB = Convert.ToDouble(Console.ReadLine()!);

        soma = somaA + somaB;

        Console.WriteLine($"Resultado da soma: {somaA} + {somaB} = {soma}");

        break;


    case "-":
        double subtracao, subtracaoA, subtracaoB;

        Console.WriteLine("Você selecionou subtração");

        Console.WriteLine("Digite os valores para A - B: ");

        Console.Write("A = ");
        subtracaoA = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("B = ");
        subtracaoB = Convert.ToDouble(Console.ReadLine()!);

        subtracao = subtracaoA - subtracaoB;

        Console.WriteLine($"Resultado da subtração: {subtracaoA} - {subtracaoB} = {subtracao}");

        break;

    case "x":
        double multiplicacao, multiplicacaoA, multiplicacaoB;

        Console.WriteLine("Você selecionou multiplicação");

        Console.WriteLine("Digite os valores para A x B: ");

        Console.Write("A = ");
        multiplicacaoA = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("B = ");
        multiplicacaoB = Convert.ToDouble(Console.ReadLine()!);

        multiplicacao = multiplicacaoA * multiplicacaoB;

        Console.WriteLine($"Resultado da multiplicacao: {multiplicacaoA} x {multiplicacaoB} = {multiplicacao}");

        break;

    case "/":
        double divisao, divisaoA, divisaoB;

        Console.WriteLine("Você selecionou divisão");

        Console.WriteLine("Digite os valores para A / B: ");

        Console.Write("A = ");
        divisaoA = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("B = ");
        divisaoB = Convert.ToDouble(Console.ReadLine()!);

        divisao = divisaoA / divisaoB;

        Console.WriteLine($"Resultado da divisão: {divisaoA} / {divisaoB} = {divisao}");

        break;

    case "e":
        double base_, expoente, potencia;

        Console.WriteLine("Você selecionou exponenciação");

        Console.WriteLine("Digite os valores para base e expoente: ");

        Console.Write("Base = ");
        base_ = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("Expoente = ");
        expoente = Convert.ToDouble(Console.ReadLine()!);

        potencia = Math.Pow(base_, expoente);
        Console.WriteLine($"A exponenciação de {base_} e {expoente} é {potencia}");

        break;

    default:

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Opção inválida.");

        break;
}

Console.WriteLine("\nObrigado por utilizar o programa.");
Console.ResetColor();