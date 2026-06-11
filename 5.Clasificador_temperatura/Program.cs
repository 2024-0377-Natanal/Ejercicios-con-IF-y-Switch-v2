/*Ejercicio 5. Clasificador de temperatura ambiental
Un dispositivo meteorológico toma la temperatura actual en grados Celsius. 
Si la temperatura es estrictamente menor a 15°C, el sistema activa la alerta de "Clima Frío"; 
si la temperatura está entre 15°C y 28°C inclusive, muestra "Clima Templado"; y si supera los 28°C, 
activa la alerta de "Clima Cálido".*/

using System;

class Temperatura
{
    static void Main()
    {
        Console.Write("Ingrese la temperatura en °C:");
        double temp = double.Parse(Console.ReadLine());

        if (temp < 15)
        {
            Console.WriteLine("!Alerta! Clima Frío");
        }
        else if (temp >= 15 && temp <= 28)
        {
            Console.WriteLine("Clima Templado");
        }
        else
        {
            Console.WriteLine("!Alerta! Clima Cálido");
        }
    }
}
