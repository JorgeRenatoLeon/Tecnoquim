namespace LP2TECNOQUIMFRONT.frmJproduccion
{
    partial class frmGestionPoliticaStock
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
            this.lblProducto = new System.Windows.Forms.Label();
            this.gbPoliticaStock = new System.Windows.Forms.GroupBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblCodigoPMP = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblStockMin = new System.Windows.Forms.Label();
            this.lblStockMax = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.gbPoliticaStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(45, 41);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(91, 24);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto:";
            // 
            // gbPoliticaStock
            // 
            this.gbPoliticaStock.Controls.Add(this.txtMax);
            this.gbPoliticaStock.Controls.Add(this.txtMin);
            this.gbPoliticaStock.Controls.Add(this.btnGuardar);
            this.gbPoliticaStock.Controls.Add(this.lblStockMax);
            this.gbPoliticaStock.Controls.Add(this.lblStockMin);
            this.gbPoliticaStock.Controls.Add(this.btnBuscarProducto);
            this.gbPoliticaStock.Controls.Add(this.txtProducto);
            this.gbPoliticaStock.Controls.Add(this.lblProducto);
            this.gbPoliticaStock.Controls.Add(this.lblCodigoPMP);
            this.gbPoliticaStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPoliticaStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbPoliticaStock.Location = new System.Drawing.Point(12, 12);
            this.gbPoliticaStock.Name = "gbPoliticaStock";
            this.gbPoliticaStock.Size = new System.Drawing.Size(699, 296);
            this.gbPoliticaStock.TabIndex = 32;
            this.gbPoliticaStock.TabStop = false;
            this.gbPoliticaStock.Text = "Política de Stock";
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(227, 36);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(374, 29);
            this.txtProducto.TabIndex = 20;
            // 
            // lblCodigoPMP
            // 
            this.lblCodigoPMP.AutoSize = true;
            this.lblCodigoPMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPMP.Location = new System.Drawing.Point(39, 36);
            this.lblCodigoPMP.Name = "lblCodigoPMP";
            this.lblCodigoPMP.Size = new System.Drawing.Size(0, 24);
            this.lblCodigoPMP.TabIndex = 19;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarProducto.Location = new System.Drawing.Point(625, 38);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(32, 26);
            this.btnBuscarProducto.TabIndex = 37;
            this.btnBuscarProducto.Text = "...";
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // lblStockMin
            // 
            this.lblStockMin.AutoSize = true;
            this.lblStockMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMin.Location = new System.Drawing.Point(44, 108);
            this.lblStockMin.Name = "lblStockMin";
            this.lblStockMin.Size = new System.Drawing.Size(128, 24);
            this.lblStockMin.TabIndex = 38;
            this.lblStockMin.Text = "Stock mínimo:";
            // 
            // lblStockMax
            // 
            this.lblStockMax.AutoSize = true;
            this.lblStockMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMax.Location = new System.Drawing.Point(45, 188);
            this.lblStockMax.Name = "lblStockMax";
            this.lblStockMax.Size = new System.Drawing.Size(133, 24);
            this.lblStockMax.TabIndex = 39;
            this.lblStockMax.Text = "Stock máximo:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(186, 245);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 35);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(227, 105);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(168, 29);
            this.txtMin.TabIndex = 41;
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(227, 185);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(168, 29);
            this.txtMax.TabIndex = 42;
            // 
            // frmGestionPoliticaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(738, 320);
            this.Controls.Add(this.gbPoliticaStock);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "frmGestionPoliticaStock";
            this.Text = "frmGestionPoliticaStock";
            this.gbPoliticaStock.ResumeLayout(false);
            this.gbPoliticaStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.GroupBox gbPoliticaStock;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblCodigoPMP;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblStockMax;
        private System.Windows.Forms.Label lblStockMin;
    }
}