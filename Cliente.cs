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

        public abstract class Cliente
        {

            public string Legajo { get; set; }

            public List<Contenedor> Lista_contenedores_cliente = new List<Contenedor>();

            public void Agregar_contenedor_a_cliente(Contenedor Con)
            {

                if (!Lista_contenedores_cliente.Contains(Con))

                { this.Lista_contenedores_cliente.Add(Con); }

                else
                { MessageBox.Show("Error: el cliente ya tiene asignado ese contenedor"); }


            }

            public void Desasignar_contenedor_del_cliente(Contenedor C)
            {

                try
                {
                    if (this.Lista_contenedores_cliente.Count > 0)
                        this.Lista_contenedores_cliente.Remove(C);
                }
                catch (Exception) { MessageBox.Show("Error al desasignar contenedor"); }

            }



            public List<Contenedor> Retorna_lista_de_contenedores()
            {
                return this.Lista_contenedores_cliente;
            }

        }

    }

}
