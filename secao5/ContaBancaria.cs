public class ContaBancaria
{
    public string _nome { get; private set; }
    private int NumeroConta;
    public decimal Saldo { get; private set; }
    

    public ContaBancaria(string nome, int numerodaconta, decimal saldo)
    {
        _nome = nome;
        NumeroConta = numerodaconta;
        Saldo = saldo;    
    }
    public ContaBancaria(int numerodaconta, string nome)
    {
        NumeroConta = numerodaconta;
        _nome = nome;
        Saldo = 0;    
    }

    public void AlterarNome(string nomeTitular)
    {
        _nome = nomeTitular;
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
        }
        Saldo -= 5;
        Saldo -= saque;
    }
    public override string ToString()
    {
        return "Conta "
        + NumeroConta
        + ", Titular: "
        + _nome
        + ", Saldo: $ "
        + Saldo.ToString("F2");
    }


}