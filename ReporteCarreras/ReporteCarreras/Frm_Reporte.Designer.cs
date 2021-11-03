
namespace ReporteCarreras
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
            this.DSListado = new ReporteCarreras.DSListado();
            this.DTListadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTListadoTableAdapter = new ReporteCarreras.DSListadoTableAdapters.DTListadoTableAdapter();
            this.dTListadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DSListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTListadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTListadoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dTListadoBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReporteCarreras.ListadoCarreras.rdlc";
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
            // DTListadoBindingSource
            // 
            this.DTListadoBindingSource.DataMember = "DTListado";
            this.DTListadoBindingSource.DataSource = this.DSListado;
            // 
            // DTListadoTableAdapter
            // 
            this.DTListadoTableAdapter.ClearBeforeFill = true;
            // 
            // dTListadoBindingSource1
            // 
            this.dTListadoBindingSource1.DataMember = "DTListado";
            this.dTListadoBindingSource1.DataSource = this.DSListado;
            // 
            // Frm_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Reporte";
            this.Text = "Reporte Carreras";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTListadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTListadoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DTListadoBindingSource;
        private DSListado DSListado;
        private DSListadoTableAdapters.DTListadoTableAdapter DTListadoTableAdapter;
        private System.Windows.Forms.BindingSource dTListadoBindingSource1;
    }
}

