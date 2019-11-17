namespace LP2TECNOQUIMFRONT.frmJControlCalidad
{
    partial class frmModCalidad
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
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProductos = new System.Windows.Forms.Button();
            this.txtidprod = new System.Windows.Forms.TextBox();
            this.lblidProd = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.txtNomProd = new System.Windows.Forms.TextBox();
            this.txtPres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.LinkLabel();
            this.btnBuscarInsumo = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnBuscarInsumo);
            this.gbDatos.Controls.Add(this.cbRol);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.btnProductos);
            this.gbDatos.Controls.Add(this.txtidprod);
            this.gbDatos.Controls.Add(this.lblidProd);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.lblPresentacion);
            this.gbDatos.Controls.Add(this.txtNomProd);
            this.gbDatos.Controls.Add(this.txtPres);
            this.gbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbDatos.Location = new System.Drawing.Point(34, 123);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(901, 299);
            this.gbDatos.TabIndex = 66;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos ";
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(180, 155);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(482, 33);
            this.cbRol.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "Estado: ";
            // 
            // btnProductos
            // 
            this.btnProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductos.BackColor = System.Drawing.Color.White;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.btnProductos.Location = new System.Drawing.Point(380, 235);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(130, 33);
            this.btnProductos.TabIndex = 80;
            this.btnProductos.Text = "Guardar";
            this.btnProductos.UseVisualStyleBackColor = false;
            // 
            // txtidprod
            // 
            this.txtidprod.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtidprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtidprod.Location = new System.Drawing.Point(236, 41);
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
            this.lblidProd.Size = new System.Drawing.Size(178, 25);
            this.lblidProd.TabIndex = 76;
            this.lblidProd.Text = "ID Linea Producto: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(33, 100);
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
            this.lblPresentacion.Location = new System.Drawing.Point(547, 100);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(97, 25);
            this.lblPresentacion.TabIndex = 34;
            this.lblPresentacion.Text = "Cantidad:";
            // 
            // txtNomProd
            // 
            this.txtNomProd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtNomProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNomProd.Location = new System.Drawing.Point(180, 97);
            this.txtNomProd.Name = "txtNomProd";
            this.txtNomProd.Size = new System.Drawing.Size(313, 30);
            this.txtNomProd.TabIndex = 35;
            // 
            // txtPres
            // 
            this.txtPres.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtPres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPres.Location = new System.Drawing.Point(676, 97);
            this.txtPres.Name = "txtPres";
            this.txtPres.Size = new System.Drawing.Size(200, 30);
            this.txtPres.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 39);
            this.label1.TabIndex = 78;
            this.label1.Text = "Gestionar Productos";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.LinkColor = System.Drawing.Color.AliceBlue;
            this.lblBack.Location = new System.Drawing.Point(847, 45);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(79, 17);
            this.lblBack.TabIndex = 79;
            this.lblBack.TabStop = true;
            this.lblBack.Text = "< Regresar";
            this.lblBack.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // btnBuscarInsumo
            // 
            this.btnBuscarInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarInsumo.BackColor = System.Drawing.Color.White;
            this.btnBuscarInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarInsumo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.btnBuscarInsumo.Location = new System.Drawing.Point(420, 41);
            this.btnBuscarInsumo.Name = "btnBuscarInsumo";
            this.btnBuscarInsumo.Size = new System.Drawing.Size(52, 30);
            this.btnBuscarInsumo.TabIndex = 85;
            this.btnBuscarInsumo.Text = "...";
            this.btnBuscarInsumo.UseVisualStyleBackColor = false;
            this.btnBuscarInsumo.Click += new System.EventHandler(this.btnBuscarInsumo_Click);
            // 
            // frmModCalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(968, 449);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmModCalidad";
            this.Text = "frmModCalidad";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtidprod;
        private System.Windows.Forms.Label lblidProd;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.TextBox txtNomProd;
        private System.Windows.Forms.TextBox txtPres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblBack;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarInsumo;
    }
}