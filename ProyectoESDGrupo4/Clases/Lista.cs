using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoESDGrupo4.Clases
{
    public class Lista
    {
        class Nodo
        {
            public Solicitud solicitud; //solicitud el NIT
            public Nodo ant, sig;
        }
        private Nodo raiz; //Nodo Raiz
        //Constructor
        public Lista()
        {
            raiz = null; //Al instanciar la clase el nodo raiz sera null
        }
        #region METODOS
        //Obtener la cantidad de elementos de la lista
        private int cantidadElementos()
        {
            int cant = 0;
            Nodo reco = raiz;
            while (reco != null)
            {
                reco = reco.sig;
                cant++;
            }
            return cant;
        }
        //Vaciar la lista
        public void vaciar()
        {
            raiz = null;
        }
        //Insertar un elemento en la posicion indicada
        public void insertar(int pos, Solicitud solicitud)
        {
            if (pos <= cantidadElementos() + 1)
            {
                //Creamos un nuevo nodo
                Nodo nuevo = new Nodo();
                //Asignamos la solicitud al nodo
                nuevo.solicitud = solicitud;
                if (pos == 1) //Si la posicion a insertar es 1
                {
                    nuevo.sig = raiz;
                    if(raiz != null)
                        raiz.ant = nuevo;
                    raiz = nuevo;
                }else
                {
                    if(pos == cantidadElementos() + 1) //Verificamos si se inserta al final de la lista
                    {
                        Nodo reco = raiz;
                        while (reco.sig != null)
                        {
                            reco = reco.sig;
                        }
                        reco.sig = nuevo;
                        nuevo.ant = reco;
                        nuevo.sig = null;
                    }else //Si no se inserta al final o al pricipio se inserta en medio de esta
                    {
                        Nodo reco = raiz;
                        for (int f = 1; f <= pos - 2; f++) //Nos detenemos una posicion antes de donde desea insertarse
                            reco = reco.sig;
                        Nodo siguiente = reco.sig;
                        reco.sig = nuevo;
                        nuevo.ant = reco;
                        nuevo.sig = siguiente;
                        siguiente.ant = nuevo;
                    }
                }
            }
        }
        //Extraer un elemento de la Lista
        public Solicitud extraer(int pos) //Posicion del nodo a extraer
        {
            //Verificamos que la posicion exista en la lista
            if (pos <= cantidadElementos())
            {
                Solicitud solicitud;//la solicitud que extraeremos
                if (pos == 1)
                {
                    solicitud = raiz.solicitud;                   
                }
                else
                {
                    Nodo reco;
                    reco = raiz;
                    for (int f = 1; f <= pos - 2; f++)
                        reco = reco.sig;
                    Nodo prox = reco.sig;                    
                    solicitud = prox.solicitud;
                }
                return solicitud;
            }
            else
                return null;
        }
        //Borrar un elemento de la lista
        public void borrar(int pos)
        {
            if (pos <= cantidadElementos())
            {
                if (pos == 1)
                {
                    raiz = raiz.sig;
                    if (raiz != null)
                        raiz.ant = null;
                }
                else
                {
                    Nodo reco;
                    reco = raiz;
                    for (int f = 1; f <= pos - 2; f++)
                        reco = reco.sig;
                    Nodo prox = reco.sig;
                    prox = prox.sig;
                    reco.sig = prox;
                    if (prox != null)
                        prox.ant = reco;
                }
            }
        }
        //Intercambiar ubicacion de un elemento en la lista    
        public void intercambiar(int pos1, int pos2)
        {
            if (pos1 <= cantidadElementos() && pos2 <= cantidadElementos())
            {
                Nodo reco1 = raiz;
                for (int f = 1; f < pos1; f++)
                    reco1 = reco1.sig;
                Nodo reco2 = raiz;
                for (int f = 1; f < pos2; f++)
                    reco2 = reco2.sig;
                Solicitud aux = reco1.solicitud;
                reco1.solicitud = reco2.solicitud;
                reco2.solicitud = aux;
            }
        }
        //Verificar si un elemento existe en la lista
        public bool existe(Solicitud solicitud)
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                if (reco.solicitud == solicitud)
                    return true;
                reco = reco.sig;
            }
            return false;
        }
        //Verificar si la lista esta vacia
        public bool vacia()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }
        //Imprimir la lista en consola (Solo para efectos de pruebas)
        public void imprimir()
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                Console.WriteLine(reco.solicitud.solicitante.nombre);                
                reco = reco.sig;
            }            
        }
        //Metodo para convertir a un datable para poder asignar como datasource a un Grid
        public DataTable convertirATablaDatos()
        {
            DataTable tabla = new DataTable();
            string[] encabezados = new string[] { "Fecha","Persona Tramite","Tipo Tramite", "Tipo Nacionalidad", "Tipo Documento",
                                "No Documento", "Nombre", "Edad" };
            foreach(string encabezado in encabezados)
            {
                tabla.Columns.Add(encabezado);
            }
            //Recorrer la estructura y agregar filas al datatable
            Nodo reco = raiz;
            while (reco != null)
            {
                DataRow fila = tabla.NewRow();
                string[] datosFila = new string[] { reco.solicitud.fecha.ToString(),reco.solicitud.personaTramite.ToString(), reco.solicitud.tipoTramite.ToString(),
                                    reco.solicitud.tipoNacionalidad.ToString(), reco.solicitud.solicitante.tipoDocumento.ToString(),
                                    reco.solicitud.solicitante.numDocumento,reco.solicitud.solicitante.nombre, reco.solicitud.solicitante.edad.ToString()
                };
                for (int i = 0; i < datosFila.Length; i++)
                {
                    fila[i] = datosFila[i];
                }
                tabla.Rows.Add(fila);
                //Console.WriteLine(reco.solicitud.solicitante.nombre);
                reco = reco.sig;
            }
            return tabla;
        }
        #endregion
    }
}
