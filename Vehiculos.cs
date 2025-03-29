using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaSabado22.Interfaces;

namespace p1bpoo.MisClases
{
    public class Vehiculo

    {
        public string Color { get; set; }
        public string Modelo { get; set; }
        public int Year { get; set; }
        public int velocidad = 0;
        //tipo de licencia 
        protected List<string> tiposLicenciaAceptados = new List<string> { "A", "B", "C", "D", "E" };
        public Chofer piloto = null;
        public int estadoVehiculo = 0; // 0= apagado 1=encendido 2=en movimiento;
        public int anio;
        public int capacidadTanque = 20;
        public int consumoCombustible = 1;
        public int velocidadMaxima = 200;
        private string elColor;
        public string elModelo;

        //agregar el metedo de asignar piloto :
        //aqui agrege las dos propiedades  de tanque y combustible

        protected virtual int CapacidadTanque{ get; set; }
        protected virtual int ConsumoCombustible { get; set; }
        protected virtual int VelocidadMaxima { get; set; }

        public string Encender()
        {
            if (piloto == null)
            {
                return "no se puede encender sin un piloto asignado";

            }
            if (estadoVehiculo == 0)
            {
                estadoVehiculo = 1;
                return "Listo vehiculo arrancado";

            }
            return " El carro ya esta encendido";
        }
        public string AsignarPiloto (Chofer elPiloto)

        {
            if (elPiloto == null)
            {
                return "No se puede asingnar un piloto nulo";
            }
            if (!tiposLicenciaAceptados.Contains(elPiloto.TipoLicencia))
            {
                return "El piloto no tiene el tipo de licencia adecuado a este carro";
            }
            if (piloto != null)
            {
                return "Este vehiculo ya tiene asiganado un piloto";
            }
            piloto = elPiloto;
            return " Piloto asignado exitosamente ";
        }

        public Vehiculo(int anio, string elColor, string elModelo, int velocidadMaxima)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
            this.VelocidadMaxima = velocidadMaxima;
        }

        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.anio = anio;
            this.elColor = elColor;
            this.elModelo = elModelo;
            this.VelocidadMaxima = VelocidadMaxima;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color {0}:", this.Color);
            Console.WriteLine("Modelo {0}:", this.Modelo);
            Console.WriteLine("Año {0}", this.Year);
            Console.WriteLine("Velocidad actual: {10} KMS/Hora", this.velocidad);
            Console.WriteLine("Velocidad Maxima: {100} KMS/Hora", this.VelocidadMaxima);
            string estado = estadoVehiculo switch
            {
                0 => "Apagado",
                1 => "Encendido",
                2 => "En movimiento",
                _ => "Estado desconocido"
            };
            Console.WriteLine("Estado del Vehículo: {0}", estado);

            if (piloto != null)
            {
                Console.WriteLine("Piloto Asignado: {0} (Tipo de Licencia: {1})", piloto.Nombre, piloto.TipoLicencia);
            }
            else
            {
                Console.WriteLine("No hay piloto asignado.");
            }
        }
        

public virtual void acelerar(int cuanto)
        {
            if (velocidad + cuanto > VelocidadMaxima)
            {

                velocidad = VelocidadMaxima;
                estadoVehiculo = 2; // esto es para cambiar el estado de movimiento
                Console.WriteLine("Has alcanzado la velocidad maxima de {100} kms/hora\", VelocidadMaxima");
            }

           else
            {
            

            velocidad += cuanto;
                estadoVehiculo = 2; // igual esto es para cambiar el estado de movimiento
            Console.WriteLine("vas a {0} KMS / Hora", velocidad);
        }
    }
        public string  Apagar ()
        {
            if (velocidad > 0)
            {
                return "No se puede apagar un vehiculo en movimiento.";
            }

            if (estadoVehiculo == 0)
            {
                return "El vehículo ya está apagado.";
            }
            estadoVehiculo = 0;
            velocidad = 0; // Detener el vehículo
            return "Vehículo apagado.";
        }

        public string Frenar(int cuanto)
        {
            velocidad -= cuanto;
            if (velocidad < 0) velocidad = 0; // No permitir velocidad negativa
            if (velocidad < 0) velocidad = 0;
            {
                estadoVehiculo = 1; 
            }
            Console.WriteLine("Vas a {0} KMS/Hora", velocidad);
            return "Has frenado.";
        }

}
}


