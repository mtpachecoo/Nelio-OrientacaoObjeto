public class Pessoa
{
    public string Nome { get; init; }
    public string Email { get; init; }
    public int Quarto { get; private set; }
    public Pessoa(string nome, string email, int quarto)
    {
        if(email.Contains("@"))
        {
            throw new ArgumentException("Email incorreto");
        }
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException ("Nome não deve ser vazio");
        }
        if (quarto < 0 && quarto > 9)
        {
            throw new ArgumentException ("Quarto disponivel entre 0 e 9! ");
        }
        Nome = nome;
        Quarto = quarto;
        Email = email;
    }

    public void AlterarQuarto(int novoNumero, bool quartoVazio)
    {
        if (!quartoVazio)
            throw new ArgumentException ("Quarto reservado!");
        
        Quarto = novoNumero;
        
    }

    public override string ToString()
    {
        return $"{Quarto}: {Nome}, {Email}";
    }
}