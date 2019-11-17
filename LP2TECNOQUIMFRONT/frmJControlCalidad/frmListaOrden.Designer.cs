namespace LP2TECNOQUIMFRONT.frmJControlCalidad
{
    partial class frmListaOrden
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
            this.dgvListaOrden = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarInsumo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaOrden
            // 
            this.dgvListaOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Cantidad});
            this.dgvListaOrden.Location = new System.Drawing.Point(59, 101);
            this.dgvListaOrden.Name = "dgvListaOrden";
            this.dgvListaOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaOrden.Size = new System.Drawing.Size(582, 275);
            this.dgvListaOrden.TabIndex = 0;
            this.dgvListaOrden.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaOrden_CellContentDoubleClick);
            this.dgvListaOrden.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.Width = 300;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Linea de Orden";
            // 
            // btnBuscarInsumo
            // 
            this.btnBuscarInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarInsumo.BackColor = System.Drawing.Color.White;
            this.btnBuscarInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarInsumo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.btnBuscarInsumo.Location = new System.Drawing.Point(529, 44);
            this.btnBuscarInsumo.Name = "btnBuscarInsumo";
            this.btnBuscarInsumo.Size = new System.Drawing.Size(112, 25);
            this.btnBuscarInsumo.TabIndex = 80;
            this.btnBuscarInsumo.Text = "Seleccionar";
            this.btnBuscarInsumo.UseVisualStyleBackColor = false;
            this.btnBuscarInsumo.Click += new System.EventHandler(this.btnBuscarInsumo_Click);
            // 
            // frmListaOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(704, 425);
            this.Controls.Add(this.btnBuscarInsumo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaOrden);
            this.Name = "frmListaOrden";
            this.Text = "frmListaOrden";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarInsumo;
    }
}