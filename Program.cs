// DECLARAMOS LAS VARIABLES

using System.ComponentModel.Design;

string nombreUsuarioGuardado;
string contraseñaUsuarioGuardado;
string nombreUsuario;
string contraseñaUsuario;
int intentos  = 0;
bool sesionOK  = false;

//PEDIMOS AL USUARIO INGRESAR DATOS - CREAR CUENTA DE USUARIO  

Console.WriteLine("**********Nueva cuenta de Usuario**********");
Console.Write("Ingrese su usuario");
nombreUsuarioGuardado = Console.ReadLine();
Console.Write("Ingrese su contraseña");
contraseñaUsuarioGuardado = Console.ReadLine();
Console.WriteLine("**********¡Cuenta creada correctamente!");

//AHORA VAMOS A SIMULAR EL INICIO DE SESION

do
{
    Console.WriteLine("****Bienvenido al portal Web****");
    Console.WriteLine("ingrese su usuario");
    nombreUsuario = Console.ReadLine();
    Console.Write("Escriba Contraseña");

    if(nombreUsuario.Equals(nombreUsuarioGuardado) && contraseñaUsuario.Equals(contraseñaUsuarioGuardado))
        {
        sesionOK = true;
        Console.WriteLine("¡Sesion iniciadada correctamente!");
    }
    else
    {
        intentos++;
        Console.WriteLine("Usuario y contraseña incorrecto, vuelva a intentarlo");

    }
} while (!sesionOK && intentos < 3);
if (sesionOK)
{
    if(intentos >=3)
    {
        Console.WriteLine("Haz realizado mas de 3 intentos");
    }
}
