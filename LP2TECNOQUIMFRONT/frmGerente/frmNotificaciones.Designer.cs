namespace LP2TECNOQUIMFRONT.frmGerente
{
    partial class frmNotificaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotificaciones));
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvHistorialPlan = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnNotificaciones = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnGestionarEmpleados = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPlan)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNombre.Location = new System.Drawing.Point(199, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(127, 24);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Notificaciones";
            // 
            // dgvHistorialPlan
            // 
            this.dgvHistorialPlan.AllowUserToAddRows = false;
            this.dgvHistorialPlan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorialPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Presentacion});
            this.dgvHistorialPlan.Location = new System.Drawing.Point(203, 75);
            this.dgvHistorialPlan.Name = "dgvHistorialPlan";
            this.dgvHistorialPlan.ReadOnly = true;
            this.dgvHistorialPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialPlan.Size = new System.Drawing.Size(843, 398);
            this.dgvHistorialPlan.TabIndex = 30;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Fecha";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Presentacion
            // 
            this.Presentacion.FillWeight = 150F;
            this.Presentacion.HeaderText = "Descripcion";
            this.Presentacion.Name = "Presentacion";
            this.Presentacion.ReadOnly = true;
            this.Presentacion.Width = 600;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.btnGestionarEmpleados);
            this.panel1.Controls.Add(this.btnPerfil);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnNotificaciones);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 511);
            this.panel1.TabIndex = 32;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.Location = new System.Drawing.Point(0, 165);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(163, 79);
            this.btnPerfil.TabIndex = 6;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnNotificaciones
            // 
            this.btnNotificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotificaciones.FlatAppearance.BorderSize = 0;
            this.btnNotificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificaciones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificaciones.ForeColor = System.Drawing.Color.White;
            this.btnNotificaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnNotificaciones.Image")));
            this.btnNotificaciones.Location = new System.Drawing.Point(0, 236);
            this.btnNotificaciones.Name = "btnNotificaciones";
            this.btnNotificaciones.Size = new System.Drawing.Size(163, 92);
            this.btnNotificaciones.TabIndex = 5;
            this.btnNotificaciones.Text = "Notificaciones";
            this.btnNotificaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNotificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNotificaciones.UseVisualStyleBackColor = true;
            this.btnNotificaciones.Click += new System.EventHandler(this.btnNotificaciones_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "Inicio";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(150)))), ((int)(((byte)(19)))));
            this.panel3.Controls.Add(this.pbLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 99);
            this.panel3.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::LP2TECNOQUIMFRONT.Properties.Resources.logo_web;
            this.pbLogo.Location = new System.Drawing.Point(0, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(163, 92);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // btnGestionarEmpleados
            // 
            this.btnGestionarEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionarEmpleados.FlatAppearance.BorderSize = 0;
            this.btnGestionarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarEmpleados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnGestionarEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionarEmpleados.Image")));
            this.btnGestionarEmpleados.Location = new System.Drawing.Point(0, 400);
            this.btnGestionarEmpleados.Name = "btnGestionarEmpleados";
            this.btnGestionarEmpleados.Size = new System.Drawing.Size(163, 92);
            this.btnGestionarEmpleados.TabIndex = 34;
            this.btnGestionarEmpleados.Text = "Gestionar Empleados";
            this.btnGestionarEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGestionarEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGestionarEmpleados.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(0, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 79);
            this.button2.TabIndex = 33;
            this.button2.Text = "Gestionar Plan Maestro";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvHistorialPlan);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNotificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNotificaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNotificaciones_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPlan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvHistorialPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnNotificaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGestionarEmpleados;
        private System.Windows.Forms.Button button2;
    }
}