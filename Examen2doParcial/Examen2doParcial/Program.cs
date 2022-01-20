using System;

namespace Examen2doParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance.mensaje); //Aqui es donde va a mostrar Bienvenido Luis Ferna... , utilizando asi la la propiedad Instance, el constructor y la variable creada
            Singleton.Instance.mensaje = "Fecha: 20/01/2022"; //Aqui hacemos uso de la propiedad INSTANCE para mostrar un segundo mensaje y como podemos ver usamos la misma propiedad 
            Console.WriteLine(Singleton.Instance.mensaje);
            Singleton.Instance.mensaje = "Curso: 3ro Nivel C";// Aquí mostramos el 3er mensaje utilizando como los anteriores la propiedad INSTANCE como lo vemos en la linea de codigo inferior.
            Console.WriteLine(Singleton.Instance.mensaje);
        }
    }
}
