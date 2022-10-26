using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cineLabo.reportes
{
    public partial class frmReporteClientesTickets : Form
    {
        public frmReporteClientesTickets()
        {
            InitializeComponent();
        }

        private void frmReporteClientesTickets_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSClientesTickets.consultaClientesTickets2' Puede moverla o quitarla según sea necesario.
            this.consultaClientesTickets2TableAdapter.Fill(this.dSClientesTickets.consultaClientesTickets2);

            this.rvClientesTickets.RefreshReport();
        }
    }
}
