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
        public class Vista_Grilla
        {

            List<Vista_Grilla> VG;
            public Vista_Grilla() { VG = new List<Vista_Grilla>(); }

            public Vista_Grilla(string p0, string p1, Cliente p2) { Legajo = p0; Descripcion_del_cliente = p1; _Origen = p2; }
            public string Legajo { get; set; }
            public string Descripcion_del_cliente { get; set; }
            private Cliente _Origen;

            public Cliente RetornaObjetoOrigen()
            {
                return _Origen;
            }
            public List<Vista_Grilla> RetornaVistaCliente(List<Cliente> p0)
            {
                VG.Clear();
                foreach (Cliente e in p0)
                {
                    if (e is Empresa)
                    {
                        VG.Add(new Vista_Grilla(((Empresa)e).Legajo, ((Empresa)e).Razon_Social, e));
                    }
                    else
                    {
                        VG.Add(new Vista_Grilla(((Persona)e).Legajo, ((Persona)e).Apellido + ", " + ((Persona)e).Nombre, e));
                    }
                }
                return VG;
            }
        }

    }

}
