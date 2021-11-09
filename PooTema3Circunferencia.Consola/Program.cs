using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PooTema3Circunferencia.Datos;
using PooTema3Circurnferencia.Entidades;

namespace PooTema3Circunferencia.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //var circ = new Circunferencia()
            //{
            //    Radio = 15,
            //    Borde = Color.Amarillo,
            //    Relleno = Color.Amarillo
            //};
            //RepositorioDeCircunferencias.GetInstancia().Agregar(circ);
            //Console.WriteLine(RepositorioDeCircunferencias.GetInstancia().GetCantidad());
            foreach (var circunferencia in RepositorioDeCircunferencias.GetInstancia().GetLista())
            {
                Console.WriteLine(circunferencia.ToString());
            }

            Console.WriteLine(RepositorioDeCircunferencias.GetInstancia().GetCantidad());
            //var circ2 = new Circunferencia()
            //{
            //    Radio = 40,
            //    Borde = Color.Rojo,
            //    Relleno = Color.Negro
            //};
            //if (circ2.Validar())
            //{

            //    if (!RepositorioDeCircunferencias.GetInstancia().Existe(circ2))
            //    {
            //        RepositorioDeCircunferencias.GetInstancia().Agregar(circ2);
            //        Console.WriteLine(RepositorioDeCircunferencias.GetInstancia().GetCantidad());
            //    }
            //    else
            //    {
            //        Console.WriteLine("Circ existente!!!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Circ mal ingresada!!!");
            //}
            var circ = new Circunferencia()
            {
                Radio = 50,
                Borde = Color.Negro,
                Relleno = Color.Negro
            };
            if (RepositorioDeCircunferencias.GetInstancia().Existe(circ))
            {
                RepositorioDeCircunferencias.GetInstancia().Borrar(circ);
                Console.WriteLine(RepositorioDeCircunferencias.GetInstancia().GetCantidad());

            }
            else
            {
                Console.WriteLine("Circ no guardada en el repo");
            }
            Console.ReadLine();

        }
    }
}
