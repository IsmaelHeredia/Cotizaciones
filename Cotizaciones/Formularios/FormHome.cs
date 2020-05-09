// Sistema de cotizaciones 1.0
// Copyright © Ismael Heredia 2020

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Configuration;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Cotizaciones.Datos;

namespace Cotizaciones
{
    public partial class FormHome : Telerik.WinControls.UI.RadForm
    {
        public string basededatos;
        public string titulo;
        FormClientes formClientes = new FormClientes();
        FormCotizaciones formCotizaciones = new FormCotizaciones();
        FormConfiguracion formConfiguracion = new FormConfiguracion(null);

        public FormHome()
        {
            InitializeComponent();
            basededatos = System.Configuration.ConfigurationManager.AppSettings["basededatos"];
            titulo = System.Configuration.ConfigurationManager.AppSettings["titulo_programa"];
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        public void cargarNombre()
        {
            ConfiguracionDatos configuracionDatos = new ConfiguracionDatos();
            Configuracion configuracion_bd = configuracionDatos.cargarConfiguracion();
            string nombre_usuario = configuracion_bd.Nombre;

            lblSaludo.Text = "Bienvenido " + nombre_usuario;
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();
            ConfiguracionDatos configuracionDatos = new ConfiguracionDatos();

            if (!File.Exists(Path.GetFullPath(basededatos)))
            {
                string nombre = RadInputBox.Show("Ingrese su nombre completo", titulo, "");
                string email = RadInputBox.Show("Ingrese su email", titulo, "");

                string presentacion = "Ha solicitado información sobre mis servicios. A continuación aparece mi presupuesto :";
                string despedida = "Gracias por darme la oportunidad de ofrecerle mi presupuesto. Le puedo asegurar un trabajo de calidad si me lo permite. Deseo mostrarle que merece la pena.";

                Configuracion configuracion = new Configuracion();

                configuracion.Nombre = nombre;
                configuracion.Email = email;
                configuracion.Presentacion = presentacion;
                configuracion.Despedida = despedida;

                datos.crearBD();
                configuracionDatos.Agregar(configuracion);

                RadMessageBox.Show("Configuración finalizada", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }

            cargarNombre();
        }

        private void miClientes_Click(object sender, EventArgs e)
        {
            if (!formClientes.Visible)
            {
                formClientes = new FormClientes();
                formClientes.Show();
            }
        }

        private void miCotizaciones_Click(object sender, EventArgs e)
        {
            if (!formCotizaciones.Visible)
            {
                formCotizaciones = new FormCotizaciones();
                formCotizaciones.Show();
            }
        }

        private void miConfiguracion_Click(object sender, EventArgs e)
        {
            if (!formConfiguracion.Visible)
            {
                formConfiguracion = new FormConfiguracion(this);
                formConfiguracion.Show();
            }
        }

        private void miSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
