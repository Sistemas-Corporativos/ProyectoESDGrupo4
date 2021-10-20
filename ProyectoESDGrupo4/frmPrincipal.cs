using ProyectoESDGrupo4.Clases;
using ProyectoESDGrupo4.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoESDGrupo4
{
    public partial class frmPrincipal : Form
    {
        Lista listaSolicitudes = new Lista();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSolicitud frm = new frmSolicitud(listaSolicitudes);
            frm.MdiParent = this;
            frm.Show();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void verSolicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //listaSolicitudes.imprimir();
            frmSolicitudes frm = new frmSolicitudes(listaSolicitudes);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
