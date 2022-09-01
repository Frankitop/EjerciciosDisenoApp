using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPrueba
{
    public class Alumno
    {
        private int numero;
        private string nombres;
        private string apellidos;
        private DateTime fechaNacimiento;

        public int GetNumero()
        {
            return this.numero;
        }

        public void SetNumero(int unNumero)
        {
            this.numero = unNumero;
        }
    }
}
