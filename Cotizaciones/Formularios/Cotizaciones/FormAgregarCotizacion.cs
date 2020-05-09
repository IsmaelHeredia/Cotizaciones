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
using Cotizaciones.Formularios.Cotizaciones;

namespace Cotizaciones
{
    public partial class FormAgregarCotizacion : Telerik.WinControls.UI.RadForm
    {
        public string titulo;
        public FormCotizaciones formCotizaciones;
        FormAgregarServicio formAgregarServicio = new FormAgregarServicio(null,null);
        FormEditarServicio formEditarServicio = new FormEditarServicio(null,null);
        Funciones funcion = new Funciones();
        public FormAgregarCotizacion(FormCotizaciones formCotizaciones_recibido)
        {
            InitializeComponent();
            titulo = System.Configuration.ConfigurationManager.AppSettings["titulo_programa"];
            formCotizaciones = formCotizaciones_recibido;
            miEditar.Click += miEditar_Click;
            miEliminar.Click += miEliminar_Click;
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id_cliente = Convert.ToInt32(ddlClientes.SelectedValue);
            string titulo = txtTitulo.Text;
            string descripcion = txtDescripcion.Text;
            string moneda = txtMoneda.Text;
            string fecha = txtFecha.Text;

            if (id_cliente != 0 && titulo != "" && descripcion != "" && moneda != "" && fecha != "" && lvServicios.Items.Count > 0)
            {
                CotizacionDatos cotizacionDatos = new CotizacionDatos();

                Cotizacion cotizacion = new Cotizacion();

                cotizacion.Id_cliente = id_cliente;
                cotizacion.Titulo = titulo;
                cotizacion.Descripcion = descripcion;
                cotizacion.Moneda = moneda;
                cotizacion.Fecha = fecha;

                if (cotizacionDatos.comprobar_existencia_cotizacion_crear(titulo))
                {
                    RadMessageBox.Show("El nombre ya existe", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    int id_cotizacion = cotizacionDatos.Agregar(cotizacion);
                    if (id_cotizacion > 0)
                    {
                        ServicioDatos servicioDatos = new ServicioDatos();
                        ArrayList listSoftware = new ArrayList();
                        foreach (ListViewDataItem item in lvServicios.Items)
                        {
                            Servicio servicio = new Servicio();
                            servicio.Id_cotizacion = id_cotizacion;
                            servicio.Nombre = item[1].ToString();
                            servicio.Costo = Convert.ToInt32(item[2]);
                            servicio.Tiempo = Convert.ToInt32(item[3]);
                            servicio.Tipo_tiempo = Convert.ToInt32(item[4]);
                            servicioDatos.Agregar(servicio);
                        }
                        RadMessageBox.Show("La cotización fue creada correctamente", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                        formCotizaciones.cargarCotizaciones();
                        FormAgregarCotizacion.ActiveForm.Close();
                    }
                    else
                    {
                        RadMessageBox.Show("Error creando la cotización", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            else
            {
                RadMessageBox.Show("Complete los datos de la cotización", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }
        }

        private void FormAgregarCotizacion_Load(object sender, EventArgs e)
        {
            ClienteDatos clienteDatos = new ClienteDatos();

            ArrayList listaClientes = clienteDatos.cargarClientes();
            
            foreach (Cliente cliente in listaClientes)
            {
                RadListDataItem item = new RadListDataItem();
                item.Text = cliente.Nombre;
                item.Value = cliente.Id_cliente;
                ddlClientes.Items.Add(item);
            }

            if(listaClientes.Count > 0)
            {
                ddlClientes.SelectedIndex = 0;
            }
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            if (!formAgregarServicio.Visible)
            {
                formAgregarServicio = new FormAgregarServicio(this,null);
                formAgregarServicio.Show();
            }
        }

        private void lvServicios_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvServicios.SelectedIndex > -1)
                {
                    cmOpciones.Show(Cursor.Position);
                }
            }
        }

        private void miEditar_Click(object sender, EventArgs e)
        {
            if (!formEditarServicio.Visible)
            {
                formEditarServicio = new FormEditarServicio(this, null);
                formEditarServicio.Show();
            }
        }

        private void miEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ds = RadMessageBox.Show(this, "Esta seguro de borrar el servicio ?", titulo, MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (ds.ToString() == "Yes")
            {
                ListViewDataItem item = lvServicios.SelectedItem as ListViewDataItem;
                lvServicios.Items.Remove(item);
                RadMessageBox.Show("Servicio eliminado", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
