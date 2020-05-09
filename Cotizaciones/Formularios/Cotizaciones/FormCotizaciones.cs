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
using IronPdf;

namespace Cotizaciones
{
    public partial class FormCotizaciones : Telerik.WinControls.UI.RadForm
    {
        public string basededatos;
        public string titulo;
        FormAgregarCotizacion formAgregarCotizacion = new FormAgregarCotizacion(null);
        FormEditarCotizacion formEditarCotizacion = new FormEditarCotizacion(null, 0);
        Funciones funcion = new Funciones();

        public FormCotizaciones()
        {
            InitializeComponent();
            basededatos = System.Configuration.ConfigurationManager.AppSettings["basededatos"];
            titulo = System.Configuration.ConfigurationManager.AppSettings["titulo_programa"];
            miEditar.Click += miEditar_Click;
            miEliminar.Click += miEliminar_Click;
            miRecargar.Click += miRecargar_Click;
            miGenerarPDF.Click += miGenerarPDF_Click;
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        public void cargarCotizaciones()
        {
            lvCotizaciones.Items.Clear();
            if (File.Exists(Path.GetFullPath(basededatos)))
            {
                CotizacionDatos cotizacionDatos = new CotizacionDatos();
                ServicioDatos servicioDatos = new ServicioDatos();
                Funciones funcion = new Funciones();

                ArrayList listaCotizaciones = cotizacionDatos.cargarCotizaciones();
                foreach (Cotizacion cotizacion in listaCotizaciones)
                {
                    int id_cotizacion = cotizacion.Id_cotizacion;
                    string nombre_cliente = cotizacion.Nombre_cliente;
                    string titulo = cotizacion.Titulo;

                    ArrayList servicios = servicioDatos.cargarServicios(id_cotizacion);
                    int costo_total = 0;
                    int minutos_total = 0;
                    string tiempo_total = "";

                    foreach(Servicio servicio in servicios)
                    {
                        int servicio_minutos = servicio.Tiempo;
                        int tipo_servicio_minutos = servicio.Tipo_tiempo;
                        int servicio_costo = servicio.Costo;

                        costo_total += servicio_costo;
                        minutos_total += servicio_minutos * tipo_servicio_minutos; 
                    }

                    tiempo_total = funcion.sumarTotalTiempo(minutos_total);

                    ListViewDataItem item = new ListViewDataItem();
                    item.SubItems.Add(id_cotizacion);
                    item.SubItems.Add(nombre_cliente);
                    item.SubItems.Add(titulo);
                    item.SubItems.Add("$ " + costo_total);
                    item.SubItems.Add(tiempo_total);
                    lvCotizaciones.Items.Add(item);
                }
                gbCotizaciones.Text = "Cotizaciones : " + lvCotizaciones.Items.Count + " encontrados";
            }
        }

        private void btnAgregarCotizacion_Click(object sender, EventArgs e)
        {
            if (!formAgregarCotizacion.Visible)
            {
                formAgregarCotizacion = new FormAgregarCotizacion(this);
                formAgregarCotizacion.Show();
            }
        }

        private void miRecargar_Click(object sender, EventArgs e)
        {
            cargarCotizaciones();
        }

        private void miEditar_Click(object sender, EventArgs e)
        {
            if (!formEditarCotizacion.Visible)
            {
                var id_cotizacion = Convert.ToInt32(lvCotizaciones.SelectedItem[0]);
                formEditarCotizacion = new FormEditarCotizacion(this, id_cotizacion);
                formEditarCotizacion.Show();
            }
        }

        private void miEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ds = RadMessageBox.Show(this, "Esta seguro de borrar la cotización ?", titulo, MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (ds.ToString() == "Yes")
            {
                var id_cotizacion = Convert.ToInt32(lvCotizaciones.SelectedItem[0]);
                CotizacionDatos cotizacionDatos = new CotizacionDatos();
                ServicioDatos servicioDatos = new ServicioDatos();
                if (cotizacionDatos.Borrar(id_cotizacion))
                {
                    servicioDatos.BorrarPorCotizacion(id_cotizacion);
                    RadMessageBox.Show("Cotización eliminada", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    RadMessageBox.Show("Error borrando la cotización", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
                cargarCotizaciones();
            }
        }

        private void miGenerarPDF_Click(object sender, EventArgs e)
        {
            ConfiguracionDatos configuracionDatos = new ConfiguracionDatos();
            CotizacionDatos cotizacionDatos = new CotizacionDatos();
            ServicioDatos servicioDatos = new ServicioDatos();

            Configuracion configuracion = configuracionDatos.cargarConfiguracion();

            var id_cotizacion = Convert.ToInt32(lvCotizaciones.SelectedItem[0]);

            Cotizacion cotizacion = cotizacionDatos.cargarCotizacion(id_cotizacion);
            ArrayList servicios = servicioDatos.cargarServicios(id_cotizacion);

            string titulo = cotizacion.Titulo;
            string fecha = cotizacion.Fecha;
            string cliente = cotizacion.Nombre_cliente;
            string descripcion = cotizacion.Descripcion;
            string moneda = cotizacion.Moneda;

            string nombre = configuracion.Nombre;
            string email = configuracion.Email;
            string presentacion = configuracion.Presentacion;
            string despedida = configuracion.Despedida;

            string html_code = "";

            html_code += "<html>" + Environment.NewLine;
            html_code += "<head>" + Environment.NewLine;
            html_code += "<link href='https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css' rel='stylesheet' integrity='sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh' crossorigin='anonymous'>" + Environment.NewLine;
            html_code += "<script src='https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js' integrity='sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6' crossorigin='anonymous'></script>" + Environment.NewLine;
            html_code += "<script src='https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.bundle.min.js' integrity='sha384-6khuMg9gaYr5AxOqhkVIODVIvm9ynTT5J4V1cfthmT+emCG6yVmEZsRHdxlotUnm' crossorigin='anonymous'></script>" + Environment.NewLine;
            html_code += "</head>" + Environment.NewLine;
            html_code += "<body>" + Environment.NewLine;
            html_code += "<div class='container-fluid'>" + Environment.NewLine;

            html_code += "<h1>Cotización para " + titulo + "</h1>" + Environment.NewLine;
            html_code += "<br/>" + Environment.NewLine;

            html_code += "<b>" + fecha + "</b>" + Environment.NewLine;
            html_code += "<br/>" + Environment.NewLine;
            html_code += "<br/>" + Environment.NewLine;

            html_code += "<p>Estimado " + cliente + ":</p>" + Environment.NewLine;

            html_code += "<p>" + presentacion + "</p>" + Environment.NewLine;
            html_code += "<br/>" + Environment.NewLine;

            html_code += "<table class='table table-striped'>" + Environment.NewLine;
            html_code += "<thead>" + Environment.NewLine;
            html_code += "<tr>" + Environment.NewLine;
            html_code += "<th scope='col'>Servicio</th>" + Environment.NewLine;
            html_code += "<th scope='col'>Costo</th>" + Environment.NewLine;
            html_code += "<th scope='col'>Tiempo</th>" + Environment.NewLine;
            html_code += "</tr>" + Environment.NewLine;
            html_code += "</thead>" + Environment.NewLine;

            html_code += "<tbody>" + Environment.NewLine;

            int costo_total = 0;
            int minutos_total = 0;
            string tiempo_total = "";

            foreach (Servicio servicio in servicios)
            {
                string nombre_servicio = servicio.Nombre;
                int servicio_minutos = servicio.Tiempo;
                int tipo_servicio_minutos = servicio.Tipo_tiempo;
                int servicio_costo = servicio.Costo;

                costo_total += servicio_costo;
                minutos_total += servicio_minutos * tipo_servicio_minutos;

                int tiempo = servicio_minutos * tipo_servicio_minutos;
                string tiempo_string = funcion.sumarTotalTiempo(tiempo);

                html_code += "<tr>" + Environment.NewLine;
                html_code += "<td>" + nombre_servicio + "</th>" + Environment.NewLine;
                html_code += "<td>$ " + servicio_costo + "</td>" + Environment.NewLine;
                html_code += "<td>" + tiempo_string + "</td>" + Environment.NewLine;
                html_code += "</tr>" + Environment.NewLine;
            }

            tiempo_total = funcion.sumarTotalTiempo(minutos_total);

            html_code += "<tr>" + Environment.NewLine;
            html_code += "<td><b>Total</b></th>" + Environment.NewLine;
            html_code += "<td><b>$ " + costo_total + "</b></td>" + Environment.NewLine;
            html_code += "<td><b>" + tiempo_total + "</b></td>" + Environment.NewLine;
            html_code += "</tr>" + Environment.NewLine;

            html_code += "</tbody>" + Environment.NewLine;

            html_code += "</table>" + Environment.NewLine;

            html_code += "<br/>" + Environment.NewLine;

            html_code += "<h3>Características</h3>" + Environment.NewLine;
            html_code += "<br/>" + Environment.NewLine;
            html_code += "<p>" + descripcion + "</p>" + Environment.NewLine;
            html_code += "<hr>" + Environment.NewLine;

            html_code += "<p>Los precios están expresados en " + moneda.ToLower() + ". Si tiene alguna duda sobre mi presupuesto puede enviarme un correo a " + email + "</p>" + Environment.NewLine;

            html_code += "<p>" + despedida + "</p>" + Environment.NewLine;

            html_code += "<p>Atentamente,</p> " + Environment.NewLine;
            html_code += "<p>" + nombre + "</p>" + Environment.NewLine;

            html_code += "</div>" + Environment.NewLine;
            html_code += "</body>" + Environment.NewLine;
            html_code += "</html>" + Environment.NewLine;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.Title = "Guardar archivo PDF";
            saveFileDialog.DefaultExt = "pdf";
            saveFileDialog.Filter = "Archivo PDF (.pdf)|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string archivo_pdf = saveFileDialog.FileName;

                if(archivo_pdf == "")
                {
                    archivo_pdf = "cotizacion_pdf.pdf";
                }

                var Renderer = new IronPdf.HtmlToPdf();
                Renderer.PrintOptions.CssMediaType = PdfPrintOptions.PdfCssMediaType.Screen;
                Renderer.PrintOptions.ViewPortWidth = 1280;
                Renderer.PrintOptions.MarginTop = -50;
                Renderer.RenderHtmlAsPdf(html_code).SaveAs(archivo_pdf);
            }

            RadMessageBox.Show("PDF Generado", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
        }

        private void FormCotizaciones_Load(object sender, EventArgs e)
        {
            cargarCotizaciones();
        }

        private void lvCotizaciones_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvCotizaciones.SelectedIndex > -1)
                {
                    cmOpciones.Show(Cursor.Position);
                }
            }
        }
    }
}
