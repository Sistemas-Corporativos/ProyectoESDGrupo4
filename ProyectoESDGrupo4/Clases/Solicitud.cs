using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProyectoESDGrupo4.Clases.Emuns;

namespace ProyectoESDGrupo4.Clases
{
    public class Solicitud
    {
        //Atributos
        public DateTime fecha;
        public PersonaTramite personaTramite;
        public TipoTramite tipoTramite;
        public TipoNacionalidad tipoNacionalidad;
        public Persona solicitante;
        public Persona apoderado;
        //Constructor
        public Solicitud() { }
        //Metodos        
    }
   
}
