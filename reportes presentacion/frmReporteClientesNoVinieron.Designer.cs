namespace cineLabo.reportes_presentacion
{
    partial class frmReporteClientesNoVinieron
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.paconsulta6BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSClientesTickets = new cineLabo.DSClientesTickets();
            this.paconsulta6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pa_consulta_6TableAdapter = new cineLabo.DSClientesTicketsTableAdapters.pa_consulta_6TableAdapter();
            this.Desde = new System.Windows.Forms.Label();
            this.Consultar = new System.Windows.Forms.Button();
            this.dtpDesde2 = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pa_consulta_6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.paconsulta6BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paconsulta6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pa_consulta_6BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // paconsulta6BindingSource1
            // 
            this.paconsulta6BindingSource1.DataMember = "pa_consulta_6";
            this.paconsulta6BindingSource1.DataSource = this.dSClientesTickets;
            // 
            // dSClientesTickets
            // 
            this.dSClientesTickets.DataSetName = "DSClientesTickets";
            this.dSClientesTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paconsulta6BindingSource
            // 
            this.paconsulta6BindingSource.DataMember = "pa_consulta_6";
            this.paconsulta6BindingSource.DataSource = this.dSClientesTickets;
            // 
            // pa_consulta_6TableAdapter
            // 
            this.pa_consulta_6TableAdapter.ClearBeforeFill = true;
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.BackColor = System.Drawing.Color.Transparent;
            this.Desde.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desde.Location = new System.Drawing.Point(39, 36);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(85, 33);
            this.Desde.TabIndex = 4;
            this.Desde.Text = "Desde";
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.Color.Transparent;
            this.Consultar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar.Location = new System.Drawing.Point(506, 36);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(94, 31);
            this.Consultar.TabIndex = 1;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = false;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // dtpDesde2
            // 
            this.dtpDesde2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde2.Location = new System.Drawing.Point(130, 45);
            this.dtpDesde2.Name = "dtpDesde2";
            this.dtpDesde2.Size = new System.Drawing.Size(117, 20);
            this.dtpDesde2.TabIndex = 6;
            this.dtpDesde2.Value = new System.DateTime(2022, 10, 26, 0, 0, 0, 0);
            // 
            // dtpHasta2
            // 
            this.dtpHasta2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta2.Location = new System.Drawing.Point(368, 46);
            this.dtpHasta2.Name = "dtpHasta2";
            this.dtpHasta2.Size = new System.Drawing.Size(117, 20);
            this.dtpHasta2.TabIndex = 3;
            this.dtpHasta2.Value = new System.DateTime(2022, 10, 26, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hasta";
            // 
            // pa_consulta_6BindingSource
            // 
            this.pa_consulta_6BindingSource.DataMember = "pa_consulta_6";
            this.pa_consulta_6BindingSource.DataSource = this.dSClientesTickets;
            // 
            // reportViewer2
            // 
            this.reportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            reportDataSource4.Name = "DSClientesNoVinieron";
            reportDataSource4.Value = this.paconsulta6BindingSource1;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "cineLabo.rptConsultaClientesNoVinieron.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(45, 96);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(573, 292);
            this.reportViewer2.TabIndex = 0;
            // 
            // frmReporteClientesNoVinieron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImage = global::cineLabo.Properties.Resources.pochoclo;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.Desde);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.dtpHasta2);
            this.Controls.Add(this.dtpDesde2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmReporteClientesNoVinieron";
            this.Text = "CLIENTES QUE NO VINIERON ENTRE 2 FECHAS";
            this.Load += new System.EventHandler(this.frmReporteClientesNoVinieron_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paconsulta6BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paconsulta6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pa_consulta_6BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource paconsulta6BindingSource;
        private DSClientesTickets dSClientesTickets;
        private DSClientesTicketsTableAdapters.pa_consulta_6TableAdapter pa_consulta_6TableAdapter;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.DateTimePicker dtpDesde2;
        private System.Windows.Forms.DateTimePicker dtpHasta2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource pa_consulta_6BindingSource;
        private System.Windows.Forms.BindingSource paconsulta6BindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}