/* Ejercicio 8. Conversor de tipo de usuario (Roles de sistema)
Una plataforma web lee el tipo de rol de un usuario mediante una letra clave 
( A para Administrador, E para Editor, A para Autor, L para Lector). 
Dependiendo de la letra, el sistema desplegará en pantalla los permisos específicos asignados a ese rol. 
Si la letra no coincide, se asigna el rol de "Invitado".*/

using System;

class Roles
{
    static void Main()
    {
        Console.Write("Ingrese la letra del rol (A/E/U/L):");
        string input = Console.ReadLine().ToUpper();
        char rol = input[0];

        switch (rol)
        {
            case 'A':
                Console.WriteLine("Rol: !Administrador!");
                Console.WriteLine("Permisos: Acceso total al sistema.");
                break;
            case 'E':
                Console.WriteLine("Rol: !Editor!");
                Console.WriteLine("Permisos: Crear, editar y publicar contenido.");
                break;
            case 'U':
                Console.WriteLine("Rol: !Autor!");
                Console.WriteLine("Permisos: Crear y editar su propio contenido.");
                break;
            case 'L':
                Console.WriteLine("Rol: !Lector!");
                Console.WriteLine("Permisos: Solo lectura.");
                break;
            default:
                Console.WriteLine("Rol: !Invitado!");
                Console.WriteLine("Permisos: Acceso restringido.");
                break;
        }
    }
}
