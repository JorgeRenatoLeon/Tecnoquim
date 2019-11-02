﻿namespace LP2TECNOQUIMFRONT.frmJAlmacen
{
    partial class frmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.txtPres = new System.Windows.Forms.TextBox();
            this.txtGranu = new System.Windows.Forms.TextBox();
            this.txtNomProd = new System.Windows.Forms.TextBox();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.lblGranu = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.gbInsumos = new System.Windows.Forms.GroupBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtIdInsumo = new System.Windows.Forms.TextBox();
            this.lblInsumo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNomInsumo = new System.Windows.Forms.TextBox();
            this.lblNomInsumo = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Granulidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restriccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAct = new System.Windows.Forms.Label();
            this.txtAct = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblidProd = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblIdInstructivo = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.gbInsumos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gestionar Productos";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnGuardar,
            this.btnBuscar,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(953, 35);
            this.toolStrip1.TabIndex = 64;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 32);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 32);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 32);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 32);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 32);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtPres
            // 
            this.txtPres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPres.Location = new System.Drawing.Point(183, 137);
            this.txtPres.Name = "txtPres";
            this.txtPres.Size = new System.Drawing.Size(264, 30);
            this.txtPres.TabIndex = 38;
            // 
            // txtGranu
            // 
            this.txtGranu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtGranu.Location = new System.Drawing.Point(628, 137);
            this.txtGranu.Name = "txtGranu";
            this.txtGranu.Size = new System.Drawing.Size(187, 30);
            this.txtGranu.TabIndex = 36;
            // 
            // txtNomProd
            // 
            this.txtNomProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNomProd.Location = new System.Drawing.Point(180, 89);
            this.txtNomProd.Name = "txtNomProd";
            this.txtNomProd.Size = new System.Drawing.Size(487, 30);
            this.txtNomProd.TabIndex = 35;
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.ForeColor = System.Drawing.Color.White;
            this.lblPresentacion.Location = new System.Drawing.Point(31, 142);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(132, 25);
            this.lblPresentacion.TabIndex = 34;
            this.lblPresentacion.Text = "Presentacion:";
            // 
            // lblGranu
            // 
            this.lblGranu.AutoSize = true;
            this.lblGranu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGranu.ForeColor = System.Drawing.Color.White;
            this.lblGranu.Location = new System.Drawing.Point(481, 140);
            this.lblGranu.Name = "lblGranu";
            this.lblGranu.Size = new System.Drawing.Size(135, 25);
            this.lblGranu.TabIndex = 32;
            this.lblGranu.Text = "Granularidad: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(33, 92);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 25);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Nombre: ";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.textBox1);
            this.gbDatos.Controls.Add(this.lblidProd);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.lblGranu);
            this.gbDatos.Controls.Add(this.lblPresentacion);
            this.gbDatos.Controls.Add(this.txtNomProd);
            this.gbDatos.Controls.Add(this.txtPres);
            this.gbDatos.Controls.Add(this.txtGranu);
            this.gbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbDatos.Location = new System.Drawing.Point(23, 92);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(901, 186);
            this.gbDatos.TabIndex = 65;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Generales";
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
            this.gbInsumos.Controls.Add(this.button3);
            this.gbInsumos.Controls.Add(this.dgvInsumos);
            this.gbInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInsumos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbInsumos.Location = new System.Drawing.Point(23, 440);
            this.gbInsumos.Name = "gbInsumos";
            this.gbInsumos.Size = new System.Drawing.Size(901, 308);
            this.gbInsumos.TabIndex = 66;
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
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.button3.Location = new System.Drawing.Point(350, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 30);
            this.button3.TabIndex = 73;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.AllowUserToAddRows = false;
            this.dgvInsumos.AllowUserToDeleteRows = false;
            this.dgvInsumos.ColumnHeadersHeight = 40;
            this.dgvInsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.cantidad,
            this.Granulidad,
            this.Color,
            this.Unidad,
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
            // Granulidad
            // 
            this.Granulidad.HeaderText = "Granulidad";
            this.Granulidad.Name = "Granulidad";
            this.Granulidad.Width = 150;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            // 
            // Restriccion
            // 
            this.Restriccion.HeaderText = "Restriccion";
            this.Restriccion.Name = "Restriccion";
            this.Restriccion.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.lblIdInstructivo);
            this.groupBox2.Controls.Add(this.lblAct);
            this.groupBox2.Controls.Add(this.txtAct);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(23, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(901, 126);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instructivo";
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(180, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 30);
            this.textBox1.TabIndex = 77;
            // 
            // lblidProd
            // 
            this.lblidProd.AutoSize = true;
            this.lblidProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidProd.ForeColor = System.Drawing.Color.White;
            this.lblidProd.Location = new System.Drawing.Point(33, 41);
            this.lblidProd.Name = "lblidProd";
            this.lblidProd.Size = new System.Drawing.Size(125, 25);
            this.lblidProd.TabIndex = 76;
            this.lblidProd.Text = "ID Producto: ";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox2.Location = new System.Drawing.Point(183, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 30);
            this.textBox2.TabIndex = 79;
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
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(953, 772);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbInsumos);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGuardar";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbInsumos.ResumeLayout(false);
            this.gbInsumos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.TextBox txtPres;
        private System.Windows.Forms.TextBox txtGranu;
        private System.Windows.Forms.TextBox txtNomProd;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label lblGranu;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.GroupBox gbInsumos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtNomInsumo;
        private System.Windows.Forms.Label lblNomInsumo;
        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIdInsumo;
        private System.Windows.Forms.Label lblInsumo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Granulidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Restriccion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAct;
        private System.Windows.Forms.TextBox txtAct;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblidProd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblIdInstructivo;
    }
}