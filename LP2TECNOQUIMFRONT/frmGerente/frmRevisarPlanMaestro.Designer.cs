namespace LP2TECNOQUIMFRONT.frmGerente
{
    partial class frmRevisarPlanMaestro
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
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rbDesaprobado = new System.Windows.Forms.RadioButton();
            this.rbAprobado = new System.Windows.Forms.RadioButton();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbOrden = new System.Windows.Forms.GroupBox();
            this.dgvOrden = new System.Windows.Forms.DataGridView();
            this.CodigoOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calOrdenProduccion = new System.Windows.Forms.MonthCalendar();
            this.dgvMaquinaria = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maquinaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbMaquinaria = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbEstado.SuspendLayout();
            this.gbOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinaria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbMaquinaria.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.rbDesaprobado);
            this.gbEstado.Controls.Add(this.rbAprobado);
            this.gbEstado.Controls.Add(this.txtComentario);
            this.gbEstado.Controls.Add(this.label7);
            this.gbEstado.Controls.Add(this.label8);
            this.gbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbEstado.Location = new System.Drawing.Point(21, 698);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(801, 149);
            this.gbEstado.TabIndex = 36;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado:";
            // 
            // rbDesaprobado
            // 
            this.rbDesaprobado.AutoSize = true;
            this.rbDesaprobado.Location = new System.Drawing.Point(342, 43);
            this.rbDesaprobado.Name = "rbDesaprobado";
            this.rbDesaprobado.Size = new System.Drawing.Size(159, 29);
            this.rbDesaprobado.TabIndex = 25;
            this.rbDesaprobado.TabStop = true;
            this.rbDesaprobado.Text = "Desaprobado";
            this.rbDesaprobado.UseVisualStyleBackColor = true;
            // 
            // rbAprobado
            // 
            this.rbAprobado.AutoSize = true;
            this.rbAprobado.Location = new System.Drawing.Point(154, 43);
            this.rbAprobado.Name = "rbAprobado";
            this.rbAprobado.Size = new System.Drawing.Size(123, 29);
            this.rbAprobado.TabIndex = 24;
            this.rbAprobado.TabStop = true;
            this.rbAprobado.Text = "Aprobado";
            this.rbAprobado.UseVisualStyleBackColor = true;
            // 
            // txtComentario
            // 
            this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.Location = new System.Drawing.Point(154, 91);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(627, 29);
            this.txtComentario.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Comentario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Estado:";
            // 
            // gbOrden
            // 
            this.gbOrden.Controls.Add(this.dgvOrden);
            this.gbOrden.Controls.Add(this.calOrdenProduccion);
            this.gbOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrden.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbOrden.Location = new System.Drawing.Point(21, 231);
            this.gbOrden.Name = "gbOrden";
            this.gbOrden.Size = new System.Drawing.Size(801, 217);
            this.gbOrden.TabIndex = 42;
            this.gbOrden.TabStop = false;
            this.gbOrden.Text = "Ordenes de Producción";
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
            this.dgvOrden.Location = new System.Drawing.Point(313, 36);
            this.dgvOrden.Name = "dgvOrden";
            this.dgvOrden.ReadOnly = true;
            this.dgvOrden.RowHeadersWidth = 50;
            this.dgvOrden.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrden.Size = new System.Drawing.Size(444, 162);
            this.dgvOrden.TabIndex = 41;
            this.dgvOrden.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrden_CellFormatting_1);
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
            this.calOrdenProduccion.Location = new System.Drawing.Point(29, 36);
            this.calOrdenProduccion.Name = "calOrdenProduccion";
            this.calOrdenProduccion.TabIndex = 40;
            this.calOrdenProduccion.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calOrdenProduccion_DateChanged);
            // 
            // dgvMaquinaria
            // 
            this.dgvMaquinaria.AllowUserToAddRows = false;
            this.dgvMaquinaria.AllowUserToDeleteRows = false;
            this.dgvMaquinaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquinaria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Maquinaria,
            this.tipo});
            this.dgvMaquinaria.Location = new System.Drawing.Point(14, 39);
            this.dgvMaquinaria.Name = "dgvMaquinaria";
            this.dgvMaquinaria.ReadOnly = true;
            this.dgvMaquinaria.RowHeadersWidth = 50;
            this.dgvMaquinaria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaquinaria.Size = new System.Drawing.Size(767, 162);
            this.dgvMaquinaria.TabIndex = 41;
            this.dgvMaquinaria.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMaquinaria_CellFormatting);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 165;
            // 
            // Maquinaria
            // 
            this.Maquinaria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Maquinaria.FillWeight = 150F;
            this.Maquinaria.HeaderText = "Maquinaria";
            this.Maquinaria.Name = "Maquinaria";
            this.Maquinaria.ReadOnly = true;
            this.Maquinaria.Width = 350;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResponsable);
            this.groupBox1.Controls.Add(this.lblResponsable);
            this.groupBox1.Controls.Add(this.txtPeriodo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 203);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Plan Maestro";
            // 
            // txtResponsable
            // 
            this.txtResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsable.Location = new System.Drawing.Point(184, 145);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(524, 29);
            this.txtResponsable.TabIndex = 24;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.Location = new System.Drawing.Point(37, 148);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(126, 24);
            this.lblResponsable.TabIndex = 23;
            this.lblResponsable.Text = "Responsable:";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodo.Location = new System.Drawing.Point(184, 97);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(342, 29);
            this.txtPeriodo.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Periodo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(184, 47);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(152, 29);
            this.txtCodigo.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nro. Plan:";
            // 
            // gbMaquinaria
            // 
            this.gbMaquinaria.Controls.Add(this.dgvMaquinaria);
            this.gbMaquinaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMaquinaria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbMaquinaria.Location = new System.Drawing.Point(21, 454);
            this.gbMaquinaria.Name = "gbMaquinaria";
            this.gbMaquinaria.Size = new System.Drawing.Size(801, 225);
            this.gbMaquinaria.TabIndex = 39;
            this.gbMaquinaria.TabStop = false;
            this.gbMaquinaria.Text = "Maquinaria";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.btnGuardar.Location = new System.Drawing.Point(319, 866);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 44);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // frmRevisarPlanMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(842, 768);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbOrden);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbMaquinaria);
            this.Controls.Add(this.gbEstado);
            this.Name = "frmRevisarPlanMaestro";
            this.Text = "frmGestionarPlanMaestro";
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.gbOrden.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinaria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMaquinaria.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.RadioButton rbDesaprobado;
        private System.Windows.Forms.RadioButton rbAprobado;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbOrden;
        private System.Windows.Forms.DataGridView dgvMaquinaria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbMaquinaria;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maquinaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridView dgvOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.MonthCalendar calOrdenProduccion;
    }
}