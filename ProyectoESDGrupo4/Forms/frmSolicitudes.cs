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
        private Lista estacionPimeraVez;
        private Lista estacionReposicion;
        private Lista estacionTerceraEdad;
        private DataTable tablaDatos;
        public frmSolicitudes(Lista lista, Lista estacionPVez, Lista estacionRepo, Lista estacionTercEdad)
        {
            InitializeComponent();
            //Obtenemos las listas del form principal con el que estamos trabajando
            this.listaSolicitudes = lista;
            this.estacionPimeraVez = estacionPVez;
            this.estacionReposicion = estacionRepo;
            this.estacionTerceraEdad = estacionTercEdad;
        }

        private void frrmSolicitudes_Load(object sender, EventArgs e)
        {
            rellenar();
        }
        private void rellenar()
        {
            tablaDatos = listaSolicitudes.convertirATablaDatos();
            dgvSolicitudes.DataSource = tablaDatos;
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

        private void asignarAEstaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.Rows.Count > 0)
            {
                int pos = 1;
                //El sistema determinara a que estacion agregar segun la solicitud
                //Obtenemos la solicitud de la lista
                Solicitud solicitud = listaSolicitudes.extraer(dgvSolicitudes.CurrentRow.Index + 1);
                //Verificamos la edad para determinar si asignamos a la estacion de Tercera Edad
                if (solicitud.solicitante.edad >= 60)
                {
                    //identificamos la cantidad de elementos de la lista con el fin de asignar al final y simular una cola.
                    //La posicion a insertar la determinamos asignando el tamaños de la lista mas 1
                    pos = estacionTerceraEdad.cantidadElementos() + 1;
                    //Asignamos la solicitud a la estacion en la posicion indicada
                    estacionTerceraEdad.insertar(pos, solicitud);
                    //Eliminamos la solicitud de la lista de solicitudes
                    listaSolicitudes.borrar(dgvSolicitudes.CurrentRow.Index + 1);
                    //Rellenar el grid de solicitudes
                    rellenar();
                }
                else //En caso contrario se asignara ya sea a la estacion de primera Vez o Reposicion
                {
                    if (solicitud.tipoTramite == Emuns.TipoTramite.Primera_Vez)
                    {
                        //identificamos la cantidad de elementos de la lista con el fin de asignar al final y simular una cola.
                        //La posicion a insertar la determinamos asignando el tamaños de la lista mas 1
                        pos = estacionPimeraVez.cantidadElementos() + 1;
                        //Asignamos la solicitud a la estacion en la posicion indicada
                        estacionPimeraVez.insertar(pos, solicitud);
                        //Eliminamos la solicitud de la lista de solicitudes
                        listaSolicitudes.borrar(dgvSolicitudes.CurrentRow.Index + 1);
                        //Rellenar el grid de solicitudes
                        rellenar();
                    }
                    else if (solicitud.tipoTramite == Emuns.TipoTramite.Reposicion)
                    {
                        //identificamos la cantidad de elementos de la lista con el fin de asignar al final y simular una cola.
                        //La posicion a insertar la determinamos asignando el tamaños de la lista mas 1
                        pos = estacionReposicion.cantidadElementos() + 1;
                        //Asignamos la solicitud a la estacion en la posicion indicada
                        estacionReposicion.insertar(pos, solicitud);
                        //Eliminamos la solicitud de la lista de solicitudes
                        listaSolicitudes.borrar(dgvSolicitudes.CurrentRow.Index + 1);
                        //Rellenar el grid de solicitudes
                        rellenar();
                    }
                }
                MessageBox.Show("Agregado a Estación");
            }            
        }
    }
}
