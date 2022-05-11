using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Ingresar_Autores
{
    public class Autor
    {
        private string nombre;
        private string apellido;
        private string nacionalidad;
        private DateOnly fechaDeNacimiento;

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime FechaDeNacimiento { get; set; }


    }
}
