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
            this.lblBack = new System.Windows.Forms.LinkLabel();
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
            this.dgvListaOrden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaOrden_CellContentClick);
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
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.LinkColor = System.Drawing.Color.AliceBlue;
            this.lblBack.Location = new System.Drawing.Point(570, 41);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(79, 17);
            this.lblBack.TabIndex = 80;
            this.lblBack.TabStop = true;
            this.lblBack.Text = "< Regresar";
            this.lblBack.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // frmListaOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(704, 425);
            this.Controls.Add(this.lblBack);
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
        private System.Windows.Forms.LinkLabel lblBack;
    }
}