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

        public class Cont_B : Contenedor
        {

            public Cont_B(string pID, string pDescripcion, decimal pPeso, DateTime pFecha_de_Ingreso)
            {

                ID = pID;
                Descripcion = pDescripcion;
                Peso = ((pPeso * 10) / 100) + pPeso;
                Fecha_de_Ingreso = pFecha_de_Ingreso;
            }

        }

    }
}
