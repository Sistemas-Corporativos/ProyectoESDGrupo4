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
    public partial class frmEstacionTerceraEdad : Form
    {
        private DataTable tablaDatos;
        private Lista estacionTerceraEdad;
        public frmEstacionTerceraEdad(Lista estacionTercEdad)
        {
            InitializeComponent();
            this.estacionTerceraEdad = estacionTercEdad;
        }

        private void frmEstacionTerceraEdad_Load(object sender, EventArgs e)
        {
            rellenar();
        }
        private void rellenar()
        {
            tablaDatos = estacionTerceraEdad.convertirATablaDatos();
            dgvSolicitudes.DataSource = tablaDatos;
        }
    }
}
