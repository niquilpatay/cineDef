namespace cineLabo.reportes_presentacion
{
    partial class frmReporteClientesPorMes
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
            this.rvClientesMes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.consultaClientesComprasMes2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSClientesTickets = new cineLabo.DSClientesTickets();
            this.consultaClientesComprasMes2TableAdapter = new cineLabo.DSClientesTicketsTableAdapters.consultaClientesComprasMes2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.consultaClientesComprasMes2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // rvClientesMes
            // 
            reportDataSource2.Name = "DSClientesComprasMes";
            reportDataSource2.Value = this.consultaClientesComprasMes2BindingSource;
            this.rvClientesMes.LocalReport.DataSources.Add(reportDataSource2);
            this.rvClientesMes.LocalReport.ReportEmbeddedResource = "cineLabo.rptClientesComprasMes.rdlc";
            this.rvClientesMes.Location = new System.Drawing.Point(12, 57);
            this.rvClientesMes.Name = "rvClientesMes";
            this.rvClientesMes.ServerReport.BearerToken = null;
            this.rvClientesMes.Size = new System.Drawing.Size(467, 311);
            this.rvClientesMes.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(361, 19);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(88, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mes:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // consultaClientesComprasMes2BindingSource
            // 
            this.consultaClientesComprasMes2BindingSource.DataMember = "consultaClientesComprasMes2";
            this.consultaClientesComprasMes2BindingSource.DataSource = this.dSClientesTickets;
            // 
            // dSClientesTickets
            // 
            this.dSClientesTickets.DataSetName = "DSClientesTickets";
            this.dSClientesTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultaClientesComprasMes2TableAdapter
            // 
            this.consultaClientesComprasMes2TableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteClientesPorMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cineLabo.Properties.Resources.pochoclo;
            this.ClientSize = new System.Drawing.Size(494, 380);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.rvClientesMes);
            this.Name = "frmReporteClientesPorMes";
            this.Text = "CLIENTES POR MES";
            this.Load += new System.EventHandler(this.frmReporteClientesPorMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultaClientesComprasMes2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvClientesMes;
        private System.Windows.Forms.BindingSource consultaClientesComprasMes2BindingSource;
        private DSClientesTickets dSClientesTickets;
        private DSClientesTicketsTableAdapters.consultaClientesComprasMes2TableAdapter consultaClientesComprasMes2TableAdapter;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}