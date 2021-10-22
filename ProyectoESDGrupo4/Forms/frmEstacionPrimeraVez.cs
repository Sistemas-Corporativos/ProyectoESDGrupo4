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
    public partial class frmEstacionPrimeraVez : Form
    {
        private DataTable tablaDatos;
        private Lista estacionPrimeraVez;
        public frmEstacionPrimeraVez(Lista estacionPrimVez)
        {
            InitializeComponent();
            this.estacionPrimeraVez = estacionPrimVez;
        }

        private void frmEstacionPrimeraVez_Load(object sender, EventArgs e)
        {
            rellenar();
        }
        private void rellenar()
        {
            tablaDatos = estacionPrimeraVez.convertirATablaDatos();
            dgvSolicitudes.DataSource = tablaDatos;
        }
    }
}
