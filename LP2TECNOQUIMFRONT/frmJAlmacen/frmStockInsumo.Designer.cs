namespace LP2TECNOQUIMFRONT.frmJAlmacen
{
    partial class frmStockInsumo
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
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAlmacen = new System.Windows.Forms.ComboBox();
            this.lblIdInstructivo = new System.Windows.Forms.Label();
            this.lblAct = new System.Windows.Forms.Label();
            this.txtAct = new System.Windows.Forms.TextBox();
            this.btnBuscarInsumo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.LinkLabel();
            this.gbDatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnBuscarInsumo);
            this.gbDatos.Controls.Add(this.txtCodigo);
            this.gbDatos.Controls.Add(this.lblCodigo);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.txtUnidad);
            this.gbDatos.Controls.Add(this.lblUnidad);
            this.gbDatos.Controls.Add(this.lblCant);
            this.gbDatos.Controls.Add(this.txtCant);
            this.gbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbDatos.Location = new System.Drawing.Point(22, 69);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(624, 212);
            this.gbDatos.TabIndex = 66;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Generales";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCodigo.Location = new System.Drawing.Point(139, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(163, 30);
            this.txtCodigo.TabIndex = 67;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(31, 47);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(86, 25);
            this.lblCodigo.TabIndex = 66;
            this.lblCodigo.Text = "Codigo: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNombre.Location = new System.Drawing.Point(139, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(365, 30);
            this.txtNombre.TabIndex = 57;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(31, 103);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 25);
            this.lblNombre.TabIndex = 53;
            this.lblNombre.Text = "Nombre: ";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtUnidad.Location = new System.Drawing.Point(357, 159);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(88, 30);
            this.txtUnidad.TabIndex = 62;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.ForeColor = System.Drawing.Color.White;
            this.lblUnidad.Location = new System.Drawing.Point(256, 159);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(85, 25);
            this.lblUnidad.TabIndex = 61;
            this.lblUnidad.Text = "Unidad: ";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.ForeColor = System.Drawing.Color.White;
            this.lblCant.Location = new System.Drawing.Point(31, 159);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(102, 25);
            this.lblCant.TabIndex = 55;
            this.lblCant.Text = "Cantidad: ";
            // 
            // txtCant
            // 
            this.txtCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCant.Location = new System.Drawing.Point(139, 156);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(88, 30);
            this.txtCant.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 39);
            this.label1.TabIndex = 65;
            this.label1.Text = "Stock Insumo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbAlmacen);
            this.groupBox2.Controls.Add(this.lblIdInstructivo);
            this.groupBox2.Controls.Add(this.lblAct);
            this.groupBox2.Controls.Add(this.txtAct);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(22, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 140);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Almacen";
            // 
            // cbAlmacen
            // 
            this.cbAlmacen.FormattingEnabled = true;
            this.cbAlmacen.Location = new System.Drawing.Point(180, 30);
            this.cbAlmacen.Name = "cbAlmacen";
            this.cbAlmacen.Size = new System.Drawing.Size(267, 33);
            this.cbAlmacen.TabIndex = 79;
            // 
            // lblIdInstructivo
            // 
            this.lblIdInstructivo.AutoSize = true;
            this.lblIdInstructivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdInstructivo.ForeColor = System.Drawing.Color.White;
            this.lblIdInstructivo.Location = new System.Drawing.Point(36, 33);
            this.lblIdInstructivo.Name = "lblIdInstructivo";
            this.lblIdInstructivo.Size = new System.Drawing.Size(100, 25);
            this.lblIdInstructivo.TabIndex = 78;
            this.lblIdInstructivo.Text = "Almacen: ";
            // 
            // lblAct
            // 
            this.lblAct.AutoSize = true;
            this.lblAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAct.ForeColor = System.Drawing.Color.White;
            this.lblAct.Location = new System.Drawing.Point(36, 89);
            this.lblAct.Name = "lblAct";
            this.lblAct.Size = new System.Drawing.Size(73, 25);
            this.lblAct.TabIndex = 36;
            this.lblAct.Text = "Stock: ";
            // 
            // txtAct
            // 
            this.txtAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtAct.Location = new System.Drawing.Point(180, 86);
            this.txtAct.Name = "txtAct";
            this.txtAct.Size = new System.Drawing.Size(132, 30);
            this.txtAct.TabIndex = 37;
            // 
            // btnBuscarInsumo
            // 
            this.btnBuscarInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarInsumo.BackColor = System.Drawing.Color.White;
            this.btnBuscarInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarInsumo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.btnBuscarInsumo.Location = new System.Drawing.Point(332, 42);
            this.btnBuscarInsumo.Name = "btnBuscarInsumo";
            this.btnBuscarInsumo.Size = new System.Drawing.Size(52, 30);
            this.btnBuscarInsumo.TabIndex = 74;
            this.btnBuscarInsumo.Text = "...";
            this.btnBuscarInsumo.UseVisualStyleBackColor = false;
            this.btnBuscarInsumo.Click += new System.EventHandler(this.btnBuscarInsumo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.btnGuardar.Location = new System.Drawing.Point(558, 25);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 30);
            this.btnGuardar.TabIndex = 76;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.LinkColor = System.Drawing.Color.AliceBlue;
            this.lblBack.Location = new System.Drawing.Point(19, 455);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(79, 17);
            this.lblBack.TabIndex = 77;
            this.lblBack.TabStop = true;
            this.lblBack.Text = "< Regresar";
            this.lblBack.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // frmStockInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(667, 497);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.label1);
            this.Name = "frmStockInsumo";
            this.Text = "frmStockInsumo";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbAlmacen;
        private System.Windows.Forms.Label lblIdInstructivo;
        private System.Windows.Forms.Label lblAct;
        private System.Windows.Forms.TextBox txtAct;
        private System.Windows.Forms.Button btnBuscarInsumo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.LinkLabel lblBack;
    }
}