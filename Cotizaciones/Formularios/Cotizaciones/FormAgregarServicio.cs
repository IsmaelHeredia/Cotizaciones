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
    public partial class FormAgregarServicio : Telerik.WinControls.UI.RadForm
    {
        public string titulo;
        public FormAgregarCotizacion formAgregarCotizacion;
        public FormEditarCotizacion formEditarCotizacion;
        Funciones funcion = new Funciones();

        public FormAgregarServicio(FormAgregarCotizacion formAgregarCotizacion_recibido, FormEditarCotizacion formEditarCotizacion_recibido)
        {
            InitializeComponent();
            titulo = System.Configuration.ConfigurationManager.AppSettings["titulo_programa"];
            formAgregarCotizacion = formAgregarCotizacion_recibido;
            formEditarCotizacion = formEditarCotizacion_recibido;
            RadMessageBox.SetThemeName("TelerikMetro");
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
                    ListViewDataItem item = new ListViewDataItem();
                    item.SubItems.Add("0");
                    item.SubItems.Add(nombre);
                    item.SubItems.Add(costo);
                    item.SubItems.Add(tiempo);
                    item.SubItems.Add(tipo_tiempo);
                    item.SubItems.Add(tiempo + " " + funcion.cargarNombreTipoTiempo(tipo_tiempo,tiempo));
                    formAgregarCotizacion.lvServicios.Items.Add(item);

                    RadMessageBox.Show("Servicio guardado", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);

                    FormAgregarServicio.ActiveForm.Close();
                }
                else
                {
                    Servicio servicio = new Servicio();
                    servicio.Id_cotizacion = formEditarCotizacion.id_cotizacion;
                    servicio.Nombre = nombre;
                    servicio.Costo = costo;
                    servicio.Tiempo = tiempo;
                    servicio.Tipo_tiempo = tipo_tiempo;
                    ServicioDatos servicioDatos = new ServicioDatos();
                    if (servicioDatos.Agregar(servicio))
                    {
                        RadMessageBox.Show("Servicio guardado", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        RadMessageBox.Show("Error guardando el servicio", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    formEditarCotizacion.cargarServicios();
                    FormAgregarServicio.ActiveForm.Close();
                }
            }
            else
            {
                RadMessageBox.Show("Complete los datos del servicio", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }
        }

        private void FormAgregarServicio_Load(object sender, EventArgs e)
        {
            ddlTipoTiempo.Items.Add(new RadListDataItem() { Text = "Minutos", Value = 1 } );
            ddlTipoTiempo.Items.Add(new RadListDataItem() { Text = "Horas", Value = 60 });
            ddlTipoTiempo.Items.Add(new RadListDataItem() { Text = "Días", Value = 1440 });
            ddlTipoTiempo.Items.Add(new RadListDataItem() { Text = "Semanas", Value = 10080 });
            ddlTipoTiempo.Items.Add(new RadListDataItem() { Text = "Meses", Value = 43800 });
            ddlTipoTiempo.Items.Add(new RadListDataItem() { Text = "Años", Value = 525600 });
            ddlTipoTiempo.SelectedIndex = 0;
        }
    }
}
