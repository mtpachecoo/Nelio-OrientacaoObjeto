namespace ExercicioMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de linhas e colunas da matriz: ");
            int linhasColunas = int.Parse(Console.ReadLine());
            int[,] matriz = new int[linhasColunas,linhasColunas];
            for(int i = 0; i < linhasColunas; i++)
            {
                System.Console.WriteLine($"Digite os elementos da linha {i+1}");
                string [] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < linhasColunas; j++)
                {
                    matriz[i,j] = int.Parse(values[j]);
                }
            }
            System.Console.WriteLine("Main diagonal:");
            for ( int i = 0; i < linhasColunas; i++)
            {
                System.Console.Write(matriz[i, i] + " ");
            }
        
            int count = 0;
            for(int i = 0; i<linhasColunas; i++)
            {
                for(int j = 0; j < linhasColunas; j++)
                {
                    if (matriz[i,j] < 0) {
                        count ++;
                    }
                }
            }
            System.Console.WriteLine($"Negative numbers {count}");

           
        }
                
    }    
}