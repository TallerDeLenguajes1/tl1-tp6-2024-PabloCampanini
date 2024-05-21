// See https://aka.ms/new-console-template for more information
/*

Console.WriteLine("Hello, World!");

int a;

int b;

a=10;

b=a;

Console.WriteLine("valor de a:"+a);

Console.WriteLine("valor de a:"+b);

*/




// *------ EJERCICIO 1 ------*
/*

Console.WriteLine("Ingrese un numero: ");
string cadena = Console.ReadLine();

int numero;

if (int.TryParse(cadena, out numero))
{
    if (numero > 0)
    {
        char[] arreglo = cadena.ToCharArray();

        Array.Reverse(arreglo);

        Console.WriteLine($"Numero ingresado = {numero}\nNumero invertido = {new string(arreglo)}");
    }
}

*/




// *------ EJERCICIO 2 ------*


