using ProyectoESDGrupo4.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoESDGrupo4.Forms
{
    public partial class frmSolicitudes : Form
    {
        private Lista listaSolicitudes;
        public frmSolicitudes(Lista lista)
        {
            InitializeComponent();
            this.listaSolicitudes = lista;
        }

        private void frrmSolicitudes_Load(object sender, EventArgs e)
        {
            rellenar();
        }
        private void rellenar()
        {
            dgvSolicitudes.DataSource = listaSolicitudes.convertirATablaDatos();
        }
        private void eliminarSolicitudSeleccionadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.Rows.Count > 0)
            {
                if(MessageBox.Show("Desea eliminar esta solicitud","Solicitud", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    listaSolicitudes.borrar(dgvSolicitudes.CurrentRow.Index + 1);
                    rellenar();
                }
            }
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rellenar();
        }
    }
}
