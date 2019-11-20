namespace LP2TECNOQUIMFRONT.frmJproduccion
{
    partial class frmGestionarPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarPlan));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.dgvMaquinaria = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maquinaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNOrden = new System.Windows.Forms.TextBox();
            this.lblCodigoPMP = new System.Windows.Forms.Label();
            this.gbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarMaquinaria = new System.Windows.Forms.Button();
            this.btnBuscarMaquinaria = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreMaquinaria = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigoMaquinaria = new System.Windows.Forms.Label();
            this.gbOrdenes = new System.Windows.Forms.GroupBox();
            this.btnEditarOrden = new System.Windows.Forms.Button();
            this.dgvOrden = new System.Windows.Forms.DataGridView();
            this.CodigoOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calOrdenProduccion = new System.Windows.Forms.MonthCalendar();
            this.btnBuscarOrden = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinaria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbDatosGenerales.SuspendLayout();
            this.gbOrdenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnGuardar,
            this.btnBuscar,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(842, 32);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(87, 29);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 29);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 29);
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 29);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvMaquinaria
            // 
            this.dgvMaquinaria.AllowUserToAddRows = false;
            this.dgvMaquinaria.AllowUserToDeleteRows = false;
            this.dgvMaquinaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquinaria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Maquinaria,
            this.Fecha});
            this.dgvMaquinaria.Location = new System.Drawing.Point(26, 525);
            this.dgvMaquinaria.Name = "dgvMaquinaria";
            this.dgvMaquinaria.ReadOnly = true;
            this.dgvMaquinaria.RowHeadersWidth = 50;
            this.dgvMaquinaria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaquinaria.Size = new System.Drawing.Size(801, 162);
            this.dgvMaquinaria.TabIndex = 33;
            this.dgvMaquinaria.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMaquinaria_CellFormatting);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 150;
            // 
            // Maquinaria
            // 
            this.Maquinaria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Maquinaria.FillWeight = 150F;
            this.Maquinaria.HeaderText = "Maquinaria";
            this.Maquinaria.Name = "Maquinaria";
            this.Maquinaria.ReadOnly = true;
            this.Maquinaria.Width = 300;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 175;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNOrden);
            this.groupBox1.Controls.Add(this.lblCodigoPMP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(26, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 76);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Plan Maestro";
            // 
            // txtNOrden
            // 
            this.txtNOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOrden.Location = new System.Drawing.Point(138, 30);
            this.txtNOrden.Name = "txtNOrden";
            this.txtNOrden.ReadOnly = true;
            this.txtNOrden.Size = new System.Drawing.Size(152, 29);
            this.txtNOrden.TabIndex = 20;
            // 
            // lblCodigoPMP
            // 
            this.lblCodigoPMP.AutoSize = true;
            this.lblCodigoPMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPMP.Location = new System.Drawing.Point(39, 36);
            this.lblCodigoPMP.Name = "lblCodigoPMP";
            this.lblCodigoPMP.Size = new System.Drawing.Size(93, 24);
            this.lblCodigoPMP.TabIndex = 19;
            this.lblCodigoPMP.Text = "Nro. Plan:";
            // 
            // gbDatosGenerales
            // 
            this.gbDatosGenerales.Controls.Add(this.btnEliminar);
            this.gbDatosGenerales.Controls.Add(this.btnAgregarMaquinaria);
            this.gbDatosGenerales.Controls.Add(this.btnBuscarMaquinaria);
            this.gbDatosGenerales.Controls.Add(this.txtNombre);
            this.gbDatosGenerales.Controls.Add(this.lblNombreMaquinaria);
            this.gbDatosGenerales.Controls.Add(this.txtCodigo);
            this.gbDatosGenerales.Controls.Add(this.lblCodigoMaquinaria);
            this.gbDatosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosGenerales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbDatosGenerales.Location = new System.Drawing.Point(26, 365);
            this.gbDatosGenerales.Name = "gbDatosGenerales";
            this.gbDatosGenerales.Size = new System.Drawing.Size(801, 137);
            this.gbDatosGenerales.TabIndex = 30;
            this.gbDatosGenerales.TabStop = false;
            this.gbDatosGenerales.Text = "Maquinaria";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(722, 94);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(73, 28);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarMaquinaria
            // 
            this.btnAgregarMaquinaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregarMaquinaria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarMaquinaria.Location = new System.Drawing.Point(722, 41);
            this.btnAgregarMaquinaria.Name = "btnAgregarMaquinaria";
            this.btnAgregarMaquinaria.Size = new System.Drawing.Size(73, 28);
            this.btnAgregarMaquinaria.TabIndex = 37;
            this.btnAgregarMaquinaria.Text = "Agregar";
            this.btnAgregarMaquinaria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarMaquinaria.UseVisualStyleBackColor = true;
            this.btnAgregarMaquinaria.Click += new System.EventHandler(this.btnAgregarMaquinaria_Click);
            // 
            // btnBuscarMaquinaria
            // 
            this.btnBuscarMaquinaria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarMaquinaria.Location = new System.Drawing.Point(455, 37);
            this.btnBuscarMaquinaria.Name = "btnBuscarMaquinaria";
            this.btnBuscarMaquinaria.Size = new System.Drawing.Size(61, 28);
            this.btnBuscarMaquinaria.TabIndex = 36;
            this.btnBuscarMaquinaria.Text = "...";
            this.btnBuscarMaquinaria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarMaquinaria.UseVisualStyleBackColor = true;
            this.btnBuscarMaquinaria.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(207, 89);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(437, 29);
            this.txtNombre.TabIndex = 35;
            // 
            // lblNombreMaquinaria
            // 
            this.lblNombreMaquinaria.AutoSize = true;
            this.lblNombreMaquinaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMaquinaria.Location = new System.Drawing.Point(39, 92);
            this.lblNombreMaquinaria.Name = "lblNombreMaquinaria";
            this.lblNombreMaquinaria.Size = new System.Drawing.Size(162, 24);
            this.lblNombreMaquinaria.TabIndex = 34;
            this.lblNombreMaquinaria.Text = "Nombre Maquina:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(265, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(164, 29);
            this.txtCodigo.TabIndex = 20;
            // 
            // lblCodigoMaquinaria
            // 
            this.lblCodigoMaquinaria.AutoSize = true;
            this.lblCodigoMaquinaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMaquinaria.Location = new System.Drawing.Point(39, 39);
            this.lblCodigoMaquinaria.Name = "lblCodigoMaquinaria";
            this.lblCodigoMaquinaria.Size = new System.Drawing.Size(220, 24);
            this.lblCodigoMaquinaria.TabIndex = 19;
            this.lblCodigoMaquinaria.Text = "Codigo de la Maquinaria:";
            // 
            // gbOrdenes
            // 
            this.gbOrdenes.Controls.Add(this.btnEditarOrden);
            this.gbOrdenes.Controls.Add(this.dgvOrden);
            this.gbOrdenes.Controls.Add(this.calOrdenProduccion);
            this.gbOrdenes.Controls.Add(this.btnBuscarOrden);
            this.gbOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrdenes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbOrdenes.Location = new System.Drawing.Point(26, 142);
            this.gbOrdenes.Name = "gbOrdenes";
            this.gbOrdenes.Size = new System.Drawing.Size(801, 217);
            this.gbOrdenes.TabIndex = 38;
            this.gbOrdenes.TabStop = false;
            this.gbOrdenes.Text = "Ordenes de Producción";
            // 
            // btnEditarOrden
            // 
            this.btnEditarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditarOrden.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarOrden.Location = new System.Drawing.Point(722, 36);
            this.btnEditarOrden.Name = "btnEditarOrden";
            this.btnEditarOrden.Size = new System.Drawing.Size(73, 28);
            this.btnEditarOrden.TabIndex = 40;
            this.btnEditarOrden.Text = "Editar";
            this.btnEditarOrden.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarOrden.UseVisualStyleBackColor = true;
            this.btnEditarOrden.Click += new System.EventHandler(this.btnEditarOrden_Click);
            // 
            // dgvOrden
            // 
            this.dgvOrden.AllowUserToAddRows = false;
            this.dgvOrden.AllowUserToDeleteRows = false;
            this.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoOrden,
            this.Producto,
            this.Cantidad});
            this.dgvOrden.Location = new System.Drawing.Point(272, 36);
            this.dgvOrden.Name = "dgvOrden";
            this.dgvOrden.ReadOnly = true;
            this.dgvOrden.RowHeadersWidth = 50;
            this.dgvOrden.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrden.Size = new System.Drawing.Size(444, 162);
            this.dgvOrden.TabIndex = 39;
            this.dgvOrden.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrden_CellFormatting);
            // 
            // CodigoOrden
            // 
            this.CodigoOrden.HeaderText = "Codigo";
            this.CodigoOrden.Name = "CodigoOrden";
            this.CodigoOrden.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Producto.FillWeight = 150F;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 180;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 110;
            // 
            // calOrdenProduccion
            // 
            this.calOrdenProduccion.Location = new System.Drawing.Point(12, 36);
            this.calOrdenProduccion.Name = "calOrdenProduccion";
            this.calOrdenProduccion.TabIndex = 37;
            this.calOrdenProduccion.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calOrdenProduccion_DateChanged);
            // 
            // btnBuscarOrden
            // 
            this.btnBuscarOrden.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarOrden.Location = new System.Drawing.Point(287, 170);
            this.btnBuscarOrden.Name = "btnBuscarOrden";
            this.btnBuscarOrden.Size = new System.Drawing.Size(61, 28);
            this.btnBuscarOrden.TabIndex = 36;
            this.btnBuscarOrden.Text = "...";
            this.btnBuscarOrden.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarOrden.UseVisualStyleBackColor = true;
            this.btnBuscarOrden.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 29);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmGestionarPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(842, 719);
            this.Controls.Add(this.gbOrdenes);
            this.Controls.Add(this.dgvMaquinaria);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDatosGenerales);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmGestionarPlan";
            this.Text = "°";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinaria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDatosGenerales.ResumeLayout(false);
            this.gbDatosGenerales.PerformLayout();
            this.gbOrdenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.DataGridView dgvMaquinaria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNOrden;
        private System.Windows.Forms.Label lblCodigoPMP;
        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.Button btnBuscarMaquinaria;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreMaquinaria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigoMaquinaria;
        private System.Windows.Forms.Button btnAgregarMaquinaria;
        private System.Windows.Forms.GroupBox gbOrdenes;
        private System.Windows.Forms.Button btnBuscarOrden;
        private System.Windows.Forms.MonthCalendar calOrdenProduccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maquinaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridView dgvOrden;
        private System.Windows.Forms.Button btnEditarOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
    }
}