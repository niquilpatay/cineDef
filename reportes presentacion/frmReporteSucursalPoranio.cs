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
    public partial class frmReporteSucursalPoranio : Form
    {
        public frmReporteSucursalPoranio()
        {
            InitializeComponent();
        }

        private void frmReporteSucursalPoranio_Load(object sender, EventArgs e)
        {

            /*this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();*/
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int anio = dtpAnio.Value.Year;
            this.spConsultarSucursalPoranioTableAdapter.Fill(this.dSClientesTickets.spConsultarSucursalPoranio, anio);

            this.reportViewer1.RefreshReport();
        }
    }
}
