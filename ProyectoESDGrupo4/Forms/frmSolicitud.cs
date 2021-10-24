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
        private string errores = "";

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
            //Validamos los datos
            if (!validarInformacion())
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
                if (personaTramite != PersonaTramite.Personal)
                {
                    solicitante.tipoDocumento = tipoDocApoderado;
                    solicitante.numDocumento = txtNumDocApoderado.Text;
                    solicitante.nombre = txtNombreApoderado.Text;
                    solicitante.edad = int.Parse(txtEdadApoderado.Text);
                    solicitante.direccion = txtDireccionApoderado.Text;
                }
                //Creamos la solicitud
                Solicitud solicitud = new Solicitud();
                solicitud.fecha = DateTime.Now;
                solicitud.personaTramite = personaTramite;
                solicitud.tipoTramite = tipoTramite;
                solicitud.tipoNacionalidad = tipoNacionalidad;
                solicitud.solicitante = solicitante;
                if (personaTramite != PersonaTramite.Personal)
                {
                    solicitud.apoderado = apoderado;
                }
                //Agregar a la lista de solicitudes
                listaSolicitudes.insertar(1, solicitud);
                MessageBox.Show("Solicitud agregada");
                limpiar();
            }
            else
            {
                MessageBox.Show(errores);
            }            
        }
        private bool validarInformacion()
        {
            bool flag = false;
            errores = "";
            if(cbxPersonaTramite.SelectedIndex == -1)
            {
                flag = true;
                errores += "Persona del tramite obligatoria \n";
            }
            if (cbxTipoTramite.SelectedIndex == -1)
            {
                flag = true;
                errores += "Persona del tramite obligatoria \n";
            }
            if (cbxTipoSolicitante.SelectedIndex == -1)
            {
                flag = true;
                errores += "Tipo de Solicitante obligatorio \n";
            }
            if (cbxTipoDocSolicitante.SelectedIndex == -1)
            {
                flag = true;
                errores += "Tipo de Documnto Solicitante obligatorio \n";
            }
            if (txtNumDocSolicitante.Text == "")
            {
                flag = true;
                errores += "Numero de Documento Solicitante obligatorio \n";
            }
            if (txtNomSolicitante.Text == "")
            {
                flag = true;
                errores += "Nombre Solicitante obligatorio \n";
            }
            if (txtEdadSolicitante.Text == "")
            {
                flag = true;
                errores += "Edad Solicitante obligatorio \n";
            }
            if (txtDireccionSolicitante.Text == "")
            {
                flag = true;
                errores += "Direccion Solicitante obligatorio \n";
            }
            if(personaTramite != PersonaTramite.Personal)
            {
                if (cbxTipoDocApoderado.SelectedIndex == -1)
                {
                    flag = true;
                    errores += "Tipo de docuemnto Apoderado obligatorio \n";
                }
                if (txtNumDocApoderado.Text == "")
                {
                    flag = true;
                    errores += "Numero de Documento Apoderado obligatorio \n";
                }
                if (txtNombreApoderado.Text == "")
                {
                    flag = true;
                    errores += "Nombre Apoderado obligatorio \n";
                }
                if (txtEdadApoderado.Text == "")
                {
                    flag = true;
                    errores += "Edad Apoderado obligatorio \n";
                }
                if (txtDireccionApoderado.Text == "")
                {
                    flag = true;
                    errores += "Direccion Apoderado obligatorio \n";
                }
            }
            return flag;
        }
        private void limpiar()
        {
            cbxPersonaTramite.SelectedIndex = -1;
            cbxTipoTramite.SelectedIndex = -1;
            cbxTipoSolicitante.SelectedIndex = -1;
            cbxTipoDocSolicitante.SelectedIndex = -1;
            cbxTipoDocApoderado.SelectedIndex = -1;
            txtNumDocSolicitante.Text = "";
            txtNumDocApoderado.Text = "";
            txtNomSolicitante.Text = "";
            txtNombreApoderado.Text = "";
            txtEdadSolicitante.Text = "";
            txtEdadApoderado.Text = "";
            txtDireccionSolicitante.Text = "";
            txtDireccionApoderado.Text = "";
            gbxApoderado.Visible = false;
        }
    }
}
