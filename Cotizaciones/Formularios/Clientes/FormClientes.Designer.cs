namespace Cotizaciones
{
    partial class FormClientes
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Email");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.gbClientes = new Telerik.WinControls.UI.RadGroupBox();
            this.lvClientes = new Telerik.WinControls.UI.RadListView();
            this.btnAgregarCliente = new Telerik.WinControls.UI.RadButton();
            this.cmOpciones = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.miRecargar = new Telerik.WinControls.UI.RadMenuItem();
            this.miEditar = new Telerik.WinControls.UI.RadMenuItem();
            this.miEliminar = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gbClientes)).BeginInit();
            this.gbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gbClientes
            // 
            this.gbClientes.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbClientes.Controls.Add(this.lvClientes);
            this.gbClientes.HeaderText = "Clientes";
            this.gbClientes.Location = new System.Drawing.Point(28, 22);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(460, 304);
            this.gbClientes.TabIndex = 0;
            this.gbClientes.Text = "Clientes";
            this.gbClientes.ThemeName = "TelerikMetro";
            // 
            // lvClientes
            // 
            listViewDetailColumn1.HeaderText = "ID";
            listViewDetailColumn1.Visible = false;
            listViewDetailColumn2.HeaderText = "Nombre";
            listViewDetailColumn3.HeaderText = "Email";
            this.lvClientes.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3});
            this.lvClientes.ItemSpacing = -1;
            this.lvClientes.Location = new System.Drawing.Point(26, 39);
            this.lvClientes.Name = "lvClientes";
            this.lvClientes.Size = new System.Drawing.Size(405, 245);
            this.lvClientes.TabIndex = 0;
            this.lvClientes.Text = "radListView1";
            this.lvClientes.ThemeName = "TelerikMetro";
            this.lvClientes.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lvClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvClientes_MouseClick);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(28, 347);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(173, 24);
            this.btnAgregarCliente.TabIndex = 1;
            this.btnAgregarCliente.Text = "Agregar nuevo cliente";
            this.btnAgregarCliente.ThemeName = "TelerikMetro";
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // cmOpciones
            // 
            this.cmOpciones.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miRecargar,
            this.miEditar,
            this.miEliminar});
            this.cmOpciones.ThemeName = "TelerikMetro";
            // 
            // miRecargar
            // 
            this.miRecargar.Name = "miRecargar";
            this.miRecargar.Text = "Recargar lista";
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
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 390);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.gbClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormClientes";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Clientes";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbClientes)).EndInit();
            this.gbClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox gbClientes;
        private Telerik.WinControls.UI.RadListView lvClientes;
        private Telerik.WinControls.UI.RadButton btnAgregarCliente;
        private Telerik.WinControls.UI.RadContextMenu cmOpciones;
        private Telerik.WinControls.UI.RadMenuItem miEditar;
        private Telerik.WinControls.UI.RadMenuItem miEliminar;
        private Telerik.WinControls.UI.RadMenuItem miRecargar;
    }
}
