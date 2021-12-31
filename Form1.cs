using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Tp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fecha_ingreso_picker.Format = DateTimePickerFormat.Custom;
            fecha_ingreso_picker.CustomFormat = "dd-MM-yyyy";


        }

        Vista_Grilla VG = new Vista_Grilla();



        private void Form1_Load(object sender, EventArgs e)

        {
            combo_tipo_contenedor.SelectedItem = "A";
            combo_tipo_cliente.SelectedItem = "Empresa";
        }

        private List<Cliente> Lista_Clientes = new List<Cliente>();
        private List<Contenedor> Lista_Contenedores = new List<Contenedor>();

        public void Borrar_txt_Cliente()
        {
            legajotxt.Clear(); nombretxt.Clear(); apellidotxt.Clear(); razonsocialtxt.Clear();
        }

        public void Modificar_cliente(string pLegajo, string pNombre, string pApellido)
        {

            foreach (Cliente C in Lista_Clientes)
            {
                if (C.Legajo == pLegajo)
                {
                    ((Persona)C).Nombre = pNombre;
                    ((Persona)C).Apellido = pApellido;

                }
            }

        }

        public void Modificar_cliente(string pLegajo, string pRazon_social)
        {

            foreach (Cliente C in Lista_Clientes)
            {
                if (C.Legajo == pLegajo)
                {
                    ((Empresa)C).Razon_Social = pRazon_social;

                }
            }

        }

        public void Eliminar_contenedor_de_cliente(string pID)    //busca y elimina el contenedor para baja
        {                                                         // de la lista de contendores de los clientes  
            int I, flag = 0;
            foreach (Cliente C in Lista_Clientes)
            {

                for (I = 0; I < C.Lista_contenedores_cliente.Count(); I++)
                {
                    if (C.Lista_contenedores_cliente[I].ID == pID)
                    {
                        C.Lista_contenedores_cliente.RemoveAt(I);
                        flag = 1;
                        break;
                    }

                }
                if (flag == 1)
                { break; }
            }
        }



        public Cliente Retorna_cliente(string pL)
        {
            Cliente clitemp = null;
            foreach (Cliente C in Lista_Clientes)
            {
                if (C.Legajo == pL)
                {
                    clitemp = C;
                    break;
                }

            }
            return clitemp;
        }

        public void Actualizar_Contenedores(List<Contenedor> ListaC)
        {

            grillacontenedores.DataSource = null;
            grillacontenedores.DataSource = ListaC;

        }

        public Contenedor Retornar_contenedor(string pID)
        {
            Contenedor con_temp = null;
            foreach (Contenedor C in Lista_Contenedores)
            {

                if (C.ID == pID)
                {
                    con_temp = C;
                    break;
                }

            }
            return con_temp;
        }

        public void Modificar_Contenedor(string pID, string desc, decimal peso, DateTime fecha)
        {

            foreach (Contenedor C in Lista_Contenedores)
            {
                if (C.ID == pID)
                {
                    C.Descripcion = desc;
                    C.Peso = peso;
                    C.Fecha_de_Ingreso = fecha;
                    break;
                }
            }
        }

        public void Baja_Clientes(string pL)
        {
            foreach (Cliente C in Lista_Clientes)
            {
                if (C.Legajo == pL)
                {
                    Lista_Clientes.Remove(C);
                    break;
                }
            }

        }


        public void Borrar_txt_contenedor() { idtxt.Clear(); descripciontxt.Clear(); pesotxt.Clear(); }
        public void Baja_contenedor(string idbaja)
        {

            foreach (Contenedor C in Lista_Contenedores)
            {
                if (C.ID == idbaja)
                {
                    Lista_Contenedores.Remove(C);
                    break;
                }

            }
        }

        public bool Buscar_Contenedor(string pID)
        {
            bool resultado = false;
            foreach (Contenedor C in Lista_Contenedores)
            {
                if (C.ID == pID)
                {
                    resultado = true;
                    break;
                }

            }
            return resultado;

        }
        public bool Buscar_cliente_ingresado(string pL)
        {
            bool p = false;
            foreach (Cliente Cli in Lista_Clientes)
            {
                if (pL == Cli.Legajo)
                {
                    p = true;
                    break;
                }
            }

            return p;
        }


        private void alta_contenedor_Click(object sender, EventArgs e)
        {

            try
            {
                Regex validar = new Regex("^[0-9]{3}[-][A-Z]{4}$");
                if (validar.IsMatch(idtxt.Text))
                {

                    if (Buscar_Contenedor(idtxt.Text) == true)
                    {
                        MessageBox.Show("Error: ya fue cargado un contenedor con ese ID");
                    }
                    else
                    {
                        if (Convert.ToString(combo_tipo_contenedor.SelectedItem) == "A")
                        {
                            Cont_A A = new Cont_A(idtxt.Text, descripciontxt.Text, Convert.ToDecimal(pesotxt.Text), Convert.ToDateTime(fecha_ingreso_picker.Text));
                            A.mas4000 += A.Mas4mil;
                            Lista_Contenedores.Add(A);
                            Actualizar_Contenedores(Lista_Contenedores);
                            Borrar_txt_contenedor();
                        }
                        else
                        {
                            Cont_B B = new Cont_B(idtxt.Text, descripciontxt.Text, Convert.ToDecimal(pesotxt.Text), Convert.ToDateTime(fecha_ingreso_picker.Text));
                            B.mas4000 += B.Mas4mil;
                            Lista_Contenedores.Add(B);

                            Actualizar_Contenedores(Lista_Contenedores);
                            Borrar_txt_contenedor();
                        }


                    }

                }
                else { MessageBox.Show("Error al ingresar el ID, tiene que tener el formato = 999-AAAA"); }

            }
            catch { MessageBox.Show("Error al dar el alta del contenedor"); }
        }

        private void baja_contenedor_Click(object sender, EventArgs e)
        {
            try
            {
                string B = Convert.ToString(grillacontenedores.Rows[grillacontenedores.CurrentRow.Index].Cells[0].Value);
                Baja_contenedor(B);
                Eliminar_contenedor_de_cliente(B);
                Actualizar_Contenedores(Lista_Contenedores);
                grillaclientes_CellClick(this, null);
            }
            catch { MessageBox.Show("Error: lista de contenedores vacia"); }
        }

        private void combo_tipo_cliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToString(combo_tipo_cliente.SelectedItem) == "Empresa")
            {
                nombretxt.Enabled = false;
                apellidotxt.Enabled = false;
                razonsocialtxt.Enabled = true;
            }
            else
            {
                nombretxt.Enabled = true;
                apellidotxt.Enabled = true;
                razonsocialtxt.Enabled = false;

            }

        }



        private void alta_cliente_Click(object sender, EventArgs e)
        {

            try
            {

                if (Buscar_cliente_ingresado(legajotxt.Text) == false)
                {
                    if (Convert.ToString(combo_tipo_cliente.SelectedItem) == "Empresa")

                    {
                        Empresa E = new Empresa(legajotxt.Text, razonsocialtxt.Text);
                        Lista_Clientes.Add(E);
                        grillaclientes.DataSource = null;
                        grillaclientes.DataSource = VG.RetornaVistaCliente(Lista_Clientes);
                        Borrar_txt_Cliente();
                    }
                    else
                    {
                        Persona C = new Persona(legajotxt.Text, nombretxt.Text, apellidotxt.Text);
                        Lista_Clientes.Add(C);
                        grillaclientes.DataSource = null;
                        grillaclientes.DataSource = VG.RetornaVistaCliente(Lista_Clientes);
                        Borrar_txt_Cliente();
                    }

                }
                else
                { MessageBox.Show("Error: ya fue ingresado un cliente con ese legajo"); }
                Borrar_txt_Cliente();

            }

            catch { }

        }

        private void baja_cliente_Click(object sender, EventArgs e)
        {
            try
            {
                string B = Convert.ToString(grillaclientes.Rows[grillaclientes.CurrentRow.Index].Cells[0].Value);


                Baja_Clientes(B);
                grillaclientes.DataSource = null;
                grillaclientes.DataSource = VG.RetornaVistaCliente(Lista_Clientes);
            }
            catch { MessageBox.Show("Error: nada por borrar"); }
        }

        private void asignar_contenedor_Click(object sender, EventArgs e)
        {
            try
            {
                string indx_cont = Convert.ToString(grillacontenedores.Rows[grillacontenedores.CurrentRow.Index].Cells[0].Value);
                string indx_cli = Convert.ToString(grillaclientes.Rows[grillaclientes.CurrentRow.Index].Cells[0].Value);
                Contenedor Cont = Retornar_contenedor(indx_cont);
                if (Cont.Checkear_contenedor_disponible(Cont) == true)
                {
                    Cliente Cli = Retorna_cliente(indx_cli);


                    Cli.Agregar_contenedor_a_cliente(Cont);
                    Cont.Agregar_cliente_a_contenedor(Cli);
                    grillaclientes_CellClick(this, null);
                }
                else { MessageBox.Show("Contenedor ya asignado"); }
            }
            catch { MessageBox.Show("Error al asignar contenedor"); }
        }

        private void grillaclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                string tempID = Convert.ToString(grillaclientes.Rows[grillaclientes.CurrentRow.Index].Cells[0].Value);
                Cliente Cli = Retorna_cliente(tempID);
                Empresa E;
                Persona P;
                grilla_cont_cliente.DataSource = null;
                grilla_cont_cliente.DataSource = Cli.Retorna_lista_de_contenedores();

                if (Cli is Empresa)
                {
                    E = (Empresa)Cli;

                    razonsocialtxt.Text = E.Razon_Social;
                    combo_tipo_cliente.SelectedItem = "Empresa";
                    nombretxt.Clear();
                    apellidotxt.Clear();
                }
                else
                {
                    P = (Persona)Cli;

                    nombretxt.Text = P.Nombre;
                    apellidotxt.Text = P.Apellido;
                    combo_tipo_cliente.SelectedItem = "Persona Fisica";
                    razonsocialtxt.Clear();
                }

            }
            catch { }

        }

        private void desasignar_contenedor_Click(object sender, EventArgs e)
        {
            try
            {
                string indx_cont = Convert.ToString(grilla_cont_cliente.Rows[grilla_cont_cliente.CurrentRow.Index].Cells[0].Value);
                string indx_cli = Convert.ToString(grillaclientes.Rows[grillaclientes.CurrentRow.Index].Cells[0].Value);
                Cliente Cli;
                Contenedor Con;
                Con = Retornar_contenedor(indx_cont);
                Cli = Retorna_cliente(indx_cli);
                Cli.Desasignar_contenedor_del_cliente(Con);
                Con.Borrar_cliente_a_contenedor();
                grillaclientes_CellClick(this, null);
            }

            catch { MessageBox.Show("Lista de contenedores de cliente vacia"); }
        }

        private void mod_contenedor_Click(object sender, EventArgs e)
        {   // Modificacion de contenedores , no se realiza modificacion de ID y tipo
            // por ser unico de cada contenedor
            try
            {
                string indx_cont = Convert.ToString(grillacontenedores.Rows[grillacontenedores.CurrentRow.Index].Cells[0].Value);
                Modificar_Contenedor(indx_cont, descripciontxt.Text, Convert.ToDecimal(pesotxt.Text), Convert.ToDateTime(fecha_ingreso_picker.Text));
                Actualizar_Contenedores(Lista_Contenedores);
                Borrar_txt_contenedor();
                grillaclientes_CellClick(this, null);
            }
            catch { MessageBox.Show("Error al modificar Contenedor"); }
        }

        private void grillacontenedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string indx_cont = Convert.ToString(grillacontenedores.Rows[grillacontenedores.CurrentRow.Index].Cells[0].Value);
            Contenedor C = Retornar_contenedor(indx_cont);
            descripciontxt.Text = C.Descripcion;
            pesotxt.Text = Convert.ToString(C.Peso);
            fecha_ingreso_picker.Value = C.Fecha_de_Ingreso;
        }

        private void mod_cliente_Click(object sender, EventArgs e)
        {
            // Modificacion de clientes , no se realiza modificacion de Legajo
            // por ser unico de cada cliente


            string indx_cli = Convert.ToString(grillaclientes.Rows[grillaclientes.CurrentRow.Index].Cells[0].Value);
            Cliente C = Retorna_cliente(indx_cli);

            if (C is Persona) { Modificar_cliente(indx_cli, nombretxt.Text, apellidotxt.Text); }
            else { Modificar_cliente(indx_cli, razonsocialtxt.Text); }
            grillaclientes.DataSource = null;
            grillaclientes.DataSource = VG.RetornaVistaCliente(Lista_Clientes);
            Borrar_txt_Cliente();
        }

    }

}
