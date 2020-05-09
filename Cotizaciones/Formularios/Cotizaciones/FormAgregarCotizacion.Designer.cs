namespace Cotizaciones
{
    partial class FormAgregarCotizacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "ID");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Nombre");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Costo");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 4", "Cantidad tiempo");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn5 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Tipo tiempo");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn6 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 5", "Tiempo");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarCotizacion));
            this.gbCotizacion = new Telerik.WinControls.UI.RadGroupBox();
            this.txtFecha = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnAgregarServicio = new Telerik.WinControls.UI.RadButton();
            this.lvServicios = new Telerik.WinControls.UI.RadListView();
            this.lblServicios = new Telerik.WinControls.UI.RadLabel();
            this.txtDescripcion = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtMoneda = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtTitulo = new Telerik.WinControls.UI.RadTextBox();
            this.ddlClientes = new Telerik.WinControls.UI.RadDropDownList();
            this.lblDescripcion = new Telerik.WinControls.UI.RadLabel();
            this.lblTitulo = new Telerik.WinControls.UI.RadLabel();
            this.lblCliente = new Telerik.WinControls.UI.RadLabel();
            this.btnGuardar = new Telerik.WinControls.UI.RadButton();
            this.cmOpciones = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.miEditar = new Telerik.WinControls.UI.RadMenuItem();
            this.miEliminar = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gbCotizacion)).BeginInit();
            this.gbCotizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoneda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCotizacion
            // 
            this.gbCotizacion.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbCotizacion.Controls.Add(this.txtFecha);
            this.gbCotizacion.Controls.Add(this.btnAgregarServicio);
            this.gbCotizacion.Controls.Add(this.lvServicios);
            this.gbCotizacion.Controls.Add(this.lblServicios);
            this.gbCotizacion.Controls.Add(this.txtDescripcion);
            this.gbCotizacion.Controls.Add(this.txtMoneda);
            this.gbCotizacion.Controls.Add(this.radLabel5);
            this.gbCotizacion.Controls.Add(this.radLabel4);
            this.gbCotizacion.Controls.Add(this.txtTitulo);
            this.gbCotizacion.Controls.Add(this.ddlClientes);
            this.gbCotizacion.Controls.Add(this.lblDescripcion);
            this.gbCotizacion.Controls.Add(this.lblTitulo);
            this.gbCotizacion.Controls.Add(this.lblCliente);
            this.gbCotizacion.HeaderText = "Cotización";
            this.gbCotizacion.Location = new System.Drawing.Point(12, 12);
            this.gbCotizacion.Name = "gbCotizacion";
            this.gbCotizacion.Size = new System.Drawing.Size(723, 416);
            this.gbCotizacion.TabIndex = 0;
            this.gbCotizacion.Text = "Cotización";
            this.gbCotizacion.ThemeName = "TelerikMetro";
            // 
            // txtFecha
            // 
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha.Location = new System.Drawing.Point(95, 362);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(261, 24);
            this.txtFecha.TabIndex = 14;
            this.txtFecha.TabStop = false;
            this.txtFecha.Text = "07/05/2020";
            this.txtFecha.ThemeName = "TelerikMetro";
            this.txtFecha.Value = new System.DateTime(2020, 5, 7, 17, 11, 50, 351);
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.Location = new System.Drawing.Point(452, 362);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(197, 24);
            this.btnAgregarServicio.TabIndex = 13;
            this.btnAgregarServicio.Text = "Agregar servicio";
            this.btnAgregarServicio.ThemeName = "TelerikMetro";
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // lvServicios
            // 
            listViewDetailColumn1.HeaderText = "ID";
            listViewDetailColumn1.Visible = false;
            listViewDetailColumn2.HeaderText = "Nombre";
            listViewDetailColumn3.HeaderText = "Costo";
            listViewDetailColumn4.HeaderText = "Cantidad tiempo";
            listViewDetailColumn4.Visible = false;
            listViewDetailColumn5.HeaderText = "Tipo tiempo";
            listViewDetailColumn5.Visible = false;
            listViewDetailColumn6.HeaderText = "Tiempo";
            this.lvServicios.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4,
            listViewDetailColumn5,
            listViewDetailColumn6});
            this.lvServicios.ItemSpacing = -1;
            this.lvServicios.Location = new System.Drawing.Point(386, 75);
            this.lvServicios.Name = "lvServicios";
            this.lvServicios.Size = new System.Drawing.Size(321, 263);
            this.lvServicios.TabIndex = 12;
            this.lvServicios.Text = "radListView1";
            this.lvServicios.ThemeName = "TelerikMetro";
            this.lvServicios.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lvServicios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvServicios_MouseClick);
            // 
            // lblServicios
            // 
            this.lblServicios.Location = new System.Drawing.Point(529, 35);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(52, 16);
            this.lblServicios.TabIndex = 11;
            this.lblServicios.Text = "Servicios";
            this.lblServicios.ThemeName = "TelerikMetro";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AcceptsReturn = true;
            this.txtDescripcion.Location = new System.Drawing.Point(33, 154);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(323, 148);
            this.txtDescripcion.TabIndex = 10;
            this.txtDescripcion.ThemeName = "TelerikMetro";
            this.txtDescripcion.VerticalScrollBarState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.txtDescripcion.WordWrap = false;
            // 
            // txtMoneda
            // 
            this.txtMoneda.Location = new System.Drawing.Point(95, 318);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(261, 24);
            this.txtMoneda.TabIndex = 8;
            this.txtMoneda.ThemeName = "TelerikMetro";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(33, 362);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(47, 16);
            this.radLabel5.TabIndex = 7;
            this.radLabel5.Text = "Fecha : ";
            this.radLabel5.ThemeName = "TelerikMetro";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(33, 318);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(53, 16);
            this.radLabel4.TabIndex = 6;
            this.radLabel4.Text = "Moneda :";
            this.radLabel4.ThemeName = "TelerikMetro";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(121, 75);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(235, 24);
            this.txtTitulo.TabIndex = 4;
            this.txtTitulo.ThemeName = "TelerikMetro";
            // 
            // ddlClientes
            // 
            this.ddlClientes.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlClientes.Location = new System.Drawing.Point(121, 35);
            this.ddlClientes.Name = "ddlClientes";
            this.ddlClientes.Size = new System.Drawing.Size(235, 24);
            this.ddlClientes.TabIndex = 3;
            this.ddlClientes.ThemeName = "TelerikMetro";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(33, 117);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(75, 16);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción : ";
            this.lblDescripcion.ThemeName = "TelerikMetro";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(33, 75);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 16);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Título : ";
            this.lblTitulo.ThemeName = "TelerikMetro";
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(33, 35);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 16);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente : ";
            this.lblCliente.ThemeName = "TelerikMetro";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(254, 449);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(238, 24);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.ThemeName = "TelerikMetro";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmOpciones
            // 
            this.cmOpciones.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miEditar,
            this.miEliminar});
            this.cmOpciones.ThemeName = "TelerikMetro";
            // 
            // miEditar
            // 
            this.miEditar.Name = "miEditar";
            this.miEditar.Text = "Editar";
            // 
            // miEliminar
            // 
            this.miEliminar.Name = "miEliminar";
            this.miEliminar.Text = "Eliminar";
            // 
            // FormAgregarCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 497);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbCotizacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAgregarCotizacion";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Agregar cotización";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.FormAgregarCotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbCotizacion)).EndInit();
            this.gbCotizacion.ResumeLayout(false);
            this.gbCotizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoneda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox gbCotizacion;
        private Telerik.WinControls.UI.RadButton btnGuardar;
        private Telerik.WinControls.UI.RadTextBox txtTitulo;
        private Telerik.WinControls.UI.RadDropDownList ddlClientes;
        private Telerik.WinControls.UI.RadLabel lblDescripcion;
        private Telerik.WinControls.UI.RadLabel lblTitulo;
        private Telerik.WinControls.UI.RadLabel lblCliente;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox txtMoneda;
        private Telerik.WinControls.UI.RadTextBoxControl txtDescripcion;
        private Telerik.WinControls.UI.RadLabel lblServicios;
        private Telerik.WinControls.UI.RadButton btnAgregarServicio;
        public Telerik.WinControls.UI.RadListView lvServicios;
        private Telerik.WinControls.UI.RadContextMenu cmOpciones;
        private Telerik.WinControls.UI.RadMenuItem miEditar;
        private Telerik.WinControls.UI.RadMenuItem miEliminar;
        private Telerik.WinControls.UI.RadDateTimePicker txtFecha;
    }
}
