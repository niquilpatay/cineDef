namespace cineLabo.reportes_presentacion
{
    partial class frmReporteSucursalPoranio
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
            this.spConsultarSucursalPoranioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSClientesTickets = new cineLabo.DSClientesTickets();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dtpAnio = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spConsultarSucursalPoranioTableAdapter = new cineLabo.DSClientesTicketsTableAdapters.spConsultarSucursalPoranioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultarSucursalPoranioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // spConsultarSucursalPoranioBindingSource
            // 
            this.spConsultarSucursalPoranioBindingSource.DataMember = "spConsultarSucursalPoranio";
            this.spConsultarSucursalPoranioBindingSource.DataSource = this.dSClientesTickets;
            // 
            // dSClientesTickets
            // 
            this.dSClientesTickets.DataSetName = "DSClientesTickets";
            this.dSClientesTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Año del cual se quieren mostrar los datos";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(632, 17);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(125, 33);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtpAnio
            // 
            this.dtpAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAnio.Location = new System.Drawing.Point(340, 28);
            this.dtpAnio.Name = "dtpAnio";
            this.dtpAnio.Size = new System.Drawing.Size(267, 22);
            this.dtpAnio.TabIndex = 3;
            this.dtpAnio.Value = new System.DateTime(2022, 10, 26, 0, 0, 0, 0);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DSSucursalPorAnioConsulta";
            reportDataSource2.Value = this.spConsultarSucursalPoranioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "cineLabo.rptSucursalPoranio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(133, 107);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 6;
            // 
            // spConsultarSucursalPoranioTableAdapter
            // 
            this.spConsultarSucursalPoranioTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteSucursalPoranio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cineLabo.Properties.Resources.pochoclo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtpAnio);
            this.Name = "frmReporteSucursalPoranio";
            this.Text = "frmReporteSucursalPoranio";
            this.Load += new System.EventHandler(this.frmReporteSucursalPoranio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spConsultarSucursalPoranioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DateTimePicker dtpAnio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spConsultarSucursalPoranioBindingSource;
        private DSClientesTickets dSClientesTickets;
        private DSClientesTicketsTableAdapters.spConsultarSucursalPoranioTableAdapter spConsultarSucursalPoranioTableAdapter;
    }
}