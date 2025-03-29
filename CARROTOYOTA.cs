using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.MisClases;

namespace TareaSabado22.MisClases
{
    internal class CARROTOYOTA : Vehiculo
    {
        public CARROTOYOTA(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "A", };
        }
        public string hacerdrif()
        {
            if (estadoVehiculo != 2)
            {
                return "no se puede voltear si el auto esta apagado";
            }
            else
            {
                return "haciendo drif";
            }

        }
    }
}


