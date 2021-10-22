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
            //No ordenable
            foreach (DataGridViewColumn dgvc in dgvSolicitudes.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void liberarYAsignarSiguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Verificar que la lista no este vacia
            if (!estacionReposicion.vacia())
            {
                //Eliminamos el primer elemento de la cola
                estacionReposicion.borrar(1);
                //Verificar si no quedo vacia luego de liberar  el primer elemento
                if (!estacionReposicion.vacia())
                {
                    MessageBox.Show("Siguiente en la cola : " + estacionReposicion.extraer(1).solicitante.nombre);
                }
                else
                {
                    MessageBox.Show("No quedan mas Personas asignadas a la estación");
                }
                rellenar();
            }
            else { MessageBox.Show("No quedan mas Personas asignadas a la estación"); }
        }
    }
}
