string opcaoDesejada;

do
{
    ExibirMenu();
    Console.Write("\nDigite a opção desejada.: ");
    opcaoDesejada = Console.ReadLine()!;
    Console.WriteLine();

    switch (opcaoDesejada)
    {
        case "1":
            op1();
            break;

        case "2":
            op2();
            break;

        case "3":
            op3();
            break;

        case "4":
            op4();
            break;

        case "5":
            op5();
            break;

        case "6":
            op6();
            break;

        case "7":
            op7();
            break;

        case "0":
            Console.WriteLine("\nObrigado por utilizar o programa!");
            Environment.Exit(-1);
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nOpção inválida!");
            Console.ReadKey();
            Console.Clear();
            ExibirMenu();
            break;
    }
}

while (opcaoDesejada != "0");


static void op1()

{
    double soma, somaA, somaB;

    Console.WriteLine("\n-----Soma-----");
    Console.WriteLine("\nDigite os valores para A + B: ");

    Console.Write("A = ");
    somaA = Convert.ToDouble(Console.ReadLine()!);

    Console.Write("B = ");
    somaB = Convert.ToDouble(Console.ReadLine()!);

    soma = somaA + somaB;

    Console.WriteLine($"\nResultado da soma: {somaA} + {somaB} = {soma}");
    Console.WriteLine("Digite uma tecla para continuar");
    Console.ReadKey();
}

static void op2()

{
    double subtracao, subtracaoA, subtracaoB;

    Console.WriteLine("\n-----Subtração-----");

    Console.WriteLine("Digite os valores para A - B: ");

    Console.Write("A = ");
    subtracaoA = Convert.ToDouble(Console.ReadLine()!);

    Console.Write("B = ");
    subtracaoB = Convert.ToDouble(Console.ReadLine()!);

    subtracao = subtracaoA - subtracaoB;

    Console.WriteLine($"Resultado da subtração: {subtracaoA} - {subtracaoB} = {subtracao}");
    Console.WriteLine("Digite uma tecla para continuar");
    Console.ReadKey();
}

static void op3()

{
    double multiplicacao, multiplicacaoA, multiplicacaoB;

    Console.WriteLine("-----Multiplicação-----");

    Console.WriteLine("Digite os valores para A x B: ");

    Console.Write("A = ");
    multiplicacaoA = Convert.ToDouble(Console.ReadLine()!);

    Console.Write("B = ");
    multiplicacaoB = Convert.ToDouble(Console.ReadLine()!);

    multiplicacao = multiplicacaoA * multiplicacaoB;

    Console.WriteLine($"Resultado da multiplicacao: {multiplicacaoA} x {multiplicacaoB} = {multiplicacao}");

    Console.WriteLine("Digite uma tecla para continuar");
    Console.ReadKey();
}

static void op4()
{
    double divisao, divisaoA, divisaoB;

    Console.WriteLine("\n-----Divisão-----");

    Console.WriteLine("Digite os valores para A / B: ");

    Console.Write("A = ");
    divisaoA = Convert.ToDouble(Console.ReadLine()!);

    Console.Write("B = ");
    divisaoB = Convert.ToDouble(Console.ReadLine()!);

    divisao = divisaoA / divisaoB;

    Console.WriteLine($"Resultado da divisão: {divisaoA} / {divisaoB} = {divisao}");

    Console.WriteLine("Digite uma tecla para continuar");
    Console.ReadKey();
}

static void op5()
{
    double base_, expoente, potencia;

    Console.WriteLine("\n-----Exponenciação-----");

    Console.WriteLine("\nDigite os valores para base e expoente: ");

    Console.Write("Base = ");
    base_ = Convert.ToDouble(Console.ReadLine()!);

    Console.Write("Expoente = ");
    expoente = Convert.ToDouble(Console.ReadLine()!);

    potencia = Math.Pow(base_, expoente);

    Console.WriteLine($"\nResultado: {potencia}");

    Console.WriteLine("Digite uma tecla para continuar");
    Console.ReadKey();
}

static void op6()
{
    double numero, radiciacao;

    Console.WriteLine("\n-----Radiciação-----");

    Console.Write("\nDigite um número:");
    numero = Convert.ToDouble(Console.ReadLine()!);

    radiciacao = Math.Sqrt(numero);

    Console.WriteLine($"\nRadiciação de {numero} é: {radiciacao:N2}");

    Console.WriteLine("Digite uma tecla para continuar");
    Console.ReadKey();
}

static void op7()
{
    double a, b, c, delta, x1, x2;

    Console.WriteLine("\n----- Bhaskara -----");

    Console.Write("(a): ");
    a = Convert.ToDouble(Console.ReadLine());

    Console.Write("(b): ");
    b = Convert.ToDouble(Console.ReadLine());

    Console.Write("(c): ");
    c = Convert.ToDouble(Console.ReadLine());

    if (a == 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Não é uma equação de segundo grau!");
    }

    else
    {
        delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Como delta = {delta:N2}, a equação não possui raízes reais!");
        }

        else
        {
            x1 = (-b + Math.Sqrt(delta) / (2 * a));
            x2 = (-b - Math.Sqrt(delta) / (2 * a));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"x1 = {x1:N2}, x2 = {x2:N2}");
        }
    }

    Console.ResetColor();

    Console.WriteLine("Digite uma tecla para continuar");
    Console.ReadKey();
}

static void ExibirMenu()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("---------CALCULADORA---------");
    Console.ResetColor();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("[1]- Soma ");
    Console.WriteLine("[2]- Subtração ");
    Console.WriteLine("[3]- Multiplicação ");
    Console.WriteLine("[4]- Divisão ");
    Console.WriteLine("[5]- Exponenciação ");
    Console.WriteLine("[6]- Radiciação ");
    Console.WriteLine("[7]- Bhaskara ");
    Console.WriteLine("[0]- Sair");
    Console.ResetColor();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.ResetColor();
}