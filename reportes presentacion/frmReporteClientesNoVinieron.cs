using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cineLabo.reportes_presentacion
{
    public partial class frmReporteClientesNoVinieron : Form
    {
        public frmReporteClientesNoVinieron()
        {
            InitializeComponent();
        }

        private void frmReporteClientesNoVinieron_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSClientesTickets.pa_consulta_6' Puede moverla o quitarla según sea necesario.
           // this.pa_consulta_6TableAdapter.Fill(this.dSClientesTickets.pa_consulta_6);

            //this.reportViewer2.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            string fechaDesde = dtpDesde2.Text;
            string fechaHasta = dtpHasta2.Text;

            this.pa_consulta_6TableAdapter.Fill(this.dSClientesTickets.pa_consulta_6, fechaDesde, fechaHasta);
            this.reportViewer2.RefreshReport();
        }
    }
}
