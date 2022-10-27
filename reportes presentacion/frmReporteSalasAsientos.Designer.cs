namespace cineLabo.reportes
{
    partial class frmReporteSalasAsientos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.consultaSalasAsientos2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSClientesTickets = new cineLabo.DSClientesTickets();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.consultaSalasAsientos2TableAdapter = new cineLabo.DSClientesTicketsTableAdapters.consultaSalasAsientos2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.consultaSalasAsientos2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // consultaSalasAsientos2BindingSource
            // 
            this.consultaSalasAsientos2BindingSource.DataMember = "consultaSalasAsientos2";
            this.consultaSalasAsientos2BindingSource.DataSource = this.dSClientesTickets;
            // 
            // dSClientesTickets
            // 
            this.dSClientesTickets.DataSetName = "DSClientesTickets";
            this.dSClientesTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DSSalasAsientos";
            reportDataSource2.Value = this.consultaSalasAsientos2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "cineLabo.rptSalasAsientos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // consultaSalasAsientos2TableAdapter
            // 
            this.consultaSalasAsientos2TableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteSalasAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cineLabo.Properties.Resources.pochoclo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteSalasAsientos";
            this.Text = "SALAS Y SU CANT. DE ASIENTOS";
            this.Load += new System.EventHandler(this.frmReporteSalasAsientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultaSalasAsientos2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DSClientesTickets dSClientesTickets;
        private System.Windows.Forms.BindingSource consultaSalasAsientos2BindingSource;
        private DSClientesTicketsTableAdapters.consultaSalasAsientos2TableAdapter consultaSalasAsientos2TableAdapter;
    }
}