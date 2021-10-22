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
    public partial class frmEstacionReposicion : Form
    {
        private DataTable tablaDatos;
        private Lista estacionReposicion;
        public frmEstacionReposicion(Lista estacionRep)
        {
            InitializeComponent();
            estacionReposicion = estacionRep;
        }

        private void frmEstacionReposicion_Load(object sender, EventArgs e)
        {
            rellenar();
        }
        private void rellenar()
        {
            tablaDatos = estacionReposicion.convertirATablaDatos();
            dgvSolicitudes.DataSource = tablaDatos;
        }
    }
}
