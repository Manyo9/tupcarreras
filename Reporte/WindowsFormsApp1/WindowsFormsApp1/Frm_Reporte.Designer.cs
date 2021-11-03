
namespace WindowsFormsApp1
{
    partial class Frm_Reporte
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSListado = new WindowsFormsApp1.DSListado();
            this.Repo_CarreraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Repo_CarreraTableAdapter = new WindowsFormsApp1.DSListadoTableAdapters.Repo_CarreraTableAdapter();
            this.repoCarreraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DSListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_CarreraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCarreraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.repoCarreraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.ReporteCarrera.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSListado
            // 
            this.DSListado.DataSetName = "DSListado";
            this.DSListado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Repo_CarreraBindingSource
            // 
            this.Repo_CarreraBindingSource.DataMember = "Repo_Carrera";
            this.Repo_CarreraBindingSource.DataSource = this.DSListado;
            // 
            // Repo_CarreraTableAdapter
            // 
            this.Repo_CarreraTableAdapter.ClearBeforeFill = true;
            // 
            // repoCarreraBindingSource
            // 
            this.repoCarreraBindingSource.DataMember = "Repo_Carrera";
            this.repoCarreraBindingSource.DataSource = this.DSListado;
            // 
            // Frm_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Reporte";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_CarreraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCarreraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Repo_CarreraBindingSource;
        private DSListado DSListado;
        private DSListadoTableAdapters.Repo_CarreraTableAdapter Repo_CarreraTableAdapter;
        private System.Windows.Forms.BindingSource repoCarreraBindingSource;
    }
}

