using cineLabo.reportes;
using cineLabo.reportes_presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cineLabo
{
    public partial class frmCine : Form
    {
        public frmCine()
        {
            InitializeComponent();
        }

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTickets t = new frmTickets();
            t.ShowDialog();
        }

        private void cLIENTESTICKETSCOMPRADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteClientesTickets rc = new frmReporteClientesTickets();
            rc.ShowDialog();
        }

        private void sALASYASIENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteSalasAsientos sa = new frmReporteSalasAsientos();
            sa.ShowDialog();    
        }

        private void sUCURSALESYRECAUDACIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteSucursalesRecaudacion sr = new frmReporteSucursalesRecaudacion();
            sr.ShowDialog();
        }

        private void cLIENTESCON1TICKETELMESPASADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteClientesTicketsMesPasado cm = new frmReporteClientesTicketsMesPasado();
            cm.ShowDialog();
        }


    }
}
