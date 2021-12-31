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

        public class Contenedor
        {

            private Cliente _Cliente { get; set; }
            private decimal V_Peso;
            public string ID { get; set; }

            public decimal Peso
            {
                get { return V_Peso; }
                set
                {
                    V_Peso = value;
                    if (V_Peso > 4000)
                    { Mas4mil(this, new Contenedor.mayor_a_4000EventArgs(this)); }

                }

            }

            public string Descripcion { get; set; }
            public DateTime Fecha_de_Ingreso { get; set; }


            public void Agregar_cliente_a_contenedor(Cliente cli) { _Cliente = cli; }
            public bool Checkear_contenedor_disponible(Contenedor C)
            {
                bool prueba = false;
                if (C._Cliente == null)
                {
                    prueba = true;

                }
                return prueba;
            }
            public void Borrar_cliente_a_contenedor() { this._Cliente = null; }
            public class mayor_a_4000EventArgs : EventArgs
            {

                public Contenedor C { get; set; }
                public mayor_a_4000EventArgs(Contenedor con)
                {
                    C = con;

                }
            }

            public event EventHandler<mayor_a_4000EventArgs> mas4000;
            public void Mas4mil(object sender, mayor_a_4000EventArgs e)
            {

                if (e.C._Cliente == null)
                {
                    MessageBox.Show("Contenedor mayor a 4000, " + "Peso= " + e.C.Peso);
                }
                else
                {
                    if (e.C._Cliente is Empresa)
                    {

                        MessageBox.Show("Contenedor mayor a 4000, " + "Peso = " + e.C.Peso + " ,Razon social: " + ((Empresa)e.C._Cliente).Razon_Social + " ,Legajo:" + ((Empresa)e.C._Cliente).Legajo);
                    }
                    if (e.C._Cliente is Persona)
                    {
                        MessageBox.Show("Contenedor mayor a 4000, " + "Peso = " + e.C.Peso + "," + "Nombre: " + ((Persona)e.C._Cliente).Nombre + "," + " Apellido: " + ((Persona)e.C._Cliente).Apellido + "Legajo: " + ((Persona)e.C._Cliente).Legajo);
                    }
                }

            }
        }

    }
}
