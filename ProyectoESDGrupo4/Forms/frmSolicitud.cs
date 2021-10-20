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
using static ProyectoESDGrupo4.Clases.Emuns;

namespace ProyectoESDGrupo4.Forms
{
    public partial class frmSolicitud : Form
    {
        private Lista listaSolicitudes;
        private PersonaTramite personaTramite;
        private TipoTramite tipoTramite;
        private TipoNacionalidad tipoNacionalidad;
        private TipoDocumento tipoDocSolicitante;
        private TipoDocumento tipoDocApoderado;

        public frmSolicitud(Lista lista) // Pasamos por el constructor la lista con la que trabajaremos y agregaremos la solicitud
        {            
            InitializeComponent();
            listaSolicitudes = lista;
        }

        private void cbxPersonaTramite_SelectedIndexChanged(object sender, EventArgs e)
        {
            personaTramite = (PersonaTramite)cbxPersonaTramite.SelectedIndex;         
            //Ocultar captura de datos del apoderado
            if(personaTramite == PersonaTramite.Personal)
            {
                gbxApoderado.Visible = false;
            }
            else
            {
                gbxApoderado.Visible = true;
            }
        }

        private void cbxTipoTramite_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoTramite = (TipoTramite)cbxTipoTramite.SelectedIndex;
        }

        private void cbxTipoSolicitante_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoNacionalidad = (TipoNacionalidad)cbxTipoSolicitante.SelectedIndex;
        }

        private void cbxTipoDocApoderado_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoDocApoderado = (TipoDocumento)cbxTipoDocApoderado.SelectedIndex;
        }

        private void cbxTipoDocSolicitante_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoDocSolicitante = (TipoDocumento)cbxTipoDocSolicitante.SelectedIndex;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona solicitante = new Persona();
            Persona apoderado = new Persona();
            //Crear el solicitante;
            solicitante.tipoDocumento = tipoDocSolicitante;
            solicitante.numDocumento = txtNumDocSolicitante.Text;
            solicitante.nombre = txtNomSolicitante.Text;
            solicitante.edad = int.Parse(txtEdadSolicitante.Text);
            solicitante.direccion = txtDireccionSolicitante.Text;

            //Crear el apoderado si aplica
            if(personaTramite != PersonaTramite.Personal)
            {                
                solicitante.tipoDocumento = tipoDocApoderado;
                solicitante.numDocumento = txtNumDocApoderado.Text;
                solicitante.nombre = txtNombreApoderado.Text;
                solicitante.edad = int.Parse(txtEdadApoderado.Text);
                solicitante.direccion = txtDireccionApoderado.Text;
            }
            //Creamos la solicitud
            Solicitud solicitud = new Solicitud();
            solicitud.personaTramite = personaTramite;
            solicitud.tipoTramite = tipoTramite;
            solicitud.tipoNacionalidad = tipoNacionalidad;
            solicitud.solicitante = solicitante;
            if(personaTramite != PersonaTramite.Personal)
            {
                solicitud.apoderado = apoderado;
            }
            //Agregar a la lista de solicitudes
            listaSolicitudes.insertar(1, solicitud);
        }
    }
}
