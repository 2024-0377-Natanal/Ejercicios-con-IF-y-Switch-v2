/*Ejercicio 7. Calculadora básica de operaciones
Un usuario ingresa dos números y un símbolo de operación matemática ( +, -, *, /). 
El programa evalúa el símbolo seleccionado para ejecutar exclusivamente la operación 
correspondiente entre ambos números y muestra el resultado en pantalla.*/

using System;

class Calculadora
{
    static void Main()
    {
        Console.Write("Ingrese el primer numero:");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Ingrese uno de estos operador (+, -, *, /):");
        string op = Console.ReadLine();

        Console.Write("Ingrese el segundo numero:");
        double b = double.Parse(Console.ReadLine());

        switch (op)
        {
            case "+":
                Console.WriteLine($"Resultado:{a + b}");
                break;
            case "-":
                Console.WriteLine($"Resultado:{a - b}");
                break;
            case "*":
                Console.WriteLine($"Resultado:{a * b}");
                break;
            case "/":
                if (b == 0)
                    Console.WriteLine("!Error! No se puede dividir entre cero.");
                else
                    Console.WriteLine($"Resultado:{a / b}");
                break;
            default:
                Console.WriteLine("!Operador no válido!");
                break;
        }
    }
}