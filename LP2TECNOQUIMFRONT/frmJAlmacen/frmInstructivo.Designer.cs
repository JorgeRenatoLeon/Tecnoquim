namespace LP2TECNOQUIMFRONT.frmJAlmacen
{
    partial class frmInstructivo
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtidinst = new System.Windows.Forms.TextBox();
            this.lblIdInstructivo = new System.Windows.Forms.Label();
            this.lblAct = new System.Windows.Forms.Label();
            this.txtAct = new System.Windows.Forms.TextBox();
            this.gbInsumos = new System.Windows.Forms.GroupBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtIdInsumo = new System.Windows.Forms.TextBox();
            this.lblInsumo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNomInsumo = new System.Windows.Forms.TextBox();
            this.lblNomInsumo = new System.Windows.Forms.Label();
            this.btnBuscarInsumo = new System.Windows.Forms.Button();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Granularidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restriccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.gbInsumos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtidinst);
            this.groupBox2.Controls.Add(this.lblIdInstructivo);
            this.groupBox2.Controls.Add(this.lblAct);
            this.groupBox2.Controls.Add(this.txtAct);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(22, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(901, 126);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instructivo";
            // 
            // txtidinst
            // 
            this.txtidinst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtidinst.Location = new System.Drawing.Point(183, 30);
            this.txtidinst.Name = "txtidinst";
            this.txtidinst.ReadOnly = true;
            this.txtidinst.Size = new System.Drawing.Size(157, 30);
            this.txtidinst.TabIndex = 79;
            // 
            // lblIdInstructivo
            // 
            this.lblIdInstructivo.AutoSize = true;
            this.lblIdInstructivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdInstructivo.ForeColor = System.Drawing.Color.White;
            this.lblIdInstructivo.Location = new System.Drawing.Point(36, 30);
            this.lblIdInstructivo.Name = "lblIdInstructivo";
            this.lblIdInstructivo.Size = new System.Drawing.Size(135, 25);
            this.lblIdInstructivo.TabIndex = 78;
            this.lblIdInstructivo.Text = "ID Instructivo: ";
            // 
            // lblAct
            // 
            this.lblAct.AutoSize = true;
            this.lblAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAct.ForeColor = System.Drawing.Color.White;
            this.lblAct.Location = new System.Drawing.Point(36, 78);
            this.lblAct.Name = "lblAct";
            this.lblAct.Size = new System.Drawing.Size(124, 25);
            this.lblAct.TabIndex = 36;
            this.lblAct.Text = "Actividades: ";
            // 
            // txtAct
            // 
            this.txtAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtAct.Location = new System.Drawing.Point(180, 75);
            this.txtAct.Name = "txtAct";
            this.txtAct.Size = new System.Drawing.Size(487, 30);
            this.txtAct.TabIndex = 37;
            // 
            // gbInsumos
            // 
            this.gbInsumos.Controls.Add(this.txtCant);
            this.gbInsumos.Controls.Add(this.lblCantidad);
            this.gbInsumos.Controls.Add(this.btnEliminar);
            this.gbInsumos.Controls.Add(this.txtIdInsumo);
            this.gbInsumos.Controls.Add(this.lblInsumo);
            this.gbInsumos.Controls.Add(this.btnAgregar);
            this.gbInsumos.Controls.Add(this.txtNomInsumo);
            this.gbInsumos.Controls.Add(this.lblNomInsumo);
            this.gbInsumos.Controls.Add(this.btnBuscarInsumo);
            this.gbInsumos.Controls.Add(this.dgvInsumos);
            this.gbInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInsumos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbInsumos.Location = new System.Drawing.Point(22, 219);
            this.gbInsumos.Name = "gbInsumos";
            this.gbInsumos.Size = new System.Drawing.Size(901, 308);
            this.gbInsumos.TabIndex = 68;
            this.gbInsumos.TabStop = false;
            this.gbInsumos.Text = "Linea de Insumos";
            // 
            // txtCant
            // 
            this.txtCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCant.Location = new System.Drawing.Point(628, 87);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(69, 30);
            this.txtCant.TabIndex = 79;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(533, 89);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(102, 25);
            this.lblCantidad.TabIndex = 78;
            this.lblCantidad.Text = "Cantidad: ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.btnEliminar.Location = new System.Drawing.Point(837, 81);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(39, 36);
            this.btnEliminar.TabIndex = 77;
            this.btnEliminar.Text = "-";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // txtIdInsumo
            // 
            this.txtIdInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtIdInsumo.Location = new System.Drawing.Point(169, 42);
            this.txtIdInsumo.Name = "txtIdInsumo";
            this.txtIdInsumo.ReadOnly = true;
            this.txtIdInsumo.Size = new System.Drawing.Size(157, 30);
            this.txtIdInsumo.TabIndex = 75;
            // 
            // lblInsumo
            // 
            this.lblInsumo.AutoSize = true;
            this.lblInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsumo.ForeColor = System.Drawing.Color.White;
            this.lblInsumo.Location = new System.Drawing.Point(33, 42);
            this.lblInsumo.Name = "lblInsumo";
            this.lblInsumo.Size = new System.Drawing.Size(106, 25);
            this.lblInsumo.TabIndex = 74;
            this.lblInsumo.Text = "ID Insumo:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.btnAgregar.Location = new System.Drawing.Point(775, 81);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(40, 36);
            this.btnAgregar.TabIndex = 76;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtNomInsumo
            // 
            this.txtNomInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNomInsumo.Location = new System.Drawing.Point(191, 89);
            this.txtNomInsumo.Name = "txtNomInsumo";
            this.txtNomInsumo.Size = new System.Drawing.Size(302, 30);
            this.txtNomInsumo.TabIndex = 72;
            // 
            // lblNomInsumo
            // 
            this.lblNomInsumo.AutoSize = true;
            this.lblNomInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomInsumo.ForeColor = System.Drawing.Color.White;
            this.lblNomInsumo.Location = new System.Drawing.Point(33, 92);
            this.lblNomInsumo.Name = "lblNomInsumo";
            this.lblNomInsumo.Size = new System.Drawing.Size(161, 25);
            this.lblNomInsumo.TabIndex = 71;
            this.lblNomInsumo.Text = "Nombre Insumo: ";
            // 
            // btnBuscarInsumo
            // 
            this.btnBuscarInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarInsumo.BackColor = System.Drawing.Color.White;
            this.btnBuscarInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarInsumo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.btnBuscarInsumo.Location = new System.Drawing.Point(350, 42);
            this.btnBuscarInsumo.Name = "btnBuscarInsumo";
            this.btnBuscarInsumo.Size = new System.Drawing.Size(52, 30);
            this.btnBuscarInsumo.TabIndex = 73;
            this.btnBuscarInsumo.Text = "...";
            this.btnBuscarInsumo.UseVisualStyleBackColor = false;
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.AllowUserToAddRows = false;
            this.dgvInsumos.AllowUserToDeleteRows = false;
            this.dgvInsumos.ColumnHeadersHeight = 40;
            this.dgvInsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.cantidad,
            this.Unidad,
            this.Granularidad,
            this.Color,
            this.Restriccion});
            this.dgvInsumos.Location = new System.Drawing.Point(38, 149);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsumos.Size = new System.Drawing.Size(838, 140);
            this.dgvInsumos.TabIndex = 70;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            // 
            // Granularidad
            // 
            this.Granularidad.HeaderText = "Granularidad";
            this.Granularidad.Name = "Granularidad";
            this.Granularidad.Width = 150;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            // 
            // Restriccion
            // 
            this.Restriccion.HeaderText = "Restriccion";
            this.Restriccion.Name = "Restriccion";
            this.Restriccion.Width = 150;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 39);
            this.label1.TabIndex = 70;
            this.label1.Text = "Instructivo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.btnGuardar.Location = new System.Drawing.Point(822, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 36);
            this.btnGuardar.TabIndex = 77;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmInstructivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(945, 549);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbInsumos);
            this.Name = "frmInstructivo";
            this.Text = "frmInstructivo";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbInsumos.ResumeLayout(false);
            this.gbInsumos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtidinst;
        private System.Windows.Forms.Label lblIdInstructivo;
        private System.Windows.Forms.Label lblAct;
        private System.Windows.Forms.TextBox txtAct;
        private System.Windows.Forms.GroupBox gbInsumos;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIdInsumo;
        private System.Windows.Forms.Label lblInsumo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNomInsumo;
        private System.Windows.Forms.Label lblNomInsumo;
        private System.Windows.Forms.Button btnBuscarInsumo;
        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Granularidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Restriccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
    }
}