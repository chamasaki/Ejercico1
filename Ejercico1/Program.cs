using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Que se necesita para crear un objeto del tipo Alumno?
            //rta: Creación de Clase Alumno

            //2- Una vez creado la clase Alumno, se debe instanciar
            string nombreAlumnoUno = Console.ReadLine();

            Alumno alumnoUno = new Alumno(nombreAlumnoUno);

            //se llam a las propiedades de Nombre y Nota
            //y se SETEA un Valor (SET)

            alumnoUno.Nota = Convert.ToInt32(Console.ReadLine());

            string loqueseimprime = alumnoUno.ObtenerNombreYNotaDeAlumno();
            Console.WriteLine(loqueseimprime);

            Console.ReadKey();
        }
    }
}
