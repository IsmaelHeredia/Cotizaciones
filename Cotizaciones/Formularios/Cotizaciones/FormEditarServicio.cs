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
using System.Text.RegularExpressions;

namespace Cotizaciones.Formularios.Cotizaciones
{
    public partial class FormEditarServicio : Telerik.WinControls.UI.RadForm
    {
        public string titulo;
        public FormAgregarCotizacion formAgregarCotizacion;
        public FormEditarCotizacion formEditarCotizacion;
        public int id_servicio = 0;
        Funciones funcion = new Funciones();

        public FormEditarServicio(FormAgregarCotizacion formAgregarCotizacion_recibido, FormEditarCotizacion formEditarCotizacion_recibido)
        {
            InitializeComponent();
            titulo = System.Configuration.ConfigurationManager.AppSettings["titulo_programa"];
            formAgregarCotizacion = formAgregarCotizacion_recibido;
            formEditarCotizacion = formEditarCotizacion_recibido;
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void FormEditarServicio_Load(object sender, EventArgs e)
        {
            ddlTipoTiempo.Items.Add(new RadListDataItem() { Text = "Minutos", Value = 1 });
            ddlTipoTiempo.Items.Add(new RadListDataItem() { Text = "Horas", Value = 60 });
            ddlTipoTiempo.Items.Add(new RadListDataItem() { Text = "Días", Value = 1440 });
            ddlTipoTiempo.Items.Add(new RadListDataItem() { Text = "Semanas", Value = 10080 });
            ddlTipoTiempo.Items.Add(new RadListDataItem() { Text = "Meses", Value = 43800 });
            ddlTipoTiempo.Items.Add(new RadListDataItem() { Text = "Años", Value = 525600 });

            if (formAgregarCotizacion != null)
            {
                string nombre = formAgregarCotizacion.lvServicios.SelectedItem[1].ToString();
                string costo = formAgregarCotizacion.lvServicios.SelectedItem[2].ToString();
                string tiempo = formAgregarCotizacion.lvServicios.SelectedItem[3].ToString();
                string tipo_tiempo = formAgregarCotizacion.lvServicios.SelectedItem[4].ToString();
                txtNombre.Text = nombre;
                txtCosto.Text = costo;
                txtTiempo.Text = tiempo;
                ddlTipoTiempo.SelectedValue = tipo_tiempo;
            }
            else
            {
                id_servicio = Convert.ToInt32(formEditarCotizacion.lvServicios.SelectedItem[0]);
                ServicioDatos servicioDatos = new ServicioDatos();
                Servicio servicio = servicioDatos.cargarServicio(id_servicio);
                txtNombre.Text = servicio.Nombre;
                txtCosto.Text = servicio.Costo.ToString();
                txtTiempo.Text = servicio.Tiempo.ToString();
                ddlTipoTiempo.SelectedValue = servicio.Tipo_tiempo;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int costo = 0;
            if (Regex.IsMatch(txtCosto.Text, @"^\d+$"))
            {
                costo = Convert.ToInt32(txtCosto.Text);
            }
            int tiempo = 0;
            if (Regex.IsMatch(txtTiempo.Text, @"^\d+$"))
            {
                tiempo = Convert.ToInt32(txtTiempo.Text);
            }
            int tipo_tiempo = 0;
            if (ddlTipoTiempo.Text != "")
            {
                tipo_tiempo = Convert.ToInt32(ddlTipoTiempo.SelectedValue);
            }

            if (nombre != "" && costo != 0 && tiempo != 0 && tipo_tiempo != 0)
            {
                if (formAgregarCotizacion != null)
                {
                    formAgregarCotizacion.lvServicios.SelectedItem[1] = nombre;
                    formAgregarCotizacion.lvServicios.SelectedItem[2] = costo;
                    formAgregarCotizacion.lvServicios.SelectedItem[3] = tiempo;
                    formAgregarCotizacion.lvServicios.SelectedItem[4] = tipo_tiempo;
                    formAgregarCotizacion.lvServicios.SelectedItem[5] = tiempo + " " + funcion.cargarNombreTipoTiempo(tipo_tiempo,tiempo);
                    RadMessageBox.Show("Servicio editado", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    //MessageBox.Show(id_servicio.ToString());
                    //MessageBox.Show(formEditarCotizacion.id_cotizacion.ToString());
                    Servicio servicio = new Servicio();
                    servicio.Id_servicio = id_servicio;
                    servicio.Id_cotizacion = formEditarCotizacion.id_cotizacion;
                    servicio.Nombre = nombre;
                    servicio.Costo = costo;
                    servicio.Tiempo = tiempo;
                    servicio.Tipo_tiempo = tipo_tiempo;
                    ServicioDatos servicioDatos = new ServicioDatos();
                    if (servicioDatos.Editar(servicio))
                    {
                        RadMessageBox.Show("Servicio guardado", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        RadMessageBox.Show("Error guardando el servicio", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                formEditarCotizacion.cargarServicios();
                FormEditarServicio.ActiveForm.Close();
            }
            else
            {
                RadMessageBox.Show("Complete los datos del servicio", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
