// See https://aka.ms/new-console-template for more information


    internal class Program
{
    static void Main(string[] args)

    { // valor de entrada que se le solicita al usuario
        int numero;

        Console.WriteLine("Ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());

        // proceso para saber si el numero es par o impar
        if (numero % 2 == 0)
        {
            Console.WriteLine("El numero que ingreso es par");

        }
        else
        {
            Console.WriteLine("El numero ingresado es impar");
        }

        Console.ReadKey();
    }
}

