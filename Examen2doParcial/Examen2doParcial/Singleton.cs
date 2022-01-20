using System;
using System.Collections.Generic;
using System.Text;
// Aqui uso el patron de diseño Singleton para mostrar mis datos que va en e lencabezado de un examen
//
namespace Examen2doParcial
{
    public class Singleton
    {
        private static Singleton instance = null; //Privatisamos la clase Singleton con su atributo instance 
        public string mensaje = ""; //Creamos mensaje para mostrar un mensaje en pantalla, en esta caso mis datos, pero por el momento no tiene nada

        protected Singleton() //Creamos este constructor 
        {
            mensaje = "Nombre: Cornejo Macias Luis Fernando"; //Aqui es donde va a mostrar el primer mensaje que se encuentra en PROGRAM.CS
        }

        public static Singleton Instance //El beneficio de que utilicemos la propiedad INSTANCE de SINGLETON es que siempre será la misma
        {                                // y por ende va ser el mismo para todo, pero aún así no es recomendable utilizarlo para todo.
            get //Utilizamos el get para devolver a la clase instanciada 
            {
                if (instance == null)
                    instance = new Singleton();

                return instance; //Aqui devolvemos lo que contiene la propiedad INSTANCE
            }
        }
    }
}
