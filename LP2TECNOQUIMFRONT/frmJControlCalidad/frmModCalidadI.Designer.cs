namespace LP2TECNOQUIMFRONT.frmJControlCalidad
{
    partial class frmModCalidadI
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.btnProductos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarInsumo = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblidProd = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblBack = new System.Windows.Forms.LinkLabel();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 39);
            this.label1.TabIndex = 80;
            this.label1.Text = "Gestionar Insumos";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.txtLote);
            this.gbDatos.Controls.Add(this.cbRol);
            this.gbDatos.Controls.Add(this.btnProductos);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.btnBuscarInsumo);
            this.gbDatos.Controls.Add(this.txtid);
            this.gbDatos.Controls.Add(this.lblidProd);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.lblPresentacion);
            this.gbDatos.Controls.Add(this.txtNom);
            this.gbDatos.Controls.Add(this.txtStock);
            this.gbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbDatos.Location = new System.Drawing.Point(41, 132);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(901, 295);
            this.gbDatos.TabIndex = 79;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(706, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 83;
            this.label3.Text = "Lote:";
            // 
            // txtLote
            // 
            this.txtLote.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtLote.Location = new System.Drawing.Point(780, 100);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(99, 30);
            this.txtLote.TabIndex = 84;
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(145, 154);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(482, 33);
            this.cbRol.TabIndex = 82;
            // 
            // btnProductos
            // 
            this.btnProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductos.BackColor = System.Drawing.Color.White;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.btnProductos.Location = new System.Drawing.Point(388, 231);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(130, 33);
            this.btnProductos.TabIndex = 81;
            this.btnProductos.Text = "Guardar";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 80;
            this.label2.Text = "Estado: ";
            // 
            // btnBuscarInsumo
            // 
            this.btnBuscarInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarInsumo.BackColor = System.Drawing.Color.White;
            this.btnBuscarInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarInsumo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.btnBuscarInsumo.Location = new System.Drawing.Point(368, 41);
            this.btnBuscarInsumo.Name = "btnBuscarInsumo";
            this.btnBuscarInsumo.Size = new System.Drawing.Size(52, 30);
            this.btnBuscarInsumo.TabIndex = 79;
            this.btnBuscarInsumo.Text = "...";
            this.btnBuscarInsumo.UseVisualStyleBackColor = false;
            this.btnBuscarInsumo.Click += new System.EventHandler(this.btnBuscarInsumo_Click);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtid.Location = new System.Drawing.Point(196, 41);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(157, 30);
            this.txtid.TabIndex = 77;
            // 
            // lblidProd
            // 
            this.lblidProd.AutoSize = true;
            this.lblidProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidProd.ForeColor = System.Drawing.Color.White;
            this.lblidProd.Location = new System.Drawing.Point(33, 41);
            this.lblidProd.Name = "lblidProd";
            this.lblidProd.Size = new System.Drawing.Size(164, 25);
            this.lblidProd.TabIndex = 76;
            this.lblidProd.Text = "ID Linea Insumo: ";
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
            this.lblPresentacion.Location = new System.Drawing.Point(495, 100);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(68, 25);
            this.lblPresentacion.TabIndex = 34;
            this.lblPresentacion.Text = "Stock:";
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNom.Location = new System.Drawing.Point(145, 97);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(313, 30);
            this.txtNom.TabIndex = 35;
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtStock.Location = new System.Drawing.Point(569, 100);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(99, 30);
            this.txtStock.TabIndex = 38;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.LinkColor = System.Drawing.Color.AliceBlue;
            this.lblBack.Location = new System.Drawing.Point(863, 54);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(79, 17);
            this.lblBack.TabIndex = 81;
            this.lblBack.TabStop = true;
            this.lblBack.Text = "< Regresar";
            this.lblBack.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // frmModCalidadI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(983, 459);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmModCalidadI";
            this.Text = "frmModCalidadI";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btnBuscarInsumo;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblidProd;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.LinkLabel lblBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLote;
    }
}