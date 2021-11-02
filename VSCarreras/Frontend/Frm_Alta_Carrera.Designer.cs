
namespace Frontend
{
    partial class Frm_Alta_Carrera
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
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAñoMax = new System.Windows.Forms.Label();
            this.lblAñoDeCursada = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.rbtnSegundo = new System.Windows.Forms.RadioButton();
            this.rbtnPrimero = new System.Windows.Forms.RadioButton();
            this.rbtnAnual = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lstCarrera = new System.Windows.Forms.ListBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvMateria = new System.Windows.Forms.DataGridView();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nudAnioCursado = new System.Windows.Forms.NumericUpDown();
            this.nudCantidadAnios = new System.Windows.Forms.NumericUpDown();
            this.btnMateria = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimized = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAnioCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCursado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAnios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarrera.ForeColor = System.Drawing.Color.White;
            this.lblCarrera.Location = new System.Drawing.Point(13, 11);
            this.lblCarrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(227, 19);
            this.lblCarrera.TabIndex = 0;
            this.lblCarrera.Text = "ADMINISTRADOR DE CARRERAS";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(35, 83);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(74, 19);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(35, 180);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(62, 19);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "TÍTULO";
            // 
            // lblAñoMax
            // 
            this.lblAñoMax.AutoSize = true;
            this.lblAñoMax.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAñoMax.ForeColor = System.Drawing.Color.White;
            this.lblAñoMax.Location = new System.Drawing.Point(35, 281);
            this.lblAñoMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAñoMax.Name = "lblAñoMax";
            this.lblAñoMax.Size = new System.Drawing.Size(157, 19);
            this.lblAñoMax.TabIndex = 17;
            this.lblAñoMax.Text = "CANTIDAD DE AÑOS";
            // 
            // lblAñoDeCursada
            // 
            this.lblAñoDeCursada.AutoSize = true;
            this.lblAñoDeCursada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAñoDeCursada.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAñoDeCursada.ForeColor = System.Drawing.Color.White;
            this.lblAñoDeCursada.Location = new System.Drawing.Point(342, 265);
            this.lblAñoDeCursada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAñoDeCursada.Name = "lblAñoDeCursada";
            this.lblAñoDeCursada.Size = new System.Drawing.Size(123, 17);
            this.lblAñoDeCursada.TabIndex = 18;
            this.lblAñoDeCursada.Text = "AÑO DE CURSADO";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMateria.ForeColor = System.Drawing.Color.White;
            this.lblMateria.Location = new System.Drawing.Point(342, 83);
            this.lblMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(69, 18);
            this.lblMateria.TabIndex = 20;
            this.lblMateria.Text = "MATERIA";
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCuatrimestre.ForeColor = System.Drawing.Color.White;
            this.lblCuatrimestre.Location = new System.Drawing.Point(342, 195);
            this.lblCuatrimestre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(110, 18);
            this.lblCuatrimestre.TabIndex = 19;
            this.lblCuatrimestre.Text = "CUATRIMESTRE";
            // 
            // cboMateria
            // 
            this.cboMateria.BackColor = System.Drawing.Color.Lavender;
            this.cboMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMateria.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(345, 112);
            this.cboMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(256, 24);
            this.cboMateria.TabIndex = 8;
            // 
            // rbtnSegundo
            // 
            this.rbtnSegundo.AutoSize = true;
            this.rbtnSegundo.FlatAppearance.BorderSize = 0;
            this.rbtnSegundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnSegundo.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnSegundo.ForeColor = System.Drawing.Color.White;
            this.rbtnSegundo.Location = new System.Drawing.Point(499, 194);
            this.rbtnSegundo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnSegundo.Name = "rbtnSegundo";
            this.rbtnSegundo.Size = new System.Drawing.Size(73, 20);
            this.rbtnSegundo.TabIndex = 5;
            this.rbtnSegundo.TabStop = true;
            this.rbtnSegundo.Text = "Segundo";
            this.rbtnSegundo.UseVisualStyleBackColor = true;
            // 
            // rbtnPrimero
            // 
            this.rbtnPrimero.AutoSize = true;
            this.rbtnPrimero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtnPrimero.FlatAppearance.BorderSize = 0;
            this.rbtnPrimero.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnPrimero.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnPrimero.ForeColor = System.Drawing.Color.White;
            this.rbtnPrimero.Location = new System.Drawing.Point(499, 169);
            this.rbtnPrimero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnPrimero.Name = "rbtnPrimero";
            this.rbtnPrimero.Size = new System.Drawing.Size(69, 20);
            this.rbtnPrimero.TabIndex = 4;
            this.rbtnPrimero.TabStop = true;
            this.rbtnPrimero.Text = "Primero";
            this.rbtnPrimero.UseVisualStyleBackColor = true;
            // 
            // rbtnAnual
            // 
            this.rbtnAnual.AutoSize = true;
            this.rbtnAnual.FlatAppearance.BorderSize = 0;
            this.rbtnAnual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnAnual.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnAnual.ForeColor = System.Drawing.Color.White;
            this.rbtnAnual.Location = new System.Drawing.Point(499, 217);
            this.rbtnAnual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnAnual.Name = "rbtnAnual";
            this.rbtnAnual.Size = new System.Drawing.Size(55, 20);
            this.rbtnAnual.TabIndex = 6;
            this.rbtnAnual.TabStop = true;
            this.rbtnAnual.Text = "Anual";
            this.rbtnAnual.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Lavender;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.Location = new System.Drawing.Point(35, 118);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(269, 18);
            this.txtNombre.TabIndex = 0;
            // 
            // lstCarrera
            // 
            this.lstCarrera.BackColor = System.Drawing.Color.Lavender;
            this.lstCarrera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCarrera.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstCarrera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstCarrera.FormattingEnabled = true;
            this.lstCarrera.ItemHeight = 16;
            this.lstCarrera.Location = new System.Drawing.Point(625, 83);
            this.lstCarrera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstCarrera.Name = "lstCarrera";
            this.lstCarrera.Size = new System.Drawing.Size(235, 272);
            this.lstCarrera.TabIndex = 7;
            this.lstCarrera.SelectedIndexChanged += new System.EventHandler(this.lstCarrera_SelectedIndexChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(35, 582);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(95, 42);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvMateria
            // 
            this.dgvMateria.AllowUserToAddRows = false;
            this.dgvMateria.AllowUserToDeleteRows = false;
            this.dgvMateria.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvMateria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Cuatrimestre,
            this.Materia,
            this.ColAnioCursado,
            this.Acciones});
            this.dgvMateria.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMateria.Location = new System.Drawing.Point(35, 376);
            this.dgvMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMateria.Name = "dgvMateria";
            this.dgvMateria.ReadOnly = true;
            this.dgvMateria.Size = new System.Drawing.Size(825, 170);
            this.dgvMateria.TabIndex = 9;
            this.dgvMateria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMateria_CellContentClick_1);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.Lavender;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitulo.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTitulo.Location = new System.Drawing.Point(35, 218);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(269, 18);
            this.txtTitulo.TabIndex = 1;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(155, 582);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(95, 42);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(282, 582);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(95, 42);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(508, 582);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 42);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Confirmar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(635, 582);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 42);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nudAnioCursado
            // 
            this.nudAnioCursado.BackColor = System.Drawing.Color.Lavender;
            this.nudAnioCursado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudAnioCursado.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudAnioCursado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudAnioCursado.Location = new System.Drawing.Point(495, 261);
            this.nudAnioCursado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudAnioCursado.Name = "nudAnioCursado";
            this.nudAnioCursado.Size = new System.Drawing.Size(106, 21);
            this.nudAnioCursado.TabIndex = 3;
            this.nudAnioCursado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudCantidadAnios
            // 
            this.nudCantidadAnios.BackColor = System.Drawing.Color.Lavender;
            this.nudCantidadAnios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCantidadAnios.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudCantidadAnios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudCantidadAnios.Location = new System.Drawing.Point(198, 279);
            this.nudCantidadAnios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudCantidadAnios.Name = "nudCantidadAnios";
            this.nudCantidadAnios.Size = new System.Drawing.Size(106, 21);
            this.nudCantidadAnios.TabIndex = 2;
            this.nudCantidadAnios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMateria
            // 
            this.btnMateria.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMateria.FlatAppearance.BorderSize = 0;
            this.btnMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMateria.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMateria.ForeColor = System.Drawing.Color.White;
            this.btnMateria.Location = new System.Drawing.Point(345, 316);
            this.btnMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMateria.Name = "btnMateria";
            this.btnMateria.Size = new System.Drawing.Size(256, 38);
            this.btnMateria.TabIndex = 21;
            this.btnMateria.Text = "Agregar Materia";
            this.btnMateria.UseVisualStyleBackColor = false;
            this.btnMateria.Click += new System.EventHandler(this.btnMateria_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(760, 582);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 42);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMinimized);
            this.panel1.Controls.Add(this.lblCarrera);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 45);
            this.panel1.TabIndex = 23;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Frontend.Properties.Resources.Pasted_20211101_130216_preview_rev_1;
            this.btnClose.Location = new System.Drawing.Point(908, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 25;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Image = global::Frontend.Properties.Resources.minimizar;
            this.btnMinimized.Location = new System.Drawing.Point(871, 5);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(31, 29);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimized.TabIndex = 24;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Cuatrimestre
            // 
            this.Cuatrimestre.HeaderText = "Cuatrimestre";
            this.Cuatrimestre.Name = "Cuatrimestre";
            this.Cuatrimestre.ReadOnly = true;
            this.Cuatrimestre.Width = 130;
            // 
            // Materia
            // 
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            this.Materia.Width = 350;
            // 
            // ColAnioCursado
            // 
            this.ColAnioCursado.HeaderText = "Año de Cursado";
            this.ColAnioCursado.Name = "ColAnioCursado";
            this.ColAnioCursado.ReadOnly = true;
            this.ColAnioCursado.Width = 150;
            // 
            // Acciones
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Acciones.DefaultCellStyle = dataGridViewCellStyle1;
            this.Acciones.HeaderText = "Acciones";
            this.Acciones.Name = "Acciones";
            this.Acciones.ReadOnly = true;
            this.Acciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Acciones.Text = "Quitar";
            this.Acciones.UseColumnTextForButtonValue = true;
            this.Acciones.Width = 130;
            // 
            // Frm_Alta_Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(933, 674);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMateria);
            this.Controls.Add(this.nudCantidadAnios);
            this.Controls.Add(this.nudAnioCursado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.dgvMateria);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lstCarrera);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.rbtnAnual);
            this.Controls.Add(this.rbtnPrimero);
            this.Controls.Add(this.rbtnSegundo);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblAñoDeCursada);
            this.Controls.Add(this.lblAñoMax);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_Alta_Carrera";
            this.Text = "Gestionar Carreras";
            this.Load += new System.EventHandler(this.Frm_Alta_Carrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCursado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAnios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAñoMax;
        private System.Windows.Forms.Label lblAñoDeCursada;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.RadioButton rbtnSegundo;
        private System.Windows.Forms.RadioButton rbtnPrimero;
        private System.Windows.Forms.RadioButton rbtnAnual;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListBox lstCarrera;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvMateria;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nudAnioCursado;
        private System.Windows.Forms.NumericUpDown nudCantidadAnios;
        private System.Windows.Forms.Button btnMateria;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimized;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAnioCursado;
        private System.Windows.Forms.DataGridViewButtonColumn Acciones;
    }
}