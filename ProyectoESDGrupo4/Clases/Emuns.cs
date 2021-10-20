using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoESDGrupo4.Clases
{
    public static class Emuns
    {
        public enum PersonaTramite
        {
            Personal,
            Persona_Autorizada,
            Apoderado,
        }
        public enum TipoTramite
        {
            Primera_Vez,
            Reposicion
        }
        public enum TipoNacionalidad
        {
            Salvadoreño,
            Extranjero
        }
        public enum TipoDocumento
        {
            Dui,
            Pasaporte,
            Carnet_Residente
        }
    }
}
