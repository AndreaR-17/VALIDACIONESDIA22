using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.MisClases;

namespace TareaSabado22.MisClases
{
    internal class CAMION : Vehiculo
    {
        protected override int CapacidadTanque =>180;// esta es la capacidad de galones
        protected override int ConsumoCombustible => (int)0.50; //consumo de galones por km
        protected override int VelocidadMaxima => 120; //velocidad maxima camion
        public CAMION(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "M" };
        }
        public string voltearcarga ()
        {
            if (estadoVehiculo != 2)
            {
                return "no se puede voltear si esta apagado el camion";
            }
            else
            {
                return "volteando carga";
            }

        }
    }

}

