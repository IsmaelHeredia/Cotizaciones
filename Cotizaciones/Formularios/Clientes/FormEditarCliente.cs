using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Cotizaciones.Modelos;
using Cotizaciones.Datos;

namespace Cotizaciones
{
    public partial class FormEditarCliente : Telerik.WinControls.UI.RadForm
    {
        public string titulo;
        public int id_cliente;
        public FormClientes formClientes;

        public FormEditarCliente(FormClientes formClientes_recibido, int id_cliente_recibido)
        {
            InitializeComponent();
            titulo = System.Configuration.ConfigurationManager.AppSettings["titulo_programa"];
            id_cliente = id_cliente_recibido;
            formClientes = formClientes_recibido;
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string email = txtEmail.Text;

            if (nombre != "" && email != "")
            {

                Cliente cliente = new Cliente();
                cliente.Id_cliente = id_cliente;
                cliente.Nombre = nombre;
                cliente.Email = email;

                ClienteDatos clienteDatos = new ClienteDatos();

                if (clienteDatos.comprobar_existencia_cliente_editar(id_cliente, nombre))
                {
                    RadMessageBox.Show("El nombre ya existe", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (clienteDatos.Editar(cliente))
                    {
                        RadMessageBox.Show("El cliente fue editado correctamente", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                        formClientes.cargarClientes();
                        FormAgregarCliente.ActiveForm.Close();
                    }
                    else
                    {
                        RadMessageBox.Show("Error editando el cliente", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            } else
            {
                RadMessageBox.Show("Complete los datos del cliente", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }
        }

        private void FormEditarCliente_Load(object sender, EventArgs e)
        {
            ClienteDatos clienteDatos = new ClienteDatos();
            Cliente cliente = clienteDatos.cargarCliente(id_cliente);
            string nombre = cliente.Nombre;
            string email = cliente.Email;
            txtNombre.Text = nombre;
            txtEmail.Text = email;
        }
    }
}
