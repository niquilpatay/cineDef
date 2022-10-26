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
    public partial class frmReporteSalasAsientos : Form
    {
        public frmReporteSalasAsientos()
        {
            InitializeComponent();
        }

        private void frmReporteSalasAsientos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSClientesTickets.consultaSalasAsientos2' Puede moverla o quitarla según sea necesario.
            this.consultaSalasAsientos2TableAdapter.Fill(this.dSClientesTickets.consultaSalasAsientos2);

            this.reportViewer1.RefreshReport();
        }
    }
}
