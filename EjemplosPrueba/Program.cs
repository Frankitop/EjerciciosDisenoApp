using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPrueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno unAlumno = new Alumno();
            unAlumno.SetNumero(123456);

            Console.WriteLine(
                string.Format("Se creo el alumno con numero {0}", unAlumno.GetNumero()));
            Console.ReadLine();
        }
    }
}
