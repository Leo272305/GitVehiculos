using System;

namespace VehiculoApp
{
    public class Vehiculo
    {
        public string Modelo { get; set; }
        public decimal Precio { get; set; }

        public Vehiculo(string modelo, decimal precio)
        {
            this.Modelo = modelo;
            this.Precio = precio;
        }

        public class Descuento
        {
            public static decimal AplicarDescuento(decimal precio, decimal porcentajeDescuento)
            {
                return precio - (precio * porcentajeDescuento / 100);
            }
        }
    }

    public static class VehiculoExtensions
    {
        public static string MostrarInformacion(this Vehiculo vehiculo)
        {
            return $"Modelo: {vehiculo.Modelo}, Precio: {vehiculo.Precio:C}";
        }
    }

    public static class CalcularReserva
    {
        public static decimal CalcularCostoTotal(decimal precioPorDia, int numeroDias)
        {
            return precioPorDia * numeroDias;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            var vehiculo = new Vehiculo("Ferrari", 5000000m);
            Console.WriteLine("Información del vehículo original:");
            Console.WriteLine(vehiculo.MostrarInformacion());

            
            decimal porcentajeDescuento = 16;
            vehiculo.Precio = Vehiculo.Descuento.AplicarDescuento(vehiculo.Precio, porcentajeDescuento);
            Console.WriteLine("\nInformación del vehículo después de aplicar el descuento:");
            Console.WriteLine(vehiculo.MostrarInformacion());

            
            decimal precioPorDia = vehiculo.Precio;
            int numeroDias = 10;
            decimal costoTotal = CalcularReserva.CalcularCostoTotal(precioPorDia, numeroDias);
            Console.WriteLine($"\nCosto total de la reserva por {numeroDias} días: {costoTotal:C}");
        }
    }
}
