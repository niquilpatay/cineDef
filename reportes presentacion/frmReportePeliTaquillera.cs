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
    public partial class frmReportePeliTaquillera : Form
    {
        public frmReportePeliTaquillera()
        {
            InitializeComponent();
        }

        private void frmReportePeliTaquillera_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void btnConsultarPeli_Click(object sender, EventArgs e)
        {
            decimal anio = nudAnio.Value;

            this.consultaPelisTaquilleras2TableAdapter.Fill(this.dSClientesTickets.consultaPelisTaquilleras2, Convert.ToInt32(anio));
            this.reportViewerPeliT.RefreshReport();
        }
    }
}
