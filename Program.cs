
using p1bpoo.MisClases;
using TareaSabado22.MisClases;

//Vehiculo miCarrito = new Vehiculo(2026, "Azul", "Alfa Romeo");

//Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");

//CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");

//miBYD.InformacionVehiculo();
//miBYD.cargarBateria();
//Console.WriteLine("El nivel de bateria es: {0}", miBYD.NivelBateria());


Chofer pilot1 = new Chofer("monica", 21, "B");
Chofer pilot2 = new Chofer("ANDREA", 31, "C");
Chofer pilot3 = new Chofer("PEDRO", 30, "M");

//pilot1.MostrarInformacion();
//pilot2.MostrarInformacion();
//pilot3.MostrarInformacion();


//Vehiculo sedan = new Vehiculo(2022, "Rojo", "Toyota");
//Console.WriteLine(sedan.Encender());
//sedan.acelerar(10);
//Console.WriteLine(sedan.AsignarPiloto(pilot3));
//Console.WriteLine(sedan.Encender());
//Console.WriteLine(sedan);
//string respuesta = sedan.AsignarPiloto(pilot2);
//Console.WriteLine(respuesta);

Vehiculo moo = new moto(2022, "Rojo", "Toyota");
moo.acelerar(10);
Console.WriteLine(moo.AsignarPiloto(pilot1));
Console.WriteLine(moo.capacidadTanque);
Console.WriteLine(moo.Encender());
Console.WriteLine(moo.consumoCombustible);
Console.WriteLine((moo.velocidadMaxima));



