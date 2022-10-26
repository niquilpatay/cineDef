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
    }
}
