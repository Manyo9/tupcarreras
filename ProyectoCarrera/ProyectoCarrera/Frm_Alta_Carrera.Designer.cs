
namespace ProyectoCarrera
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
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.rbtnSegundo = new System.Windows.Forms.RadioButton();
            this.rbtnPrimero = new System.Windows.Forms.RadioButton();
            this.rbtnAnual = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.numAnioCursado = new System.Windows.Forms.NumericUpDown();
            this.numAnioMax = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnioCursado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnioMax)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(30, 43);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(139, 19);
            this.lblCarrera.TabIndex = 0;
            this.lblCarrera.Text = "Ingrese Carrera";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(46, 84);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(46, 135);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Título";
            // 
            // lblAñoMax
            // 
            this.lblAñoMax.AutoSize = true;
            this.lblAñoMax.Location = new System.Drawing.Point(46, 177);
            this.lblAñoMax.Name = "lblAñoMax";
            this.lblAñoMax.Size = new System.Drawing.Size(65, 13);
            this.lblAñoMax.TabIndex = 3;
            this.lblAñoMax.Text = "Año Máximo";
            // 
            // lblAñoDeCursada
            // 
            this.lblAñoDeCursada.AutoSize = true;
            this.lblAñoDeCursada.Location = new System.Drawing.Point(46, 219);
            this.lblAñoDeCursada.Name = "lblAñoDeCursada";
            this.lblAñoDeCursada.Size = new System.Drawing.Size(83, 13);
            this.lblAñoDeCursada.TabIndex = 4;
            this.lblAñoDeCursada.Text = "Año de Cursado";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(536, 232);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 5;
            this.lblMateria.Text = "Materia";
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Location = new System.Drawing.Point(329, 154);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(65, 13);
            this.lblCuatrimestre.TabIndex = 6;
            this.lblCuatrimestre.Text = "Cuatrimestre";
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(617, 229);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(121, 21);
            this.cmbMateria.TabIndex = 7;
            // 
            // rbtnSegundo
            // 
            this.rbtnSegundo.AutoSize = true;
            this.rbtnSegundo.Location = new System.Drawing.Point(421, 152);
            this.rbtnSegundo.Name = "rbtnSegundo";
            this.rbtnSegundo.Size = new System.Drawing.Size(68, 17);
            this.rbtnSegundo.TabIndex = 8;
            this.rbtnSegundo.TabStop = true;
            this.rbtnSegundo.Text = "Segundo";
            this.rbtnSegundo.UseVisualStyleBackColor = true;
            // 
            // rbtnPrimero
            // 
            this.rbtnPrimero.AutoSize = true;
            this.rbtnPrimero.Location = new System.Drawing.Point(421, 129);
            this.rbtnPrimero.Name = "rbtnPrimero";
            this.rbtnPrimero.Size = new System.Drawing.Size(60, 17);
            this.rbtnPrimero.TabIndex = 9;
            this.rbtnPrimero.TabStop = true;
            this.rbtnPrimero.Text = "Primero";
            this.rbtnPrimero.UseVisualStyleBackColor = true;
            // 
            // rbtnAnual
            // 
            this.rbtnAnual.AutoSize = true;
            this.rbtnAnual.Location = new System.Drawing.Point(421, 175);
            this.rbtnAnual.Name = "rbtnAnual";
            this.rbtnAnual.Size = new System.Drawing.Size(52, 17);
            this.rbtnAnual.TabIndex = 10;
            this.rbtnAnual.TabStop = true;
            this.rbtnAnual.Text = "Anual";
            this.rbtnAnual.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(144, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(617, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 134);
            this.listBox1.TabIndex = 12;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(65, 442);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(688, 115);
            this.dataGridView1.TabIndex = 14;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(144, 132);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(131, 20);
            this.txtTitulo.TabIndex = 15;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(164, 442);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(280, 442);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(539, 442);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(647, 442);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // numAnioCursado
            // 
            this.numAnioCursado.Location = new System.Drawing.Point(184, 217);
            this.numAnioCursado.Name = "numAnioCursado";
            this.numAnioCursado.Size = new System.Drawing.Size(91, 20);
            this.numAnioCursado.TabIndex = 20;
            // 
            // numAnioMax
            // 
            this.numAnioMax.Location = new System.Drawing.Point(184, 177);
            this.numAnioMax.Name = "numAnioMax";
            this.numAnioMax.Size = new System.Drawing.Size(91, 20);
            this.numAnioMax.TabIndex = 21;
            // 
            // Frm_Alta_Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.numAnioMax);
            this.Controls.Add(this.numAnioCursado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.rbtnAnual);
            this.Controls.Add(this.rbtnPrimero);
            this.Controls.Add(this.rbtnSegundo);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblAñoDeCursada);
            this.Controls.Add(this.lblAñoMax);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCarrera);
            this.Name = "Frm_Alta_Carrera";
            this.Text = "Gestionar Carreras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnioCursado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnioMax)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.RadioButton rbtnSegundo;
        private System.Windows.Forms.RadioButton rbtnPrimero;
        private System.Windows.Forms.RadioButton rbtnAnual;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown numAnioCursado;
        private System.Windows.Forms.NumericUpDown numAnioMax;
    }
}