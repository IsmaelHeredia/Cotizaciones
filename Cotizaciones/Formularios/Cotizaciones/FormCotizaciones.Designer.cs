namespace Cotizaciones
{
    partial class FormCotizaciones
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Cliente");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Proyecto");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Costo");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn5 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 4", "Tiempo");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCotizaciones));
            this.gbCotizaciones = new Telerik.WinControls.UI.RadGroupBox();
            this.lvCotizaciones = new Telerik.WinControls.UI.RadListView();
            this.btnAgregarCotizacion = new Telerik.WinControls.UI.RadButton();
            this.cmOpciones = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.miEditar = new Telerik.WinControls.UI.RadMenuItem();
            this.miEliminar = new Telerik.WinControls.UI.RadMenuItem();
            this.miRecargar = new Telerik.WinControls.UI.RadMenuItem();
            this.miGenerarPDF = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gbCotizaciones)).BeginInit();
            this.gbCotizaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvCotizaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCotizaciones
            // 
            this.gbCotizaciones.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbCotizaciones.Controls.Add(this.lvCotizaciones);
            this.gbCotizaciones.HeaderText = "Cotizaciones";
            this.gbCotizaciones.Location = new System.Drawing.Point(22, 22);
            this.gbCotizaciones.Name = "gbCotizaciones";
            this.gbCotizaciones.Size = new System.Drawing.Size(628, 306);
            this.gbCotizaciones.TabIndex = 0;
            this.gbCotizaciones.Text = "Cotizaciones";
            this.gbCotizaciones.ThemeName = "TelerikMetro";
            // 
            // lvCotizaciones
            // 
            listViewDetailColumn1.HeaderText = "ID";
            listViewDetailColumn1.Visible = false;
            listViewDetailColumn2.HeaderText = "Cliente";
            listViewDetailColumn3.HeaderText = "Proyecto";
            listViewDetailColumn4.HeaderText = "Costo";
            listViewDetailColumn5.HeaderText = "Tiempo";
            this.lvCotizaciones.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4,
            listViewDetailColumn5});
            this.lvCotizaciones.ItemSpacing = -1;
            this.lvCotizaciones.Location = new System.Drawing.Point(25, 36);
            this.lvCotizaciones.Name = "lvCotizaciones";
            this.lvCotizaciones.Size = new System.Drawing.Size(585, 254);
            this.lvCotizaciones.TabIndex = 0;
            this.lvCotizaciones.Text = "radListView1";
            this.lvCotizaciones.ThemeName = "TelerikMetro";
            this.lvCotizaciones.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lvCotizaciones.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvCotizaciones_MouseClick);
            // 
            // btnAgregarCotizacion
            // 
            this.btnAgregarCotizacion.Location = new System.Drawing.Point(22, 348);
            this.btnAgregarCotizacion.Name = "btnAgregarCotizacion";
            this.btnAgregarCotizacion.Size = new System.Drawing.Size(196, 24);
            this.btnAgregarCotizacion.TabIndex = 1;
            this.btnAgregarCotizacion.Text = "Agregar nueva cotización";
            this.btnAgregarCotizacion.ThemeName = "TelerikMetro";
            this.btnAgregarCotizacion.Click += new System.EventHandler(this.btnAgregarCotizacion_Click);
            // 
            // cmOpciones
            // 
            this.cmOpciones.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miEditar,
            this.miEliminar,
            this.miRecargar,
            this.miGenerarPDF});
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
            // miRecargar
            // 
            this.miRecargar.Name = "miRecargar";
            this.miRecargar.Text = "Recargar lista";
            // 
            // miGenerarPDF
            // 
            this.miGenerarPDF.Name = "miGenerarPDF";
            this.miGenerarPDF.Text = "Generar PDF";
            // 
            // FormCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 395);
            this.Controls.Add(this.btnAgregarCotizacion);
            this.Controls.Add(this.gbCotizaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCotizaciones";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Cotizaciones";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.FormCotizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbCotizaciones)).EndInit();
            this.gbCotizaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvCotizaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox gbCotizaciones;
        private Telerik.WinControls.UI.RadListView lvCotizaciones;
        private Telerik.WinControls.UI.RadButton btnAgregarCotizacion;
        private Telerik.WinControls.UI.RadContextMenu cmOpciones;
        private Telerik.WinControls.UI.RadMenuItem miEditar;
        private Telerik.WinControls.UI.RadMenuItem miEliminar;
        private Telerik.WinControls.UI.RadMenuItem miRecargar;
        private Telerik.WinControls.UI.RadMenuItem miGenerarPDF;
    }
}
