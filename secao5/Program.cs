
ContaBancaria contaNova;

Console.WriteLine("Digite o numero da conta:");
int numeroConta = int.Parse(Console.ReadLine());

Console.WriteLine("Entre o titular da conta:");
string nomeTitular = Console.ReadLine();

Console.WriteLine("Haverá deposito inicial S/N?");
// Lendo a resposta do usuario
char value = char.Parse(Console.ReadLine());

if (value == 's' || value == 'S' )
{
    Console.WriteLine("Digite o valor do deposito inicial:");
    decimal depositoInicial = decimal.Parse(Console.ReadLine());
    contaNova = new ContaBancaria(nomeTitular, numeroConta, depositoInicial);
    System.Console.WriteLine("Deposito realizado com sucesso!");
}
else
{
    contaNova = new ContaBancaria(numeroConta, nomeTitular);
}

System.Console.WriteLine("Dados da conta:");
Console.WriteLine(contaNova);


System.Console.WriteLine("Digite um valor para deposito:");
decimal depositoAtual = decimal.Parse(Console.ReadLine());
contaNova.Deposito(depositoAtual);
System.Console.WriteLine("Dados da conta atualizado:");
System.Console.WriteLine("Conta " + numeroConta + ", Titular: " + nomeTitular + ", Saldo: R$ " + contaNova.Saldo.ToString("F2"));


System.Console.WriteLine("Digite um valor para sacar:");
decimal saqueAtual = decimal.Parse(Console.ReadLine());
contaNova.Saque(saqueAtual);
System.Console.WriteLine("Conta " + numeroConta + ", Titular: " + nomeTitular + ", Saldo: R$ " + contaNova.Saldo.ToString("F2"));
