int n = int.Parse(Console.ReadLine());

Product[] produtos = new Product[n];

for(int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double price = double.Parse(Console.ReadLine());
    produtos[i] = new Product(name, price);
}
double sum = 0.0;
for(int i = 0; i < n; i++)
{
    sum += produtos[i].Price;
}
double media = sum / n;

System.Console.WriteLine(string.Join(" ", produtos));
System.Console.WriteLine("Average Price = " + media.ToString("F2"));