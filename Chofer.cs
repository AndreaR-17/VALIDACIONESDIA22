using TareaSabado22.Interfaces;

public class Chofer : IPiloto
{
    public string Nombre { get ; set ; }
    public int Edad { get ; set; }
    public string TipoLicencia { get; set; }

    public Chofer (string name,int edadPiloto, string tipoLicencia)
    {
        if ((tipoLicencia == "A"|| tipoLicencia == "B"|| tipoLicencia == "D" || tipoLicencia == "E") && edadPiloto < 21)
        {
            throw new ArgumentException("La edad minimo para la licencia tipo A, B, D o E es de 21 años.");
        }
        else
        {
            if (tipoLicencia == "C" && edadPiloto < 18)
            {
                throw new ArgumentException("La edad minima para licencia tipo C es de 18 años.");
            }
        }


        Nombre = name;
        Edad = edadPiloto;
        TipoLicencia = tipoLicencia;
         }
    public void MostrarInformacion()

    {
        Console.WriteLine("Nombre: {0}", this.Nombre);
        Console.WriteLine("Edad: {0}", this.Edad);
        Console.WriteLine("Licencia Tipo: {0}", this.TipoLicencia );
    }
}