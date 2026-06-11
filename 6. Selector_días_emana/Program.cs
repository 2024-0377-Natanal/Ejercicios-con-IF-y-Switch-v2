/*Ejercicio 6. Selector de días de la semana
Un calendario digital recibe un número entero del 1 al 7 introducido por el usuario. 
El programa traduce ese número al nombre del día correspondiente (donde 1 es Lunes y 7 es Domingo). 
Si el usuario ingresa un número fuera de ese rango, el sistema muestra un mensaje indicando que el día es inválido.*/

using System;

class DiasSemana
{
    static void Main()
    {
        Console.Write("Ingrese un número del 1 al 7:");
        int dia = int.Parse(Console.ReadLine());

        switch (dia)
        {
            case 1: Console.WriteLine("!Lunes!"); break;
            case 2: Console.WriteLine("!Martes!"); break;
            case 3: Console.WriteLine("!Miércoles!"); break;
            case 4: Console.WriteLine("!Jueves!"); break;
            case 5: Console.WriteLine("!Viernes!"); break;
            case 6: Console.WriteLine("!Sábado!"); break;
            case 7: Console.WriteLine("!Domingo!"); break;
            default: Console.WriteLine("Día inválido"); break;
        }
    }
}