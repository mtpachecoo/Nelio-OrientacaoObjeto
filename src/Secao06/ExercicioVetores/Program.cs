using System;
using System.Net.Quic;


internal class Program
{
    private static void Main(string[] args)
    {

        Pessoa[] quartos = new Pessoa[10];

        Console.Write("How many rooms will be rented? ");
        int numeroEstudantes = int.Parse(Console.ReadLine());

        for (int i = 0; i < numeroEstudantes; i++)
        {
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Room: ");
            int quarto = int.Parse(Console.ReadLine());
            Pessoa estudante = new Pessoa (nome, email, quarto);
            quartos[quarto] = estudante;
        }

        System.Console.WriteLine("Busy rooms");
        for (int i = 0; i < quartos.Length; i++)
        {
            if (quartos[i] != null)
            System.Console.WriteLine(quartos[i]);
        } 
    }
}