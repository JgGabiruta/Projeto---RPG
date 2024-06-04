using System;

class Program
{
    public static void Main(string[] args)
    {
        BoasVindas();
    }

    public static void ficha()
    {
        Console.WriteLine("Ficha");
        Console.WriteLine("Nome:");
        string nome = Console.ReadLine();
        int idade = 0, forca = 0, carisma = 0, vitalidade = 0, inteligencia = 0;

        idade = ObterValorInteiro("Idade:");
        forca = ObterValorInteiro("Pontos de força:");
        carisma = ObterValorInteiro("Pontos de carisma:");
        vitalidade = ObterValorInteiro("Pontos de vitalidade:");
        inteligencia = ObterValorInteiro("Pontos de inteligência:");

        Console.WriteLine($"O nome do seu personagem é: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Pontos de força: {forca}");
        Console.WriteLine($"Pontos de carisma: {carisma}");
        Console.WriteLine($"Pontos de vitalidade: {vitalidade}");
        Console.WriteLine($"Pontos de inteligência: {inteligencia}");
    }

    public static int ObterValorInteiro(string mensagem)
    {
        int valor = 0;
        bool entradaValida = false;
        
        do
        {
            Console.WriteLine(mensagem);
            string entrada = Console.ReadLine();
            if (!string.IsNullOrEmpty(entrada) && int.TryParse(entrada, out valor))
            {
                entradaValida = true;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
            }
        } while (!entradaValida);

        return valor;
    }

    public static void BoasVindas()
    {
        int op = 0; // Variáveis para fazer a validação das entradas do usuário
        bool entradaValida = false;
        Console.WriteLine("Seja muito bem-vindo ao jogo!");

        while (!entradaValida) // Verificando entrada do usuário
        {
            Console.WriteLine("Você já jogou RPG antes? Digite 1 para sim e 2 para não:");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out op))
            {
                entradaValida = true;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite novamente!");
            }
        }

        switch (op)
        {
            case 1:
                Console.WriteLine("Okay, então te encaminharei para a criação de fichas! Seja muito bem-vindo mais uma vez.");
                ficha();
                break;
            case 2:
                Console.WriteLine("Bom, já que não está familiarizado com RPG, irei te explicar o básico agora.");
                Console.WriteLine("Normalmente os RPGs são jogos onde você interpreta um personagem, fazendo escolhas e ações de acordo com aquilo que encaixa para o personagem. Isso significa que antes de começar a jogar você deve criar um personagem. Para isso, você utiliza a ficha de personagem, que é onde coloca todos os pontos de habilidades que seu personagem tem!");
                Console.WriteLine("Agora que já está explicado o básico, irei te encaminhar para a ficha!");
                ficha();
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, digite 1 para sim e 2 para não.");
                BoasVindas();
                break;
        }
    }
}
