using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico1
{
    //Si no se le mete modificador de visibilidad es PRIVADO
    //Ejemplo: class Alumno -> sin Private o Public adelante
    public class Alumno
    {
        //1- para crear objetos en C# se tiene que hacer la clase pública
        //2- Crear el Constructor para la clase y siempre es público

        //Atributos
        //Modificador de visibilidad + tipo de dato + nombre
        private string _nombre;
        private int _nota;

        //Propiedades
        //Nos van a servir para acceder a los atributos privados
        //Propiedad generada por primera vez -> public int MyProperty { get; set; }
        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                //Nombre del atributo privado al que se hace referencia
                _nombre = value;
            }
        }

        public int Nota
        {
            get
            {
                return _nota;
            }

            set
            {
                _nota = value;
            }
        }

        //Constructor
        //Va a darle valores a los atributos privados
        public Alumno(string _nombre)
        {
            //Al atributo le doy el valor del parametro
            this._nombre = _nombre;
        }

        //Metodos
        //Se crea metodo que devuelve el nombre y la nota del alumno
        //modificador de visibilidad + tipo dato + nombre()
        public string ObtenerNombreYNotaDeAlumno()
        {
            return $"El alumno es: {_nombre}, y su nota es: {_nota}";
        }
    }
}
