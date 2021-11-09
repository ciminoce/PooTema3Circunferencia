using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PooTema3Circurnferencia.Entidades;

namespace PooTema3Circunferencia.Datos
{
    public class RepositorioDeCircunferencias
    {
        private List<Circunferencia> listaCircunferencias;
        private ManejadorDeArchivo manejador;
        public static RepositorioDeCircunferencias _instancia = null;
        
        public static RepositorioDeCircunferencias GetInstancia()
        {
            if (_instancia==null)
            {
                _instancia = new RepositorioDeCircunferencias();
            }

            return _instancia;
        }
        private RepositorioDeCircunferencias()
        {
            listaCircunferencias = new List<Circunferencia>();
            manejador = new ManejadorDeArchivo();
            listaCircunferencias = manejador.LeerDatosDelArchivo();
        }

        public List<Circunferencia> GetLista()
        {
            return listaCircunferencias;
        }

        public void Agregar(Circunferencia circunferencia)
        {
            manejador.Agregar(circunferencia);
            listaCircunferencias.Add(circunferencia);
        }

        public void Editar()
        {

        }

        public void Borrar(Circunferencia circunferencia)
        {
            manejador.BorrarDelArchivo(circunferencia);
            listaCircunferencias.Remove(circunferencia);
        }

        public bool Existe(Circunferencia circunferencia)
        {
            return listaCircunferencias.Contains(circunferencia);
        }

        public int GetCantidad()
        {
            return listaCircunferencias.Count;
        }
    }
}
