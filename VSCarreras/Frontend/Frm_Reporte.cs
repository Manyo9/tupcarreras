using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Frm_Reporte : Form
    {
        private DataGridView dgvRepo;
        private Label label1;
        private Button btnReporte;
        private Panel panel1;
        private PictureBox btnCerrar;
        private DataGridViewTextBoxColumn ColMateria;
        private DataGridViewTextBoxColumn ColMaterias;
        private PictureBox btnMinimized;

        public Frm_Reporte()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRepo = new System.Windows.Forms.DataGridView();
            this.ColMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaterias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimized = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRepo
            // 
            this.dgvRepo.AllowUserToAddRows = false;
            this.dgvRepo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvRepo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRepo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRepo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRepo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMateria,
            this.ColMaterias});
            this.dgvRepo.GridColor = System.Drawing.Color.LightGray;
            this.dgvRepo.Location = new System.Drawing.Point(37, 139);
            this.dgvRepo.Name = "dgvRepo";
            this.dgvRepo.ReadOnly = true;
            this.dgvRepo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvRepo.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvRepo.RowTemplate.Height = 25;
            this.dgvRepo.Size = new System.Drawing.Size(447, 183);
            this.dgvRepo.TabIndex = 0;
            // 
            // ColMateria
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ColMateria.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColMateria.HeaderText = "Carrera";
            this.ColMateria.Name = "ColMateria";
            this.ColMateria.ReadOnly = true;
            this.ColMateria.Width = 205;
            // 
            // ColMaterias
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.ColMaterias.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColMaterias.HeaderText = "Cantidad de Materias";
            this.ColMaterias.Name = "ColMaterias";
            this.ColMaterias.ReadOnly = true;
            this.ColMaterias.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(99, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "CANTIDAD DE MATERIAS POR CARRERA";
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(250, 337);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(234, 32);
            this.btnReporte.TabIndex = 2;
            this.btnReporte.Text = "VER REPORTE";
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnMinimized);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 35);
            this.panel1.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::Frontend.Properties.Resources.Pasted_20211101_130216_preview_rev_1;
            this.btnCerrar.Location = new System.Drawing.Point(485, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(31, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Image = global::Frontend.Properties.Resources.minimizar;
            this.btnMinimized.Location = new System.Drawing.Point(453, 3);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(28, 32);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimized.TabIndex = 4;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // Frm_Reporte
            // 
            this.ClientSize = new System.Drawing.Size(521, 404);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRepo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Reporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Reporte_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_Reporte_Load_1(object sender, EventArgs e)
        {

        }
    }
}
