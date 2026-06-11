/*Ejercicio 3. Verificador de números pares e impares
Una herramienta de análisis matemático recibe un número entero por parte del usuario. 
El programa determina si dicho número es divisible exactamente entre dos, clasificándolo y 
mostrándolo como "Número Par",o como "Número Impar" si tiene un residuo.*/

using System;

class ParImpar
{
    static void Main()
    {
        Console.Write("Ingrese un número entero:");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} es un Numero Par.");
        }
        else
        {
            Console.WriteLine($"{numero} es un Numero Impar.");
        }
    }
}
