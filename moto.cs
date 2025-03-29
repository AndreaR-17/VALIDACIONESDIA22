using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.MisClases;

namespace TareaSabado22.MisClases
{
    internal class moto: Vehiculo 
    {
        //aqui pongo las propiedades protegidas que hice en vehiculos
        protected override int CapacidadTanque => 20;// esta es la capacidad de galones
        protected override int ConsumoCombustible => 1; //consumo de galones por km
        protected override int VelocidadMaxima => 200; //velocidad maxima moto

        public moto(int anio, string elColor, string elModelo, int VelocidadMaxima) : base(anio, elColor, elModelo, VelocidadMaxima)
        {
            tiposLicenciaAceptados = ["M"];

        }

        public moto(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
        }

        public string HacerCaballito()
        {
            if (estadoVehiculo != 2)
            {
                return "no se puede hacer caballito si la moto esta en movimiento";
            }
            else
            {
                return "haciendo un caballito";
            }

        }

        internal class velocidadMaxima
        {
        }
    }
     }


