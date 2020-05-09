namespace Cotizaciones
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.lblSaludo = new Telerik.WinControls.UI.RadLabel();
            this.telerikMetroTheme = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.miOpciones = new Telerik.WinControls.UI.RadMenuItem();
            this.miClientes = new Telerik.WinControls.UI.RadMenuItem();
            this.miCotizaciones = new Telerik.WinControls.UI.RadMenuItem();
            this.miConfiguracion = new Telerik.WinControls.UI.RadMenuItem();
            this.miSalir = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            ((System.ComponentModel.ISupportInitialize)(this.lblSaludo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(30, 77);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(93, 22);
            this.lblSaludo.TabIndex = 0;
            this.lblSaludo.Text = "Bienvenido";
            this.lblSaludo.ThemeName = "TelerikMetro";
            // 
            // miOpciones
            // 
            this.miOpciones.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miClientes,
            this.miCotizaciones,
            this.miConfiguracion,
            this.miSalir});
            this.miOpciones.Name = "miOpciones";
            this.miOpciones.Text = "Opciones";
            // 
            // miClientes
            // 
            this.miClientes.Name = "miClientes";
            this.miClientes.Text = "Clientes";
            this.miClientes.Click += new System.EventHandler(this.miClientes_Click);
            // 
            // miCotizaciones
            // 
            this.miCotizaciones.Name = "miCotizaciones";
            this.miCotizaciones.Text = "Cotizaciones";
            this.miCotizaciones.Click += new System.EventHandler(this.miCotizaciones_Click);
            // 
            // miConfiguracion
            // 
            this.miConfiguracion.Name = "miConfiguracion";
            this.miConfiguracion.Text = "Configuración";
            this.miConfiguracion.Click += new System.EventHandler(this.miConfiguracion_Click);
            // 
            // miSalir
            // 
            this.miSalir.Name = "miSalir";
            this.miSalir.Text = "Salir";
            this.miSalir.Click += new System.EventHandler(this.miSalir_Click);
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miOpciones});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.radMenu1.Size = new System.Drawing.Size(419, 29);
            this.radMenu1.TabIndex = 3;
            this.radMenu1.Text = "radMenu1";
            this.radMenu1.ThemeName = "TelerikMetro";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 264);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.lblSaludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHome";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Sistema de cotizaciones 1.0 - Copyright © Ismael Heredia 2020";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblSaludo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblSaludo;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme;
        private Telerik.WinControls.UI.RadMenuItem miOpciones;
        private Telerik.WinControls.UI.RadMenuItem miClientes;
        private Telerik.WinControls.UI.RadMenuItem miCotizaciones;
        private Telerik.WinControls.UI.RadMenuItem miConfiguracion;
        private Telerik.WinControls.UI.RadMenuItem miSalir;
        private Telerik.WinControls.UI.RadMenu radMenu1;
    }
}