﻿// See https://aka.ms/new-console-template for more information
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




// *------ EJERCICIO 2 y 3 ------*
/*

Console.WriteLine("\n\n\t\t*----- Calculadora -----*");

int seguir = 1;

while (seguir == 1)
{
    Console.WriteLine("\nOperaciones:\n\t1. Suma\n\t2. Resta\n\t3. Multiplicacion\n\t4. Division");

    Console.WriteLine("\n\t5. El valor absoluto de un numero\n\t6. El cuadrado\n\t7. La raiz cuadrada\n\t8. El seno\n\t9. El Coseno\n\t10. La parte entera de un tipo float");

    Console.WriteLine("\n\nIngrese el numero de la operacion que quiere realizar");

    string cadena = Console.ReadLine();

    OperacionElegida(cadena);

    Console.WriteLine("\n\n*----- Verificacion de un maximo y un minimo -----*");
    DeterminacionMaximoMinimo();

    seguir = ContinuarCargandoDatos(seguir);
}


static float OperacionesDoblesCalculadora(int operacion, float num1, float num2)
{
    float resultado = 0;

    switch (operacion)
    {
        case 1:
            resultado = num1 + num2;
            Console.WriteLine($"\n\t\t*----- Resultado = {resultado} -----*\n");
            break;
        case 2:
            resultado = num1 - num2;
            Console.WriteLine($"\n\t\t*----- Resultado = {resultado} -----*\n");
            break;
        case 3:
            resultado = num1 * num2;
            Console.WriteLine($"\n\t\t*----- Resultado = {resultado} -----*\n");
            break;
        case 4:
            if (num2 != 0)
            {
                resultado = num1 / num2;
                Console.WriteLine($"\n\t\t*----- Resultado = {resultado} -----*\n");
            }
            else
            {
                Console.WriteLine("El 2do numero debe ser distinto de 0 para la division");
            }
            break;
        default:
            Console.WriteLine("Error");
            break;
    }

    return resultado;
}

static float OperacionesIndivudualesCalculadora(int operacion, float num)
{
    float resultado = 0;

    switch (operacion)
    {
        case 5:
            resultado = Math.Abs(num);
            Console.WriteLine($"\n\t\t*----- Resultado = {resultado} -----*\n");
            break;
        case 6:
            resultado = (float)Math.Pow(num, 2);
            Console.WriteLine($"\n\t\t*----- Resultado = {resultado} -----*\n");
            break;
        case 7:
            resultado = (float)Math.Pow(num, 0.5);
            Console.WriteLine($"\n\t\t*----- Resultado = {resultado} -----*\n");
            break;
        case 8:
            resultado = (float)Math.Sin(num);
            Console.WriteLine($"\n\t\t*----- Resultado = {resultado} -----*\n");
            break;
        case 9:
            resultado = (float)Math.Cos(num);
            Console.WriteLine($"\n\t\t*----- Resultado = {resultado} -----*\n");
            break;
        case 10:
            int resultadoEntero = (int)Math.Truncate(num);
            Console.WriteLine($"\n\t\t*----- Resultado = {(resultadoEntero)} -----*\n");
            break;
        default:
            Console.WriteLine("Error");
            break;
    }

    return resultado;
}

static void ControlNum2(int operacion, string operador, float num1)
{
    if (float.TryParse(operador, out float num2))
    {
        float resultado = OperacionesDoblesCalculadora(operacion, num1, num2);
    }
    else
    {
        Console.WriteLine("*----- Debe ingresar un numero como dato -----*");
    }
}

static string ControlNum1(int operacion, string operador)
{
    if (float.TryParse(operador, out float num1))
    {
        Console.WriteLine("\nIngrese el 2do numero:");

        operador = Console.ReadLine();
        ControlNum2(operacion, operador, num1);
    }
    else
    {
        Console.WriteLine("*----- Debe ingresar un numero como dato -----*");
    }

    return operador;
}

static string ControlNumOperacionesIndividuales(int operacion, string operador)
{
    if (float.TryParse(operador, out float num))
    {
        float resultado = OperacionesIndivudualesCalculadora(operacion, num);
    }
    else
    {
        Console.WriteLine("*----- Debe ingresar un numero como dato -----*");
    }

    return operador;
}

static void OperacionElegida(string cadena)
{
    if (int.TryParse(cadena, out int operacion))
    {
        string operador;

        if (operacion < 5)
        {
            Console.WriteLine("\n\t\t*----- Tenga en cuanta que se usa como separador decimal ',' y no '.' -----*");
            Console.WriteLine("\nIngrese el 1er numero: ");

            operador = Console.ReadLine();
            operador = ControlNum1(operacion, operador);
        }
        else
        {
            Console.WriteLine("\n\t\t*----- Tenga en cuanta que se usa como separador decimal ',' y no '.' -----*");
            Console.WriteLine("\nIngrese un numero: ");

            operador = Console.ReadLine();
            operador = ControlNumOperacionesIndividuales(operacion, operador);
        }

    }
    else
    {
        Console.WriteLine("*----- Ingrese un dato valido -----*");
    }
}

static int ContinuarCargandoDatos(int seguir)
{
    Console.WriteLine("Quiere realizar mas calculos? (Ingrese Si o No)");

    string pregunta = Console.ReadLine();

    if (pregunta == "no" || pregunta == "No" || pregunta == "NO" || pregunta == "nO")
    {
        seguir = 0;
    }

    return seguir;
}

static void DeterminacionMaximoMinimo()
{
    Console.WriteLine("\nIngrese el 1er numero: ");

    string operador = Console.ReadLine();

    if (float.TryParse(operador, out float numA))
    {
        Console.WriteLine("\nIngrese el 2do numero:");

        operador = Console.ReadLine();

        if (float.TryParse(operador, out float numB))
        {
            if (numA > numB)
            {
                Console.WriteLine($"\n\tMaximo: {numA}\n\n\tMinimo: {numB}");
            }
            else
            {
                Console.WriteLine($"\n\tMaximo: {numB}\n\n\tMinimo: {numA}");
            }
        }
        else
        {
            Console.WriteLine("*----- Debe ingresar un numero como dato -----*");
        }
    }
    else
    {
        Console.WriteLine("*----- Debe ingresar un numero como dato -----*");
    }
}

*/




// *------ EJERCICIO 4 ------*


Console.WriteLine("\n\n\t\t*----- Manejo del tipo String -----*");

Console.WriteLine("\nIngrese una oracion:");

string Oracion1 = Console.ReadLine();

int longitud = Oracion1.Length;

Console.WriteLine($"\n\n\t*----- Longitud de la frase ingresada: {longitud} -----*");

Console.WriteLine("\nIngrese una oracion que se concatenara con la primera:");

string Oracion2 = Console.ReadLine();

string Concatenada = String.Concat(Oracion1, " ", Oracion2);

Console.WriteLine("\n\n\t*----- Las oraciones concatenadas -----*");

Console.WriteLine($"\n{Concatenada}");

string PorcionOracion = Concatenada.Substring(0, 3);

Console.WriteLine($"\n\nUna porcion de la oracion es: {PorcionOracion}");

Console.WriteLine("\n\n\t\t*----- Calculadora -----*");

int seguir = 1;

while (seguir == 1)
{
    Console.WriteLine("\nOperaciones:\n\t1. Suma\n\t2. Resta\n\t3. Multiplicacion\n\t4. Division");

    Console.WriteLine("\n\nIngrese el numero de la operacion que quiere realizar");

    string cadena = Console.ReadLine();

    OperacionElegida(cadena);

    seguir = ContinuarCargandoDatos(seguir);
}


static float OperacionesDoblesCalculadora(int operacion, float num1, float num2)
{
    float resultado = 0;

    switch (operacion)
    {
        case 1:
            resultado = num1 + num2;
            Console.WriteLine($"\n\t\t");
            Console.WriteLine(@$"*----- La suma de ""{num1.ToString()}"" y de ""{num2.ToString()}"" es igual a: {resultado.ToString()} -----*");
            break;
        case 2:
            resultado = num1 - num2;
            Console.WriteLine($"\n\t\t*----- La resta de \"{num1}\" y de \"{num2}\" es igual a: {resultado} -----*\n");
            break;
        case 3:
            resultado = num1 * num2;
            Console.WriteLine($"\n\t\t*----- El producto entre \"{num1}\" y \"{num2}\" es igual a: {resultado} -----*\n");
            break;
        case 4:
            if (num2 != 0)
            {
                resultado = num1 / num2;
                Console.WriteLine($"\n\t\t*----- La division de \"{num1}\" en \"{num2}\" es igual a: {resultado} -----*\n");
            }
            else
            {
                Console.WriteLine("El 2do numero debe ser distinto de 0 para la division");
            }
            break;
        default:
            Console.WriteLine("Error");
            break;
    }

    return resultado;
}

static void ControlNum2(int operacion, string operador, float num1)
{
    if (float.TryParse(operador, out float num2))
    {
        float resultado = OperacionesDoblesCalculadora(operacion, num1, num2);
    }
    else
    {
        Console.WriteLine("*----- Debe ingresar un numero como dato -----*");
    }
}

static string ControlNum1(int operacion, string operador)
{
    if (float.TryParse(operador, out float num1))
    {
        Console.WriteLine("\nIngrese el 2do numero:");

        operador = Console.ReadLine();
        ControlNum2(operacion, operador, num1);
    }
    else
    {
        Console.WriteLine("*----- Debe ingresar un numero como dato -----*");
    }

    return operador;
}

static void OperacionElegida(string cadena)
{
    if (int.TryParse(cadena, out int operacion))
    {
        string operador;

        if (operacion < 5)
        {
            Console.WriteLine("\n\t\t*----- Tenga en cuanta que se usa como separador decimal ',' y no '.' -----*");
            Console.WriteLine("\nIngrese el 1er numero: ");

            operador = Console.ReadLine();
            operador = ControlNum1(operacion, operador);
        }
    }
    else
    {
        Console.WriteLine("*----- Ingrese un dato valido -----*");
    }
}

static int ContinuarCargandoDatos(int seguir)
{
    Console.WriteLine("Quiere realizar mas calculos? (Ingrese Si o No)");

    string pregunta = Console.ReadLine();

    if (pregunta == "no" || pregunta == "No" || pregunta == "NO" || pregunta == "nO")
    {
        seguir = 0;
    }

    return seguir;
}


Console.WriteLine("\n\nA continuacion se muestra caracter por caracter la cadena concatenada: \n");

foreach (char caracter in Concatenada)
{
    Console.WriteLine(caracter);
}

Console.WriteLine("\n\n*----- Ingrese una palabra que desee verificar si esta en la oracion -----*");

string PalabraVerificar = Console.ReadLine();

string[] OracionEnPalabras = Concatenada.Split(' ');

int Ocurrencias = 0;

for (int i = 0; i < OracionEnPalabras.Length; i++)
{
    if (OracionEnPalabras[i] == PalabraVerificar)
    {
        Ocurrencias = Ocurrencias + 1;
    }
}

if (Ocurrencias == 0)
{
    Console.WriteLine("\n\n\t*----- La palabra ingresada no esta en la oracion -----*");
}
else
{
    Console.WriteLine($"\n\n\t*----- La oracion contiene la palabra {PalabraVerificar} un total de {Ocurrencias} vez/veces -----*");
}

Console.WriteLine("\n\n\t*----- La frase en mayusculas es -----*");

Console.WriteLine($"\n\n{Concatenada.ToUpper()}");

Console.WriteLine("\n\n\t*----- La frase en minusculas es -----*");

Console.WriteLine($"\n\n{Concatenada.ToLower()}");

Console.WriteLine("\n\n\t*----- Ingrese una ecuacion simple que quiera realizar ejemplo: 345+2: ");

string Ecuacion = Console.ReadLine();

// string[] Numero = Ecucacion.Split('+', '-', '*', '/');

string[] Numero = Ecuacion.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);

string Operador = new string(Ecuacion.Except(Numero[0]).Except(Numero[1]).ToArray()).Trim();

if (double.TryParse(Numero[0], out double num1))
{
    if (double.TryParse(Numero[1], out double num2))
    {
        double resultado;
        switch (Operador)
        {
            case "+":
                resultado = num1 + num2;
                Console.WriteLine($"\n\t\t*----- Resultado = {resultado} -----*\n");
                break;
            case "-":
                resultado = num1 - num2;
                Console.WriteLine($"\n\t\t*----- Resultado = {resultado} -----*\n");
                break;
            case "*":
                resultado = num1 * num2;
                Console.WriteLine($"\n\t\t*----- Resultado = {resultado} -----*\n");
                break;
            case "/":
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"\n\t\t*----- Resultado = {resultado} -----*\n");
                }
                else
                {
                    Console.WriteLine("El 2do numero debe ser distinto de 0 para la division");
                }
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
    else
    {
        Console.WriteLine("\n\n\t*----- La ecuacion ingresada no es valida -----*");
    }
}
else
{
    Console.WriteLine("\n\n\t*----- La ecuacion ingresada no es valida -----*");
}