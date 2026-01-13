public class ContaBancaria
{
    public string Titular { get; private set; }
    private int NumeroConta;
    public decimal Saldo { get; private set; }
    

    public ContaBancaria(string nome, int numerodaconta, decimal saldo)
    {
        Titular = nome;
        NumeroConta = numerodaconta;
        Saldo = saldo;    
    }
    public ContaBancaria(int numerodaconta, string nome)
    {
        NumeroConta = numerodaconta;
        Titular = nome;
        Saldo = 0;    
    }

    public void AlterarNome(string nomeTitular)
    {
        Titular = nomeTitular;
    }
    public void Deposito(decimal deposito)
    {
        if (deposito >=1)
        Saldo += deposito;

    }
    public void Saque (decimal saque)
    {
        if (saque > Saldo)
        {
            System.Console.WriteLine("O valor do saque é superior ao valor disponivel");
            return;
        }
        
        Saldo -= 5;
        Saldo -= saque;
    }
    public override string ToString()
    {
        return "Conta "
        + NumeroConta
        + ", Titular: "
        + Titular
        + ", Saldo: $ "
        + Saldo.ToString("F2");
    }


}