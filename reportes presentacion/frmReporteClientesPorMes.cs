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
    public partial class frmReporteClientesPorMes : Form
    {
        public frmReporteClientesPorMes()
        {
            InitializeComponent();
        }

        private void frmReporteClientesPorMes_Load(object sender, EventArgs e)
        {

            this.rvClientesMes.RefreshReport();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int mes = dateTimePicker1.Value.Month;

            this.consultaClientesComprasMes2TableAdapter.Fill(this.dSClientesTickets.consultaClientesComprasMes2, mes);
            this.rvClientesMes.RefreshReport();
        }

       /* public DataTable filtrar(int mes)
        {
            cnn.Open();
            DataTable tabla = new DataTable();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "consulta4";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@mes", mes);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;

        }*/
    }
}
