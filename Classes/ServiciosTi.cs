using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTiTests.Classes
{
    internal class ServiciosTi
    {
        public required string NombreCliente { get; set; }
        public required int NumCuenta { get; set; }
        public required float SaldoTotal { get; set; }

        public void AgregarSaldo(float cantidad)
        {
            if (cantidad > 0)
            {
                SaldoTotal += cantidad;
                Console.WriteLine($"Se han agregado ${cantidad} a la cuenta. Saldo total actual: ${SaldoTotal}");
            }
            else
            {
                Console.WriteLine("La cantidad a agregar debe ser mayor a cero.");
            }
        }

        public string ObtenerDescripcionCuenta()
        {
            return $"Cliente: {NombreCliente}, Número de Cuenta: {NumCuenta}, Saldo Total: ${SaldoTotal}";
        }
    }
}
