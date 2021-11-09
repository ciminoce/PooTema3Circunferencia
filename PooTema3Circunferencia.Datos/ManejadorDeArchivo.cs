using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PooTema3Circurnferencia.Entidades;

namespace PooTema3Circunferencia.Datos
{
    public class ManejadorDeArchivo
    {
        private readonly string _archivo = Environment.CurrentDirectory + @"\Circunferencias.txt";
        private readonly string _archivoBak = Environment.CurrentDirectory + @"\Circunferencias.bak";

        public ManejadorDeArchivo()
        {
            
        }

        public List<Circunferencia> LeerDatosDelArchivo()
        {
            List<Circunferencia> lista = new List<Circunferencia>();
            if (File.Exists(_archivo))
            {
                StreamReader lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    var circ = ConstruirCircunferencia(linea);
                    lista.Add(circ);
                }
                lector.Close();

            }
            return lista;
        }

        private Circunferencia ConstruirCircunferencia(string linea)
        {
            var campos = linea.Split('|');
            return new Circunferencia()
            {
                Radio = int.Parse(campos[0]),
                Borde = (Color) int.Parse(campos[1]),
                Relleno = (Color) int.Parse(campos[2])
            };
        }

        public void Agregar(Circunferencia circunferencia)
        {
            StreamWriter escritor = new StreamWriter(_archivo, true);
            var linea = ConstruirLinea(circunferencia);
            escritor.WriteLine(linea);
            escritor.Close();
        }

        private string ConstruirLinea(Circunferencia circunferencia)
        {
            return $"{circunferencia.Radio}|{circunferencia.Borde.GetHashCode()}|{circunferencia.Relleno.GetHashCode()}";
        }

        public void BorrarDelArchivo(Circunferencia circBorrar)
        {
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBak);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                var circEnArchivo = ConstruirCircunferencia(linea);
                if (!circEnArchivo.Equals(circBorrar))
                {
                    escritor.WriteLine(linea);
                }
            }
            escritor.Close();
            lector.Close();
            File.Delete(_archivo);
            File.Move(_archivoBak,_archivo);
        }
    }
}
