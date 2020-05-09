namespace Cotizaciones.Formularios.Cotizaciones
{
    partial class FormEditarServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarServicio));
            this.btnGuardar = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.ddlTipoTiempo = new Telerik.WinControls.UI.RadDropDownList();
            this.txtTiempo = new Telerik.WinControls.UI.RadTextBox();
            this.txtCosto = new Telerik.WinControls.UI.RadTextBox();
            this.txtNombre = new Telerik.WinControls.UI.RadTextBox();
            this.lblTiempo = new Telerik.WinControls.UI.RadLabel();
            this.lblCosto = new Telerik.WinControls.UI.RadLabel();
            this.lblNombre = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTipoTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(89, 235);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(173, 24);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.ThemeName = "TelerikMetro";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.ddlTipoTiempo);
            this.radGroupBox1.Controls.Add(this.txtTiempo);
            this.radGroupBox1.Controls.Add(this.txtCosto);
            this.radGroupBox1.Controls.Add(this.txtNombre);
            this.radGroupBox1.Controls.Add(this.lblTiempo);
            this.radGroupBox1.Controls.Add(this.lblCosto);
            this.radGroupBox1.Controls.Add(this.lblNombre);
            this.radGroupBox1.HeaderText = "Servicio";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(340, 201);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "Servicio";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            // 
            // ddlTipoTiempo
            // 
            this.ddlTipoTiempo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlTipoTiempo.Location = new System.Drawing.Point(202, 149);
            this.ddlTipoTiempo.Name = "ddlTipoTiempo";
            this.ddlTipoTiempo.Size = new System.Drawing.Size(122, 24);
            this.ddlTipoTiempo.TabIndex = 6;
            this.ddlTipoTiempo.ThemeName = "TelerikMetro";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(102, 149);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(94, 24);
            this.txtTiempo.TabIndex = 5;
            this.txtTiempo.ThemeName = "TelerikMetro";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(102, 96);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(222, 24);
            this.txtCosto.TabIndex = 4;
            this.txtCosto.ThemeName = "TelerikMetro";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(102, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 24);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.ThemeName = "TelerikMetro";
            // 
            // lblTiempo
            // 
            this.lblTiempo.Location = new System.Drawing.Point(27, 149);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(53, 16);
            this.lblTiempo.TabIndex = 2;
            this.lblTiempo.Text = "Tiempo : ";
            this.lblTiempo.ThemeName = "TelerikMetro";
            // 
            // lblCosto
            // 
            this.lblCosto.Location = new System.Drawing.Point(27, 96);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(45, 16);
            this.lblCosto.TabIndex = 1;
            this.lblCosto.Text = "Costo : ";
            this.lblCosto.ThemeName = "TelerikMetro";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(27, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre : ";
            this.lblNombre.ThemeName = "TelerikMetro";
            // 
            // FormEditarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 274);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEditarServicio";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Editar servicio";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.FormEditarServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTipoTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnGuardar;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox txtTiempo;
        private Telerik.WinControls.UI.RadTextBox txtCosto;
        private Telerik.WinControls.UI.RadTextBox txtNombre;
        private Telerik.WinControls.UI.RadLabel lblTiempo;
        private Telerik.WinControls.UI.RadLabel lblCosto;
        private Telerik.WinControls.UI.RadLabel lblNombre;
        private Telerik.WinControls.UI.RadDropDownList ddlTipoTiempo;
    }
}
