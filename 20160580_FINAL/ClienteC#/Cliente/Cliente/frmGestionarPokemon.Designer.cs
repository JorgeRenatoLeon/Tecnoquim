namespace Cliente
{
    partial class frmGestionarPokemon
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarPokemon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.lblNro = new System.Windows.Forms.Label();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.lblTipo1 = new System.Windows.Forms.Label();
            this.cboTipo1 = new System.Windows.Forms.ComboBox();
            this.panelPokemon = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelTipos = new System.Windows.Forms.Panel();
            this.panelTipo2 = new System.Windows.Forms.Panel();
            this.lblTipo2 = new System.Windows.Forms.Label();
            this.cboTipo2 = new System.Windows.Forms.ComboBox();
            this.panelTipo1 = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblKg = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblMetros = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblLevelUpMoves = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvLevelUpMoves = new System.Windows.Forms.DataGridView();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.dialogoBusqArchivo = new System.Windows.Forms.OpenFileDialog();
            this.LV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RANGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMenu.SuspendLayout();
            this.panelPokemon.SuspendLayout();
            this.panelTipos.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevelUpMoves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnEliminar,
            this.btnGuardar,
            this.btnBuscar,
            this.btnCancelar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(827, 28);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "tsMenu";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(76, 25);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(96, 25);
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 25);
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 25);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 25);
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 25);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.ForeColor = System.Drawing.Color.Black;
            this.lblNro.Location = new System.Drawing.Point(9, 15);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(42, 20);
            this.lblNro.TabIndex = 1;
            this.lblNro.Text = "Nro:";
            this.lblNro.Click += new System.EventHandler(this.lblNationalPokedex_Click);
            // 
            // txtNro
            // 
            this.txtNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNro.Location = new System.Drawing.Point(53, 12);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(100, 26);
            this.txtNro.TabIndex = 2;
            // 
            // lblTipo1
            // 
            this.lblTipo1.AutoSize = true;
            this.lblTipo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo1.Location = new System.Drawing.Point(13, 29);
            this.lblTipo1.Name = "lblTipo1";
            this.lblTipo1.Size = new System.Drawing.Size(63, 20);
            this.lblTipo1.TabIndex = 4;
            this.lblTipo1.Text = "Tipo 1:";
            // 
            // cboTipo1
            // 
            this.cboTipo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo1.FormattingEnabled = true;
            this.cboTipo1.Location = new System.Drawing.Point(82, 26);
            this.cboTipo1.Name = "cboTipo1";
            this.cboTipo1.Size = new System.Drawing.Size(214, 28);
            this.cboTipo1.TabIndex = 5;
            this.cboTipo1.SelectedIndexChanged += new System.EventHandler(this.cboTipo1_SelectedIndexChanged);
            // 
            // panelPokemon
            // 
            this.panelPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPokemon.Controls.Add(this.txtNombre);
            this.panelPokemon.Controls.Add(this.lblNombre);
            this.panelPokemon.Controls.Add(this.lblNro);
            this.panelPokemon.Controls.Add(this.txtNro);
            this.panelPokemon.Location = new System.Drawing.Point(12, 31);
            this.panelPokemon.Name = "panelPokemon";
            this.panelPokemon.Size = new System.Drawing.Size(447, 90);
            this.panelPokemon.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(84, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(350, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(9, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // panelTipos
            // 
            this.panelTipos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTipos.Controls.Add(this.panelTipo2);
            this.panelTipos.Controls.Add(this.lblTipo2);
            this.panelTipos.Controls.Add(this.cboTipo2);
            this.panelTipos.Controls.Add(this.panelTipo1);
            this.panelTipos.Controls.Add(this.lblTipo1);
            this.panelTipos.Controls.Add(this.cboTipo1);
            this.panelTipos.Location = new System.Drawing.Point(465, 31);
            this.panelTipos.Name = "panelTipos";
            this.panelTipos.Size = new System.Drawing.Size(350, 132);
            this.panelTipos.TabIndex = 4;
            // 
            // panelTipo2
            // 
            this.panelTipo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTipo2.Location = new System.Drawing.Point(66, 67);
            this.panelTipo2.Name = "panelTipo2";
            this.panelTipo2.Size = new System.Drawing.Size(279, 19);
            this.panelTipo2.TabIndex = 7;
            // 
            // lblTipo2
            // 
            this.lblTipo2.AutoSize = true;
            this.lblTipo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo2.Location = new System.Drawing.Point(13, 94);
            this.lblTipo2.Name = "lblTipo2";
            this.lblTipo2.Size = new System.Drawing.Size(63, 20);
            this.lblTipo2.TabIndex = 8;
            this.lblTipo2.Text = "Tipo 2:";
            // 
            // cboTipo2
            // 
            this.cboTipo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo2.FormattingEnabled = true;
            this.cboTipo2.Location = new System.Drawing.Point(82, 91);
            this.cboTipo2.Name = "cboTipo2";
            this.cboTipo2.Size = new System.Drawing.Size(214, 28);
            this.cboTipo2.TabIndex = 9;
            this.cboTipo2.SelectedIndexChanged += new System.EventHandler(this.cboTipo2_SelectedIndexChanged);
            // 
            // panelTipo1
            // 
            this.panelTipo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTipo1.Location = new System.Drawing.Point(66, 3);
            this.panelTipo1.Name = "panelTipo1";
            this.panelTipo1.Size = new System.Drawing.Size(279, 19);
            this.panelTipo1.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(218, 152);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(108, 20);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(221, 177);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(594, 101);
            this.txtDescripcion.TabIndex = 15;
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKg.Location = new System.Drawing.Point(169, 10);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(33, 20);
            this.lblKg.TabIndex = 18;
            this.lblKg.Text = "kg.";
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(63, 7);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 26);
            this.txtPeso.TabIndex = 17;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(8, 10);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(54, 20);
            this.lblPeso.TabIndex = 16;
            this.lblPeso.Text = "Peso:";
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetros.Location = new System.Drawing.Point(430, 10);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(28, 20);
            this.lblMetros.TabIndex = 21;
            this.lblMetros.Text = "m.";
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(324, 7);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 26);
            this.txtAltura.TabIndex = 20;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(260, 10);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(62, 20);
            this.lblAltura.TabIndex = 19;
            this.lblAltura.Text = "Altura:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtPeso);
            this.panel4.Controls.Add(this.lblMetros);
            this.panel4.Controls.Add(this.lblPeso);
            this.panel4.Controls.Add(this.txtAltura);
            this.panel4.Controls.Add(this.lblKg);
            this.panel4.Controls.Add(this.lblAltura);
            this.panel4.Location = new System.Drawing.Point(221, 284);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(594, 42);
            this.panel4.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblLevelUpMoves);
            this.panel5.Controls.Add(this.btnRemover);
            this.panel5.Controls.Add(this.btnAgregar);
            this.panel5.Controls.Add(this.dgvLevelUpMoves);
            this.panel5.Location = new System.Drawing.Point(13, 341);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(802, 225);
            this.panel5.TabIndex = 24;
            // 
            // lblLevelUpMoves
            // 
            this.lblLevelUpMoves.AutoSize = true;
            this.lblLevelUpMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelUpMoves.Location = new System.Drawing.Point(8, 9);
            this.lblLevelUpMoves.Name = "lblLevelUpMoves";
            this.lblLevelUpMoves.Size = new System.Drawing.Size(140, 20);
            this.lblLevelUpMoves.TabIndex = 22;
            this.lblLevelUpMoves.Text = "Level Up Moves:";
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(203, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(44, 30);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "-";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(153, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(44, 30);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvLevelUpMoves
            // 
            this.dgvLevelUpMoves.AllowUserToAddRows = false;
            this.dgvLevelUpMoves.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLevelUpMoves.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLevelUpMoves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLevelUpMoves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LV,
            this.NOMBRE,
            this.TIPO,
            this.CAT,
            this.POW,
            this.ACC,
            this.PP,
            this.RANGO});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLevelUpMoves.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLevelUpMoves.Location = new System.Drawing.Point(12, 40);
            this.dgvLevelUpMoves.Name = "dgvLevelUpMoves";
            this.dgvLevelUpMoves.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvLevelUpMoves.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLevelUpMoves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLevelUpMoves.Size = new System.Drawing.Size(785, 167);
            this.dgvLevelUpMoves.TabIndex = 0;
            this.dgvLevelUpMoves.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPokemon_CellFormatting);
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.BackgroundImage = global::Cliente.Properties.Resources.upload_icon_3;
            this.btnSubirFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirFoto.Location = new System.Drawing.Point(171, 130);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(40, 33);
            this.btnSubirFoto.TabIndex = 23;
            this.btnSubirFoto.UseVisualStyleBackColor = true;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(13, 130);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(198, 196);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 3;
            this.pbFoto.TabStop = false;
            // 
            // dialogoBusqArchivo
            // 
            this.dialogoBusqArchivo.FileName = "dialogoBusqArchivo";
            // 
            // LV
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LV.DefaultCellStyle = dataGridViewCellStyle2;
            this.LV.HeaderText = "LV";
            this.LV.Name = "LV";
            this.LV.ReadOnly = true;
            this.LV.Width = 65;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            // 
            // CAT
            // 
            this.CAT.HeaderText = "CAT";
            this.CAT.Name = "CAT";
            this.CAT.ReadOnly = true;
            // 
            // POW
            // 
            this.POW.HeaderText = "POW";
            this.POW.Name = "POW";
            this.POW.ReadOnly = true;
            this.POW.Width = 70;
            // 
            // ACC
            // 
            this.ACC.HeaderText = "ACC";
            this.ACC.Name = "ACC";
            this.ACC.ReadOnly = true;
            this.ACC.Width = 70;
            // 
            // PP
            // 
            this.PP.HeaderText = "PP";
            this.PP.Name = "PP";
            this.PP.ReadOnly = true;
            this.PP.Width = 70;
            // 
            // RANGO
            // 
            this.RANGO.HeaderText = "RANGO";
            this.RANGO.Name = "RANGO";
            this.RANGO.ReadOnly = true;
            this.RANGO.Width = 130;
            // 
            // frmGestionarPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 578);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnSubirFoto);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.panelTipos);
            this.Controls.Add(this.panelPokemon);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.pbFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGestionarPokemon";
            this.Text = "Formulario de Gestión de Pokémon";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.panelPokemon.ResumeLayout(false);
            this.panelPokemon.PerformLayout();
            this.panelTipos.ResumeLayout(false);
            this.panelTipos.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevelUpMoves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ComboBox cboTipo1;
        private System.Windows.Forms.Label lblTipo1;
        private System.Windows.Forms.Panel panelPokemon;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelTipos;
        private System.Windows.Forms.Panel panelTipo2;
        private System.Windows.Forms.Label lblTipo2;
        private System.Windows.Forms.ComboBox cboTipo2;
        private System.Windows.Forms.Panel panelTipo1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblMetros;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSubirFoto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvLevelUpMoves;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblLevelUpMoves;
        private System.Windows.Forms.OpenFileDialog dialogoBusqArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn POW;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PP;
        private System.Windows.Forms.DataGridViewTextBoxColumn RANGO;
    }
}

