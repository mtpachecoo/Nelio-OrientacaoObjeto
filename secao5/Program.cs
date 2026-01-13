
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite o numero da conta:");
        int numeroConta = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre o titular da conta:");
        string nomeTitular = Console.ReadLine();

        ContaBancaria contaNova = new ContaBancaria(numeroConta, nomeTitular);

        Console.WriteLine("Haverá deposito inicial S/N?");
        // Lendo a resposta do usuario
        char value = char.Parse(Console.ReadLine());
        char.ToLower(value);
        if (value == 's' )
        {
            Console.WriteLine("Digite o valor do deposito inicial:");
            decimal depositoInicial = decimal.Parse(Console.ReadLine());
            contaNova.Deposito(depositoInicial);
            System.Console.WriteLine("Deposito realizado com sucesso!");
        }
        else
        {
            System.Console.WriteLine("Conta criada sem deposito inicial.");
        }

        System.Console.WriteLine("Dados da conta:");
        System.Console.WriteLine("Conta " + numeroConta + ", Titular: " + nomeTitular + ", Saldo: R$ " + contaNova.Saldo.ToString("F2"));

    
        System.Console.WriteLine("Digite um valor para deposito:");
        decimal depositoAtual = decimal.Parse(Console.ReadLine());
        contaNova.Deposito(depositoAtual);
        System.Console.WriteLine("Dados da conta atualizado:");
        System.Console.WriteLine("Conta " + numeroConta + ", Titular: " + nomeTitular + ", Saldo: R$ " + contaNova.Saldo.ToString("F2"));
        
        
        System.Console.WriteLine("Digite um valor para sacar:");
        decimal saqueAtual = decimal.Parse(Console.ReadLine());
        contaNova.Saque(saqueAtual);
        System.Console.WriteLine("Conta " + numeroConta + ", Titular: " + nomeTitular + ", Saldo: R$ " + contaNova.Saldo.ToString("F2"));




        
        
    }
}