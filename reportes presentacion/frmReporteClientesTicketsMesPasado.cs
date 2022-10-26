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
    public partial class frmReporteClientesTicketsMesPasado : Form
    {
        public frmReporteClientesTicketsMesPasado()
        {
            InitializeComponent();
        }

        private void frmReporteClientesTicketsMesPasado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSClientesTickets.consultaClientesTicketsMesPasado' Puede moverla o quitarla según sea necesario.
            this.consultaClientesTicketsMesPasadoTableAdapter.Fill(this.dSClientesTickets.consultaClientesTicketsMesPasado);

            this.reportViewer1.RefreshReport();
        }
    }
}
