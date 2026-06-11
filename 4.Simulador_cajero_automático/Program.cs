/*Ejercicio 4. Simulador de cajero automático (Fondo suficiente)
Un cliente solicita retirar una cantidad específica de dinero en efectivo de su cuenta bancaria.
El sistema evalúa el monto solicitado contra el saldo disponible: si el saldo es igual o mayor a 
la solicitud, se autoriza la transacción y se descuenta el dinero; si no, se cancela la operación por "Fondos Insuficientes".*/

using System;

class Cajero
{
    static void Main()
    {
        Console.Write("Ingrese su saldo disponible:");
        double saldo = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el monto a retirar:");
        double retiro = double.Parse(Console.ReadLine());

        if (saldo >= retiro)
        {
            saldo -= retiro;
            Console.WriteLine("Transacción autorizada.");
            Console.WriteLine($"Nuevo saldo:${saldo:F2}");
        }
        else
        {
            Console.WriteLine("Fondos Insuficientes :(");
        }
    }
}
