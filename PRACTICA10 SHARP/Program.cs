using System;

class Program
{
    static int SumaIterativa(int n)
    {
        int suma = 0;

        while (n > 9)
        {
            suma += n % 10;
            n /= 10;
        }

        return suma + n;
    }

    static void Main()
    {
        int numero = 12345;
        int resultado = SumaIterativa(numero);
        Console.WriteLine($"La suma de los dígitos de {numero} es {resultado}");
    }
}