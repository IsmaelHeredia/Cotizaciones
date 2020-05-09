using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Cotizaciones.Modelos;
using Cotizaciones.Datos;
using Cotizaciones.Formularios.Cotizaciones;

namespace Cotizaciones
{
    public partial class FormEditarCotizacion : Telerik.WinControls.UI.RadForm
    {
        public string titulo;
        public int id_cotizacion;
        public FormCotizaciones formCotizaciones;
        public FormAgregarServicio formAgregarServicio = new FormAgregarServicio(null, null);
        public FormEditarServicio formEditarServicio = new FormEditarServicio(null, null);
        Funciones funcion = new Funciones();

        public FormEditarCotizacion(FormCotizaciones formCotizaciones_recibido, int id_cotizacion_recibido)
        {
            InitializeComponent();
            titulo = System.Configuration.ConfigurationManager.AppSettings["titulo_programa"];
            id_cotizacion = id_cotizacion_recibido;
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

                cotizacion.Id_cotizacion = id_cotizacion;
                cotizacion.Id_cliente = id_cliente;
                cotizacion.Titulo = titulo;
                cotizacion.Descripcion = descripcion;
                cotizacion.Moneda = moneda;
                cotizacion.Fecha = fecha;

                if (cotizacionDatos.comprobar_existencia_cotizacion_editar(id_cliente, titulo))
                {
                    RadMessageBox.Show("La cotización ya existe", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (cotizacionDatos.Editar(cotizacion))
                    {
                        RadMessageBox.Show("La cotización fue editada correctamente", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                        formCotizaciones.cargarCotizaciones();
                        FormAgregarCotizacion.ActiveForm.Close();
                    }
                    else
                    {
                        RadMessageBox.Show("Error editando la cotización", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            else
            {
                RadMessageBox.Show("Complete los datos de la cotización", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }
        }

        public void cargarServicios()
        {
            ServicioDatos servicioDatos = new ServicioDatos();
            ArrayList servicios = servicioDatos.cargarServicios(id_cotizacion);
            lvServicios.Items.Clear();
            foreach (Servicio servicio in servicios)
            {
                int id_servicio = servicio.Id_servicio;
                string nombre = servicio.Nombre;
                int costo = Convert.ToInt32(servicio.Costo);
                int tiempo = servicio.Tiempo;
                int tipo_tiempo = servicio.Tipo_tiempo;
                string tiempo_final = tiempo + " " + funcion.cargarNombreTipoTiempo(tipo_tiempo,tiempo);
                ListViewDataItem item = new ListViewDataItem();
                item.SubItems.Add(id_servicio);
                item.SubItems.Add(nombre);
                item.SubItems.Add(costo);
                item.SubItems.Add(tiempo);
                item.SubItems.Add(tipo_tiempo);
                item.SubItems.Add(tiempo_final);
                lvServicios.Items.Add(item);
            }
        }

        private void FormEditarCotizacion_Load(object sender, EventArgs e)
        {
            CotizacionDatos cotizacionDatos = new CotizacionDatos();
            ServicioDatos servicioDatos = new ServicioDatos();

            Cotizacion cotizacion = cotizacionDatos.cargarCotizacion(id_cotizacion);

            int id_cliente = cotizacion.Id_cliente;
            string titulo = cotizacion.Titulo;
            string descripcion = cotizacion.Descripcion;
            string moneda = cotizacion.Moneda;
            string fecha = cotizacion.Fecha;

            txtTitulo.Text = titulo;
            txtDescripcion.Text = descripcion;
            txtMoneda.Text = moneda;
            txtFecha.Text = fecha;

            cargarServicios();

            ClienteDatos clienteDatos = new ClienteDatos();

            ArrayList listaClientes = clienteDatos.cargarClientes();

            foreach (Cliente cliente in listaClientes)
            {
                RadListDataItem item = new RadListDataItem();
                item.Text = cliente.Nombre;
                item.Value = cliente.Id_cliente;
                ddlClientes.Items.Add(item);
            }

            ddlClientes.SelectedValue = cotizacion.Id_cliente;
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            if (!formAgregarServicio.Visible)
            {
                formAgregarServicio = new FormAgregarServicio(null, this);
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
                formEditarServicio = new FormEditarServicio(null, this);
                formEditarServicio.Show();
            }
        }

        private void miEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ds = RadMessageBox.Show(this, "Esta seguro de borrar el servicio ?", titulo, MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (ds.ToString() == "Yes")
            {
                int id_servicio = Convert.ToInt32(lvServicios.SelectedItem[0]);
                ServicioDatos servicioDatos = new ServicioDatos();
                if (servicioDatos.Borrar(id_servicio))
                {
                    RadMessageBox.Show("Servicio eliminado", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    RadMessageBox.Show("Error eliminando el servicio", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
                cargarServicios();
            }
        }
    }
}
