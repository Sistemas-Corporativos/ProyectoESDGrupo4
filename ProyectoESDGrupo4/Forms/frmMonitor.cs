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
    public partial class frmMonitor : Form
    {
        private Lista estacionPimeraVez;
        private Lista estacionReposicion;
        private Lista estacionTerceraEdad;     

        public frmMonitor(Lista estacionPVez, Lista estacionRepo, Lista estacionTercEdad)
        {
            InitializeComponent();
            this.estacionPimeraVez = estacionPVez;
            this.estacionReposicion = estacionRepo;
            this.estacionTerceraEdad = estacionTercEdad;
        }

        private void frmMonitor_Load(object sender, EventArgs e)
        {
        }

        private void btnSiguienteTerceraEdad_Click(object sender, EventArgs e)
        {
            //Verificar si la lista no esta vacia
            if (!estacionTerceraEdad.vacia())
            {
                //Obtener la primer solicitud de la lista
                Solicitud solicitud = estacionTerceraEdad.extraer(1);
                lblNombreTercEdad.Text = solicitud.solicitante.nombre;
            }
            else
            {
                lblNombreTercEdad.Text = "Estación Vacía";
            }
        }

        private void btnSiguientePrimeraVez_Click(object sender, EventArgs e)
        {
            //Verificar si la lista no esta vacia
            if (!estacionPimeraVez.vacia())
            {
                //Obtener la primer solicitud de la lista
                Solicitud solicitud = estacionPimeraVez.extraer(1);
                lblNombrePrimeraVez.Text = solicitud.solicitante.nombre;
            }
            else
            {
                lblNombrePrimeraVez.Text = "Estación Vacía";
            }
        }

        private void btnSiguienteReposicion_Click(object sender, EventArgs e)
        {
            //Verificar si la lista no esta vacia
            if (!estacionReposicion.vacia())
            {
                //Obtener la primer solicitud de la lista
                Solicitud solicitud = estacionReposicion.extraer(1);
                lblNombreRepocicion.Text = solicitud.solicitante.nombre;
            }
            else
            {
                lblNombreRepocicion.Text = "Estación Vacía";
            }
        }
    }
}
