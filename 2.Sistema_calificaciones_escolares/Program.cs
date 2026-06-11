/*Ejercicio 2. Sistema de calificaciones escolares
Una plataforma educativa evalúa el desempeño de los alumnos mediante una nota numérica. 
Si la calificación obtenida es igual o mayor a 60, el programa declara al estudiante como "Aprobado"; 
De lo contrario, el estado del alumno se reporta como "Reprobado".*/
using System;

class Calificaciones
{
    static void Main()
    {
        Console.Write("Ingrese la calificación (0-100):");
        double nota = double.Parse(Console.ReadLine());

        if (nota >= 60)
        {
            Console.WriteLine("Estado: *Aprobado*");
        }
        else
        {
            Console.WriteLine("Estado: Reprobado:(");
        }
    }
}

