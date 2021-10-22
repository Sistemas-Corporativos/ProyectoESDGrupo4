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
            //No ordenable
            foreach (DataGridViewColumn dgvc in dgvSolicitudes.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void liberarYAsignarSiguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Verificar que la lista no este vacia
            if (!estacionPrimeraVez.vacia())
            {
                //Eliminamos el primer elemento de la cola
                estacionPrimeraVez.borrar(1);
                //Verificar si no quedo vacia luego de liberar  el primer elemento
                if (!estacionPrimeraVez.vacia())
                {
                    MessageBox.Show("Siguiente en la cola : " + estacionPrimeraVez.extraer(1).solicitante.nombre);
                }
                else
                {
                    MessageBox.Show("No quedan mas Personas asignadas a la estación");
                }
                rellenar();
            }else { MessageBox.Show("No quedan mas Personas asignadas a la estación"); }            
        }
    }
}
