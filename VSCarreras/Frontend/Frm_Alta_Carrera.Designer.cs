
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
            this.DgvMateria = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAnioCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.numAnioCursado = new System.Windows.Forms.NumericUpDown();
            this.nudCantidadAnios = new System.Windows.Forms.NumericUpDown();
            this.btnMateria = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnioCursado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAnios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(30, 43);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(155, 24);
            this.lblCarrera.TabIndex = 0;
            this.lblCarrera.Text = "Ingrese Carrera";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(46, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(46, 162);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Título";
            // 
            // lblAñoMax
            // 
            this.lblAñoMax.AutoSize = true;
            this.lblAñoMax.Location = new System.Drawing.Point(46, 223);
            this.lblAñoMax.Name = "lblAñoMax";
            this.lblAñoMax.Size = new System.Drawing.Size(90, 13);
            this.lblAñoMax.TabIndex = 17;
            this.lblAñoMax.Text = "Cantidad de años";
            // 
            // lblAñoDeCursada
            // 
            this.lblAñoDeCursada.AutoSize = true;
            this.lblAñoDeCursada.Location = new System.Drawing.Point(296, 230);
            this.lblAñoDeCursada.Name = "lblAñoDeCursada";
            this.lblAñoDeCursada.Size = new System.Drawing.Size(83, 13);
            this.lblAñoDeCursada.TabIndex = 18;
            this.lblAñoDeCursada.Text = "Año de Cursado";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(296, 100);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 20;
            this.lblMateria.Text = "Materia";
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Location = new System.Drawing.Point(293, 169);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(65, 13);
            this.lblCuatrimestre.TabIndex = 19;
            this.lblCuatrimestre.Text = "Cuatrimestre";
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(344, 97);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(172, 21);
            this.cboMateria.TabIndex = 8;
            this.cboMateria.SelectedIndexChanged += new System.EventHandler(this.cboMateria_SelectedIndexChanged);
            // 
            // rbtnSegundo
            // 
            this.rbtnSegundo.AutoSize = true;
            this.rbtnSegundo.Location = new System.Drawing.Point(385, 169);
            this.rbtnSegundo.Name = "rbtnSegundo";
            this.rbtnSegundo.Size = new System.Drawing.Size(68, 17);
            this.rbtnSegundo.TabIndex = 5;
            this.rbtnSegundo.TabStop = true;
            this.rbtnSegundo.Text = "Segundo";
            this.rbtnSegundo.UseVisualStyleBackColor = true;
            // 
            // rbtnPrimero
            // 
            this.rbtnPrimero.AutoSize = true;
            this.rbtnPrimero.Location = new System.Drawing.Point(385, 146);
            this.rbtnPrimero.Name = "rbtnPrimero";
            this.rbtnPrimero.Size = new System.Drawing.Size(60, 17);
            this.rbtnPrimero.TabIndex = 4;
            this.rbtnPrimero.TabStop = true;
            this.rbtnPrimero.Text = "Primero";
            this.rbtnPrimero.UseVisualStyleBackColor = true;
            // 
            // rbtnAnual
            // 
            this.rbtnAnual.AutoSize = true;
            this.rbtnAnual.Location = new System.Drawing.Point(385, 192);
            this.rbtnAnual.Name = "rbtnAnual";
            this.rbtnAnual.Size = new System.Drawing.Size(52, 17);
            this.rbtnAnual.TabIndex = 6;
            this.rbtnAnual.TabStop = true;
            this.rbtnAnual.Text = "Anual";
            this.rbtnAnual.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lstCarrera
            // 
            this.lstCarrera.FormattingEnabled = true;
            this.lstCarrera.Location = new System.Drawing.Point(535, 43);
            this.lstCarrera.Name = "lstCarrera";
            this.lstCarrera.Size = new System.Drawing.Size(202, 264);
            this.lstCarrera.TabIndex = 7;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(49, 517);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // DgvMateria
            // 
            this.DgvMateria.AllowUserToAddRows = false;
            this.DgvMateria.AllowUserToDeleteRows = false;
            this.DgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Cuatrimestre,
            this.ColMateria,
            this.ColAnioCursado,
            this.Acciones});
            this.DgvMateria.Location = new System.Drawing.Point(49, 326);
            this.DgvMateria.Name = "DgvMateria";
            this.DgvMateria.ReadOnly = true;
            this.DgvMateria.Size = new System.Drawing.Size(688, 147);
            this.DgvMateria.TabIndex = 9;
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
            // 
            // ColMateria
            // 
            this.ColMateria.HeaderText = "Materia";
            this.ColMateria.Name = "ColMateria";
            this.ColMateria.ReadOnly = true;
            // 
            // ColAnioCursado
            // 
            this.ColAnioCursado.HeaderText = "Año de Cursado";
            this.ColAnioCursado.Name = "ColAnioCursado";
            this.ColAnioCursado.ReadOnly = true;
            // 
            // Acciones
            // 
            this.Acciones.HeaderText = "Acciones";
            this.Acciones.Name = "Acciones";
            this.Acciones.ReadOnly = true;
            this.Acciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Acciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Acciones.Text = "Quitar";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(130, 162);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(131, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(157, 517);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(272, 517);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(458, 517);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(561, 517);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // numAnioCursado
            // 
            this.numAnioCursado.Location = new System.Drawing.Point(385, 228);
            this.numAnioCursado.Name = "numAnioCursado";
            this.numAnioCursado.Size = new System.Drawing.Size(91, 20);
            this.numAnioCursado.TabIndex = 3;
            // 
            // nudCantidadAnios
            // 
            this.nudCantidadAnios.Location = new System.Drawing.Point(170, 221);
            this.nudCantidadAnios.Name = "nudCantidadAnios";
            this.nudCantidadAnios.Size = new System.Drawing.Size(91, 20);
            this.nudCantidadAnios.TabIndex = 2;
            // 
            // btnMateria
            // 
            this.btnMateria.Location = new System.Drawing.Point(296, 263);
            this.btnMateria.Name = "btnMateria";
            this.btnMateria.Size = new System.Drawing.Size(100, 23);
            this.btnMateria.TabIndex = 21;
            this.btnMateria.Text = "Agregar Materia";
            this.btnMateria.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(662, 517);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Frm_Alta_Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMateria);
            this.Controls.Add(this.nudCantidadAnios);
            this.Controls.Add(this.numAnioCursado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.DgvMateria);
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
            this.Controls.Add(this.lblCarrera);
            this.Name = "Frm_Alta_Carrera";
            this.Text = "Gestionar Carreras";
            this.Load += new System.EventHandler(this.Frm_Alta_Carrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnioCursado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAnios)).EndInit();
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
        private System.Windows.Forms.DataGridView DgvMateria;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown numAnioCursado;
        private System.Windows.Forms.NumericUpDown nudCantidadAnios;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAnioCursado;
        private System.Windows.Forms.DataGridViewButtonColumn Acciones;
        private System.Windows.Forms.Button btnMateria;
        private System.Windows.Forms.Button btnSalir;
    }
}