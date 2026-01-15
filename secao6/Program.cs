
System.Console.WriteLine("Qual será o tamanho da lista?");
int n = int.Parse(Console.ReadLine());
double[] vect = new double[n];

System.Console.WriteLine("Digite os valores da lista");
for(int i = 0; i < n; i++)
{
    vect[i] = double.Parse(Console.ReadLine());
}

foreach (double list in vect)
{
    System.Console.WriteLine(list);
}

