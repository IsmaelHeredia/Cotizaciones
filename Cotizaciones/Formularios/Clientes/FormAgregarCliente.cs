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
    public partial class FormAgregarCliente : Telerik.WinControls.UI.RadForm
    {
        public string titulo;
        public FormClientes formClientes;

        public FormAgregarCliente(FormClientes formClientes_recibido)
        {
            InitializeComponent();
            titulo = System.Configuration.ConfigurationManager.AppSettings["titulo_programa"];
            formClientes = formClientes_recibido;
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string email = txtEmail.Text;

            if (nombre != "" && email != "")
            {

                ClienteDatos clienteDatos = new ClienteDatos();

                Cliente cliente = new Cliente();

                cliente.Nombre = nombre;
                cliente.Email = email;

                if (clienteDatos.comprobar_existencia_cliente_crear(nombre))
                {
                    RadMessageBox.Show("El nombre ya existe", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (clienteDatos.Agregar(cliente))
                    {
                        RadMessageBox.Show("El cliente fue creado correctamente", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                        formClientes.cargarClientes();
                        FormAgregarCliente.ActiveForm.Close();

                    }
                    else
                    {
                        RadMessageBox.Show("Error creando el cliente", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            else
            {
                RadMessageBox.Show("Complete los datos del cliente", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
