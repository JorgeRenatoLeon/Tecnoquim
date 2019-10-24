using System;

namespace LP2TECNOQUIMFRONT.frmPrincipal
{
    partial class frmLogin
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblLinea1 = new System.Windows.Forms.Label();
            this.lblLinea2 = new System.Windows.Forms.Label();
            this.lblLinea3 = new System.Windows.Forms.Label();
            this.lblLinea4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUsuario.Location = new System.Drawing.Point(326, 222);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(199, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Tag = "";
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuarioEnter);
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTest_KeyDown);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuarioLeave);
            // 
            // txtContrasena
            // 
            this.txtContrasena.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtContrasena.Location = new System.Drawing.Point(326, 267);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(199, 20);
            this.txtContrasena.TabIndex = 1;
            this.txtContrasena.Text = "Contrasena";
            this.txtContrasena.UseSystemPasswordChar = true;
            this.txtContrasena.Enter += new System.EventHandler(this.txtContrasenaEnter);
            this.txtContrasena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTest_KeyDown);
            this.txtContrasena.Leave += new System.EventHandler(this.txtContrasenaLeave);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(150)))), ((int)(((byte)(19)))));
            this.lblUsuario.Location = new System.Drawing.Point(135, 224);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(150)))), ((int)(((byte)(19)))));
            this.lblContrasena.Location = new System.Drawing.Point(135, 270);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(61, 13);
            this.lblContrasena.TabIndex = 4;
            this.lblContrasena.Text = "Contraseña";
            // 
            // lblLinea1
            // 
            this.lblLinea1.AutoSize = true;
            this.lblLinea1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(150)))), ((int)(((byte)(19)))));
            this.lblLinea1.Location = new System.Drawing.Point(237, 224);
            this.lblLinea1.Name = "lblLinea1";
            this.lblLinea1.Size = new System.Drawing.Size(64, 13);
            this.lblLinea1.TabIndex = 5;
            this.lblLinea1.Text = "-------------------";
            // 
            // lblLinea2
            // 
            this.lblLinea2.AutoSize = true;
            this.lblLinea2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(150)))), ((int)(((byte)(19)))));
            this.lblLinea2.Location = new System.Drawing.Point(237, 270);
            this.lblLinea2.Name = "lblLinea2";
            this.lblLinea2.Size = new System.Drawing.Size(64, 13);
            this.lblLinea2.TabIndex = 6;
            this.lblLinea2.Text = "-------------------";
            // 
            // lblLinea3
            // 
            this.lblLinea3.AutoSize = true;
            this.lblLinea3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(150)))), ((int)(((byte)(19)))));
            this.lblLinea3.Location = new System.Drawing.Point(543, 224);
            this.lblLinea3.Name = "lblLinea3";
            this.lblLinea3.Size = new System.Drawing.Size(64, 13);
            this.lblLinea3.TabIndex = 7;
            this.lblLinea3.Text = "-------------------";
            // 
            // lblLinea4
            // 
            this.lblLinea4.AutoSize = true;
            this.lblLinea4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(150)))), ((int)(((byte)(19)))));
            this.lblLinea4.Location = new System.Drawing.Point(543, 270);
            this.lblLinea4.Name = "lblLinea4";
            this.lblLinea4.Size = new System.Drawing.Size(64, 13);
            this.lblLinea4.TabIndex = 8;
            this.lblLinea4.Text = "-------------------";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(338, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::LP2TECNOQUIMFRONT.Properties.Resources.logo_web;
            this.pictureBox1.Location = new System.Drawing.Point(299, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 92);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pbMinimize
            // 
            this.pbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimize.Image = global::LP2TECNOQUIMFRONT.Properties.Resources.minimazar;
            this.pbMinimize.Location = new System.Drawing.Point(758, 4);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(12, 14);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 10;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.Image = global::LP2TECNOQUIMFRONT.Properties.Resources.cerrar;
            this.pbCerrar.Location = new System.Drawing.Point(776, 4);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(12, 14);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 12;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.pbMinimize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLinea4);
            this.Controls.Add(this.lblLinea3);
            this.Controls.Add(this.lblLinea2);
            this.Controls.Add(this.lblLinea1);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTest_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblLinea1;
        private System.Windows.Forms.Label lblLinea2;
        private System.Windows.Forms.Label lblLinea3;
        private System.Windows.Forms.Label lblLinea4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbCerrar;
    }
}