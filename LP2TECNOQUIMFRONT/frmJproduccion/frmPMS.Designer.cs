namespace LP2TECNOQUIMFRONT
{
    partial class frmPMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPMS));
            this.barra = new System.Windows.Forms.Panel();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMaximize = new System.Windows.Forms.PictureBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pbHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(90)))));
            this.barra.Controls.Add(this.pbMinimize);
            this.barra.Controls.Add(this.pbClose);
            this.barra.Controls.Add(this.pbMaximize);
            this.barra.Location = new System.Drawing.Point(172, 3);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(953, 35);
            this.barra.TabIndex = 18;
            // 
            // pbMinimize
            // 
            this.pbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimize.Image = global::LP2TECNOQUIMFRONT.Properties.Resources.minimazar;
            this.pbMinimize.Location = new System.Drawing.Point(839, 9);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(26, 22);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 17;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::LP2TECNOQUIMFRONT.Properties.Resources.cerrar;
            this.pbClose.Location = new System.Drawing.Point(903, 9);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 22);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 15;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbMaximize
            // 
            this.pbMaximize.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pbMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMaximize.Image = global::LP2TECNOQUIMFRONT.Properties.Resources.res;
            this.pbMaximize.Location = new System.Drawing.Point(871, 9);
            this.pbMaximize.Name = "pbMaximize";
            this.pbMaximize.Size = new System.Drawing.Size(26, 22);
            this.pbMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaximize.TabIndex = 16;
            this.pbMaximize.TabStop = false;
            this.pbMaximize.Click += new System.EventHandler(this.pbMaximize_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrear.BackColor = System.Drawing.Color.White;
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.btnCrear.Location = new System.Drawing.Point(431, 122);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(365, 65);
            this.btnCrear.TabIndex = 19;
            this.btnCrear.Text = "Crear Plan Maestro";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.btnModificar.Location = new System.Drawing.Point(431, 253);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(365, 65);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar Plan Maestro";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.button7.Location = new System.Drawing.Point(431, 391);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(365, 65);
            this.button7.TabIndex = 21;
            this.button7.Text = "Ver Historial";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(58)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnConsultas);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pbHome);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 550);
            this.panel1.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(0, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 79);
            this.button2.TabIndex = 6;
            this.button2.Text = "Perfil";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(0, 446);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 92);
            this.button6.TabIndex = 5;
            this.button6.Text = "Notificaciones";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnConsultas
            // 
            this.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultas.Image")));
            this.btnConsultas.Location = new System.Drawing.Point(0, 361);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(163, 79);
            this.btnConsultas.TabIndex = 1;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(2, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 79);
            this.button3.TabIndex = 1;
            this.button3.Text = "Calendario";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pbHome
            // 
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.FlatAppearance.BorderSize = 0;
            this.pbHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbHome.ForeColor = System.Drawing.Color.White;
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.Location = new System.Drawing.Point(0, 119);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(163, 79);
            this.pbHome.TabIndex = 1;
            this.pbHome.Text = "Inicio";
            this.pbHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pbHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pbHome.UseVisualStyleBackColor = true;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
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
            // frmPMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(1100, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPMS";
            this.barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMaximize;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button pbHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}