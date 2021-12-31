using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp2
{
    public partial class Form1 : Form
    {

        public class Persona : Cliente
        {

            public string Nombre { get; set; }
            public string Apellido { get; set; }

            public Persona(string pLegajo, string pNombre, string pApellido)
            {

                Legajo = pLegajo;
                Nombre = pNombre;
                Apellido = pApellido;
            }
        }

    }

}
