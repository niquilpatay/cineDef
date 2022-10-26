namespace cineLabo.reportes
{
    partial class frmReporteClientesTickets
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSClientesTickets = new cineLabo.DSClientesTickets();
            this.dSClientesTicketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaClientesTickets2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaClientesTickets2TableAdapter = new cineLabo.DSClientesTicketsTableAdapters.consultaClientesTickets2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTicketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaClientesTickets2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSClientesTickets2";
            reportDataSource1.Value = this.consultaClientesTickets2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "cineLabo.rptClientesTickets2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSClientesTickets
            // 
            this.dSClientesTickets.DataSetName = "DSClientesTickets";
            this.dSClientesTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSClientesTicketsBindingSource
            // 
            this.dSClientesTicketsBindingSource.DataSource = this.dSClientesTickets;
            this.dSClientesTicketsBindingSource.Position = 0;
            // 
            // consultaClientesTickets2BindingSource
            // 
            this.consultaClientesTickets2BindingSource.DataMember = "consultaClientesTickets2";
            this.consultaClientesTickets2BindingSource.DataSource = this.dSClientesTicketsBindingSource;
            // 
            // consultaClientesTickets2TableAdapter
            // 
            this.consultaClientesTickets2TableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteClientesTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteClientesTickets";
            this.Text = "frmReporteClientesTickets";
            this.Load += new System.EventHandler(this.frmReporteClientesTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTicketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaClientesTickets2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dSClientesTicketsBindingSource;
        private DSClientesTickets dSClientesTickets;
        private System.Windows.Forms.BindingSource consultaClientesTickets2BindingSource;
        private DSClientesTicketsTableAdapters.consultaClientesTickets2TableAdapter consultaClientesTickets2TableAdapter;
    }
}