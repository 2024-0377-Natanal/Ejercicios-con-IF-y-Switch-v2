/* Ejercicio 1. Control de acceso por edad
Un sistema de seguridad automatizado debe validar la edad de un usuario al intentar ingresar a un establecimiento.
Si la persona tiene 18 años o más, el sistema le permite al acceso mostrar un mensaje de bienvenida; 
en caso contrario, deniega la entrada con un mensaje de restricción.*/

using System;

class ControlAcceso
{
    static void Main()
    {
        Console.Write("Ingrese su edad:");
        int edad = int.Parse(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Acceso permitido. ¡Bienvenido!");
        }
        else
        {
            Console.WriteLine("Acceso denegado. Debes ser mayor de edad.");
        }
    }
}