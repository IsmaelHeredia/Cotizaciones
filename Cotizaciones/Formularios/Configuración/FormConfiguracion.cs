using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Cotizaciones.Datos;

namespace Cotizaciones
{
    public partial class FormConfiguracion : Telerik.WinControls.UI.RadForm
    {
        public string basededatos;
        public string titulo;
        public FormHome formHome;

        public FormConfiguracion(FormHome formHome_recibido)
        {
            InitializeComponent();
            basededatos = System.Configuration.ConfigurationManager.AppSettings["basededatos"];
            titulo = System.Configuration.ConfigurationManager.AppSettings["titulo_programa"];
            formHome = formHome_recibido;
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string email = txtEmail.Text;
            string presentacion = txtPresentacion.Text;
            string despedida = txtDespedida.Text;
            if (nombre != "" && email != "" && presentacion != "" && despedida != "")
            {
                Configuracion configuracion = new Configuracion();
                configuracion.Nombre = nombre;
                configuracion.Email = email;
                configuracion.Presentacion = presentacion;
                configuracion.Despedida = despedida;
                ConfiguracionDatos configuracionDatos = new ConfiguracionDatos();
                if (configuracionDatos.Editar(configuracion))
                {
                    RadMessageBox.Show("Configuración guardada", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    RadMessageBox.Show("Error guardando configuración", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
                FormConfiguracion.ActiveForm.Close();
                formHome.cargarNombre();
            }
            else
            {
                RadMessageBox.Show("Complete los datos de configuración", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }
        }

        private void FormConfiguracion_Load(object sender, EventArgs e)
        {
            ConfiguracionDatos configuracionDatos = new ConfiguracionDatos();
            Configuracion configuracion = configuracionDatos.cargarConfiguracion();
            txtNombre.Text = configuracion.Nombre;
            txtEmail.Text = configuracion.Email;
            txtPresentacion.Text = configuracion.Presentacion;
            txtDespedida.Text = configuracion.Despedida;
        }
    }
}
