using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PooTema3Circurnferencia.Entidades
{
    public class Circunferencia
    {
        public int Radio { get; set; }
        public Color Borde { get; set; }
        public Color Relleno { get; set; }

        public Circunferencia()
        {
            
        }

        public double GetPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public double GetSuperficie()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override bool Equals(object obj)
        {
            if (obj==null ||!(obj is Circunferencia))
            {
                return false;
            }

            return this.Radio == ((Circunferencia) obj).Radio &&
                   this.Borde == ((Circunferencia) obj).Borde &&
                   this.Relleno == ((Circunferencia) obj).Relleno;
        }

        public override int GetHashCode()
        {
            return Radio.GetHashCode() + Borde.GetHashCode() + Relleno.GetHashCode();
        }

        public override string ToString()
        {
            return $"Circ de radio {Radio} con borde color {Borde.ToString()} y relleno color {Relleno.ToString()}";
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Circ de radio {Radio}");
            sb.AppendLine($"Borde: {Borde.ToString()}");
            sb.AppendLine($"Relleno: {Relleno.ToString()}");
            return sb.ToString();
        }

        public bool Validar()
        {
            return Radio > 0 &&
                   (Borde.GetHashCode() >= 0 && Borde.GetHashCode() <= 5) &&
                   (Relleno.GetHashCode() >= 0 && Relleno.GetHashCode() <= 5);
        }
    }
}
