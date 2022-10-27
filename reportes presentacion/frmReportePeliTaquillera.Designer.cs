namespace cineLabo.reportes_presentacion
{
    partial class frmReportePeliTaquillera
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
            this.consultaPelisTaquilleras2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSClientesTickets = new cineLabo.DSClientesTickets();
            this.reportViewerPeliT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.consultaPelisTaquilleras2TableAdapter = new cineLabo.DSClientesTicketsTableAdapters.consultaPelisTaquilleras2TableAdapter();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultarPeli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.consultaPelisTaquilleras2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // consultaPelisTaquilleras2BindingSource
            // 
            this.consultaPelisTaquilleras2BindingSource.DataMember = "consultaPelisTaquilleras2";
            this.consultaPelisTaquilleras2BindingSource.DataSource = this.dSClientesTickets;
            // 
            // dSClientesTickets
            // 
            this.dSClientesTickets.DataSetName = "DSClientesTickets";
            this.dSClientesTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerPeliT
            // 
            reportDataSource3.Name = "DSPelisTaquilleras";
            reportDataSource3.Value = this.consultaPelisTaquilleras2BindingSource;
            this.reportViewerPeliT.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerPeliT.LocalReport.ReportEmbeddedResource = "cineLabo.rptPeliTaquillera.rdlc";
            this.reportViewerPeliT.Location = new System.Drawing.Point(18, 48);
            this.reportViewerPeliT.Name = "reportViewerPeliT";
            this.reportViewerPeliT.ServerReport.BearerToken = null;
            this.reportViewerPeliT.Size = new System.Drawing.Size(624, 336);
            this.reportViewerPeliT.TabIndex = 0;
            // 
            // consultaPelisTaquilleras2TableAdapter
            // 
            this.consultaPelisTaquilleras2TableAdapter.ClearBeforeFill = true;
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(259, 12);
            this.nudAnio.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudAnio.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(120, 20);
            this.nudAnio.TabIndex = 1;
            this.nudAnio.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Año:";
            // 
            // btnConsultarPeli
            // 
            this.btnConsultarPeli.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPeli.Location = new System.Drawing.Point(398, 9);
            this.btnConsultarPeli.Name = "btnConsultarPeli";
            this.btnConsultarPeli.Size = new System.Drawing.Size(82, 33);
            this.btnConsultarPeli.TabIndex = 3;
            this.btnConsultarPeli.Text = "consultar";
            this.btnConsultarPeli.UseVisualStyleBackColor = true;
            this.btnConsultarPeli.Click += new System.EventHandler(this.btnConsultarPeli_Click);
            // 
            // frmReportePeliTaquillera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cineLabo.Properties.Resources.pochoclo;
            this.ClientSize = new System.Drawing.Size(666, 396);
            this.Controls.Add(this.btnConsultarPeli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.reportViewerPeliT);
            this.Name = "frmReportePeliTaquillera";
            this.Text = "PELÍCULA + TAQUILLERA POR AÑO";
            this.Load += new System.EventHandler(this.frmReportePeliTaquillera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultaPelisTaquilleras2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPeliT;
        private System.Windows.Forms.BindingSource consultaPelisTaquilleras2BindingSource;
        private DSClientesTickets dSClientesTickets;
        private DSClientesTicketsTableAdapters.consultaPelisTaquilleras2TableAdapter consultaPelisTaquilleras2TableAdapter;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarPeli;
    }
}