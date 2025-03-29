using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class CarroElectrico : Vehiculo
    {
        protected override int CapacidadTanque =>220;// esta es la capacidad de galones
        protected override int ConsumoCombustible => (int)0.03; //consumo de galones por km
        protected override int VelocidadMaxima => 400; //velocidad maxima carro electrico

        private int cargaBateria;
        public CarroElectrico(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            cargaBateria = 50;
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            cargaBateria--;
        }


        public int NivelBateria() { return cargaBateria; }
        public void cargarBateria()
        {
            cargaBateria++;
        }


    }
}
