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
        Lista estacionPrimeraVez = new Lista();
        Lista estacionReposicion = new Lista();
        Lista estacionTerceraEdad = new Lista();
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
            //Pasamos las listas con las que vamos a trabajar en el administrador de solicitudes;
            frmSolicitudes frm = new frmSolicitudes(listaSolicitudes,estacionPrimeraVez,estacionReposicion,estacionTerceraEdad);
            frm.MdiParent = this;
            frm.Show();
        }

        private void terceraEdadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstacionTerceraEdad frm = new frmEstacionTerceraEdad(estacionTerceraEdad);
            frm.MdiParent = this;
            frm.Show();
        }

        private void primeraVezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstacionPrimeraVez frm = new frmEstacionPrimeraVez(estacionPrimeraVez);
            frm.MdiParent = this;
            frm.Show();
        }

        private void reposiciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstacionReposicion frm = new frmEstacionReposicion(estacionReposicion);
            frm.MdiParent = this;
            frm.Show();
        }

        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonitor frm = new frmMonitor(estacionPrimeraVez,estacionReposicion,estacionTerceraEdad);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
