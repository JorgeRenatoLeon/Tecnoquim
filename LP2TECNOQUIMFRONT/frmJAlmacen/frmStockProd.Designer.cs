namespace LP2TECNOQUIMFRONT.frmJAlmacen
{
    partial class frmStockProd
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
            this.cbAlmacen = new System.Windows.Forms.ComboBox();
            this.lblIdInstructivo = new System.Windows.Forms.Label();
            this.lblAct = new System.Windows.Forms.Label();
            this.txtAct = new System.Windows.Forms.TextBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnBuscarInsumo = new System.Windows.Forms.Button();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.txtidprod = new System.Windows.Forms.TextBox();
            this.lblidProd = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.txtNomProd = new System.Windows.Forms.TextBox();
            this.txtPres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.LinkLabel();
            this.groupBox2.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbAlmacen);
            this.groupBox2.Controls.Add(this.lblIdInstructivo);
            this.groupBox2.Controls.Add(this.lblAct);
            this.groupBox2.Controls.Add(this.txtAct);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(18, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 140);
            this.groupBox2.TabIndex = 70;
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
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnBuscarInsumo);
            this.gbDatos.Controls.Add(this.btnBuscarProd);
            this.gbDatos.Controls.Add(this.txtidprod);
            this.gbDatos.Controls.Add(this.lblidProd);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.lblPresentacion);
            this.gbDatos.Controls.Add(this.txtNomProd);
            this.gbDatos.Controls.Add(this.txtPres);
            this.gbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbDatos.Location = new System.Drawing.Point(18, 63);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(696, 186);
            this.gbDatos.TabIndex = 69;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Generales";
            // 
            // btnBuscarInsumo
            // 
            this.btnBuscarInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarInsumo.BackColor = System.Drawing.Color.White;
            this.btnBuscarInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarInsumo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.btnBuscarInsumo.Location = new System.Drawing.Point(362, 41);
            this.btnBuscarInsumo.Name = "btnBuscarInsumo";
            this.btnBuscarInsumo.Size = new System.Drawing.Size(52, 30);
            this.btnBuscarInsumo.TabIndex = 74;
            this.btnBuscarInsumo.Text = "...";
            this.btnBuscarInsumo.UseVisualStyleBackColor = false;
            this.btnBuscarInsumo.Click += new System.EventHandler(this.btnBuscarInsumo_Click);
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProd.BackColor = System.Drawing.Color.White;
            this.btnBuscarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.btnBuscarProd.Location = new System.Drawing.Point(374, 41);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(0, 30);
            this.btnBuscarProd.TabIndex = 74;
            this.btnBuscarProd.Text = "...";
            this.btnBuscarProd.UseVisualStyleBackColor = false;
            // 
            // txtidprod
            // 
            this.txtidprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtidprod.Location = new System.Drawing.Point(180, 41);
            this.txtidprod.Name = "txtidprod";
            this.txtidprod.ReadOnly = true;
            this.txtidprod.Size = new System.Drawing.Size(157, 30);
            this.txtidprod.TabIndex = 77;
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
            // txtNomProd
            // 
            this.txtNomProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNomProd.Location = new System.Drawing.Point(180, 89);
            this.txtNomProd.Name = "txtNomProd";
            this.txtNomProd.Size = new System.Drawing.Size(487, 30);
            this.txtNomProd.TabIndex = 35;
            // 
            // txtPres
            // 
            this.txtPres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPres.Location = new System.Drawing.Point(183, 137);
            this.txtPres.Name = "txtPres";
            this.txtPres.Size = new System.Drawing.Size(264, 30);
            this.txtPres.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 39);
            this.label1.TabIndex = 68;
            this.label1.Text = "Stock Productos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.btnGuardar.Location = new System.Drawing.Point(626, 21);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 30);
            this.btnGuardar.TabIndex = 75;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.LinkColor = System.Drawing.Color.AliceBlue;
            this.lblBack.Location = new System.Drawing.Point(15, 415);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(79, 17);
            this.lblBack.TabIndex = 76;
            this.lblBack.TabStop = true;
            this.lblBack.Text = "< Regresar";
            this.lblBack.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // frmStockProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(744, 451);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.label1);
            this.Name = "frmStockProd";
            this.Text = "frmStockProd";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblIdInstructivo;
        private System.Windows.Forms.Label lblAct;
        private System.Windows.Forms.TextBox txtAct;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtidprod;
        private System.Windows.Forms.Label lblidProd;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.TextBox txtNomProd;
        private System.Windows.Forms.TextBox txtPres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.ComboBox cbAlmacen;
        private System.Windows.Forms.Button btnBuscarInsumo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.LinkLabel lblBack;
    }
}