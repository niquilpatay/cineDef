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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.consultaClientesTickets2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSClientesTicketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSClientesTickets = new cineLabo.DSClientesTickets();
            this.rvClientesTickets = new Microsoft.Reporting.WinForms.ReportViewer();
            this.consultaClientesTickets2TableAdapter = new cineLabo.DSClientesTicketsTableAdapters.consultaClientesTickets2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.consultaClientesTickets2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTicketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // consultaClientesTickets2BindingSource
            // 
            this.consultaClientesTickets2BindingSource.DataMember = "consultaClientesTickets2";
            this.consultaClientesTickets2BindingSource.DataSource = this.dSClientesTicketsBindingSource;
            // 
            // dSClientesTicketsBindingSource
            // 
            this.dSClientesTicketsBindingSource.DataSource = this.dSClientesTickets;
            this.dSClientesTicketsBindingSource.Position = 0;
            // 
            // dSClientesTickets
            // 
            this.dSClientesTickets.DataSetName = "DSClientesTickets";
            this.dSClientesTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvClientesTickets
            // 
            reportDataSource3.Name = "DSClientesTickets2";
            reportDataSource3.Value = this.consultaClientesTickets2BindingSource;
            this.rvClientesTickets.LocalReport.DataSources.Add(reportDataSource3);
            this.rvClientesTickets.LocalReport.ReportEmbeddedResource = "cineLabo.rptClientesTickets2.rdlc";
            this.rvClientesTickets.Location = new System.Drawing.Point(12, 12);
            this.rvClientesTickets.Name = "rvClientesTickets";
            this.rvClientesTickets.ServerReport.BearerToken = null;
            this.rvClientesTickets.Size = new System.Drawing.Size(909, 558);
            this.rvClientesTickets.TabIndex = 0;
            // 
            // consultaClientesTickets2TableAdapter
            // 
            this.consultaClientesTickets2TableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteClientesTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cineLabo.Properties.Resources.pochoclo;
            this.ClientSize = new System.Drawing.Size(933, 582);
            this.Controls.Add(this.rvClientesTickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmReporteClientesTickets";
            this.Text = "CLIENTES & TICKETS";
            this.Load += new System.EventHandler(this.frmReporteClientesTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultaClientesTickets2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTicketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvClientesTickets;
        private System.Windows.Forms.BindingSource dSClientesTicketsBindingSource;
        private DSClientesTickets dSClientesTickets;
        private System.Windows.Forms.BindingSource consultaClientesTickets2BindingSource;
        private DSClientesTicketsTableAdapters.consultaClientesTickets2TableAdapter consultaClientesTickets2TableAdapter;
    }
}