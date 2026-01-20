public class Calc
{
    public static int sum(params int [] numeros)
    {
        int calculo = 0;
        for( int i = 0; i < numeros.Length; i++){
        calculo += numeros[i];
        }
        return calculo;
    }
}
