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

        public class Empresa : Cliente
        {

            public string Razon_Social { get; set; }

            public Empresa(string pLegajo, string pRazon_Social)
            {

                Legajo = pLegajo;
                Razon_Social = pRazon_Social;

            }
        }
    }
}
