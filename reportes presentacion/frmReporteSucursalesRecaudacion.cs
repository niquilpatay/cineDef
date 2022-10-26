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
    public partial class frmReporteSucursalesRecaudacion : Form
    {
        public frmReporteSucursalesRecaudacion()
        {
            InitializeComponent();
        }

        private void frmReporteSucursalesRecaudacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSClientesTickets.Sucursales' Puede moverla o quitarla según sea necesario.
            this.sucursalesTableAdapter.Fill(this.dSClientesTickets.Sucursales);

            this.reportViewer1.RefreshReport();
        }
    }
}
