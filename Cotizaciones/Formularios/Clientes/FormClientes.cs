using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.IO;
using Cotizaciones.Modelos;
using Cotizaciones.Datos;

namespace Cotizaciones
{
    public partial class FormClientes : Telerik.WinControls.UI.RadForm
    {
        public string basededatos;
        public string titulo;
        FormAgregarCliente formAgregarCliente = new FormAgregarCliente(null);
        FormEditarCliente formEditarCliente = new FormEditarCliente(null, 0);

        public FormClientes()
        {
            InitializeComponent();
            basededatos = System.Configuration.ConfigurationManager.AppSettings["basededatos"];
            titulo = System.Configuration.ConfigurationManager.AppSettings["titulo_programa"];
            miRecargar.Click += miRecargar_Click;
            miEditar.Click += miEditar_Click;
            miEliminar.Click += miEliminar_Click;
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        public void cargarClientes()
        {
            lvClientes.Items.Clear();
            if (File.Exists(Path.GetFullPath(basededatos)))
            {
                ClienteDatos clienteDatos = new ClienteDatos();
                ArrayList listaClientes = clienteDatos.cargarClientes();
                foreach (Cliente cliente in listaClientes)
                {
                    int id_cliente = cliente.Id_cliente;
                    string nombre = cliente.Nombre;
                    string email = cliente.Email;

                    ListViewDataItem item = new ListViewDataItem();
                    item.SubItems.Add(id_cliente);
                    item.SubItems.Add(nombre);
                    item.SubItems.Add(email);
                    lvClientes.Items.Add(item);
                }
                gbClientes.Text = "Clientes : " + lvClientes.Items.Count + " encontrados";
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (!formAgregarCliente.Visible)
            {
                formAgregarCliente = new FormAgregarCliente(this);
                formAgregarCliente.Show();
            }
        }

        private void miRecargar_Click(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void miEditar_Click(object sender, EventArgs e)
        {
            if (!formEditarCliente.Visible)
            {
                var id_cliente = Convert.ToInt32(lvClientes.SelectedItem[0]);
                formEditarCliente = new FormEditarCliente(this, id_cliente);
                formEditarCliente.Show();
            }
        }

        private void miEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ds = RadMessageBox.Show(this, "Esta seguro de borrar el cliente ?", titulo, MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (ds.ToString() == "Yes")
            {
                var id_cliente = Convert.ToInt32(lvClientes.SelectedItem[0]);
                ClienteDatos clienteDatos = new ClienteDatos();
                if (clienteDatos.Borrar(id_cliente))
                {
                    RadMessageBox.Show("Cliente eliminado", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    RadMessageBox.Show("Error borrando el cliente", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
                cargarClientes();
            }
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void lvClientes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvClientes.SelectedIndex > -1)
                {
                    cmOpciones.Show(Cursor.Position);
                }
            }
        }
    }
}
