using ServiciosTiTests.Classes;

namespace ServiciosTI
{
    [TestClass]
    internal class Telefono : ServiciosTi
    {
        public required int NumeroTelefono { get; set; }
        public required float SaldoTelefono { get; set; } = 0;
        public required int MinutosTelefono { get; set; } = 0;

        [TestMethod]
        public void RecargarSaldo(float cantidad)
        {
            if (cantidad > 0)
            {
                SaldoTelefono += cantidad;
                Console.WriteLine($"Se han recargado ${cantidad} a la cuenta. Saldo total actual: ${SaldoTelefono}");
            }
            else
            {
                Console.WriteLine("La cantidad a recargar debe ser mayor a cero.");
            }
        }

        [TestMethod]
        public void Llamar(int minutos)
        {
            if (minutos > 0)
            {
                if (minutos <= MinutosTelefono)
                {
                    MinutosTelefono -= minutos;
                    Console.WriteLine($"Se han realizado una llamada de {minutos} minutos. Minutos restantes: {MinutosTelefono}");
                }
                else
                {
                    Console.WriteLine("No tienes suficientes minutos para realizar la llamada.");
                }
            }
            else
            {
                Console.WriteLine("La cantidad de minutos a llamar debe ser mayor a cero.");
            }
        }
    }
}
