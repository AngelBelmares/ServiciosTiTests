using ServiciosTI;

namespace ServiciosTiTests.Tests
{
    [TestClass]
    public class TelefonoTests
    {
        [TestMethod]
        public void TesteaRecargarSaldo()
        {
            var servicioTelefono = new Telefono()
            {
                NombreCliente = "Juan",
                NumeroTelefono = 123456789,
                SaldoTelefono = 0,
                MinutosTelefono = 0,
                NumCuenta = 1,
                SaldoTotal = 0
            };

            servicioTelefono.RecargarSaldo(100);
            Assert.AreEqual(100, servicioTelefono.SaldoTelefono);
        }

        [TestMethod]
        public void TesteaLlamar()
        {
            var servicioTelefono = new Telefono()
            {
                NombreCliente = "Juan",
                NumeroTelefono = 123456789,
                SaldoTelefono = 0,
                MinutosTelefono = 100,
                NumCuenta = 1,
                SaldoTotal = 0
            };

            servicioTelefono.Llamar(50);
            Assert.AreEqual(50, servicioTelefono.MinutosTelefono);
        }

        [TestMethod]
        public void TesteaLlamarNegativo()
        {
            var servicioTelefono = new Telefono()
            {
                NombreCliente = "Juan",
                NumeroTelefono = 123456789,
                SaldoTelefono = 0,
                MinutosTelefono = 0,
                NumCuenta = 1,
                SaldoTotal = 0
            };

            servicioTelefono.Llamar(-50);
            Assert.AreEqual(-50, servicioTelefono.MinutosTelefono);
        }

        [TestMethod]
        public void TesteaRecargarYLLamar()
        {
            var servicioTelefono = new Telefono()
            {
                NombreCliente = "Juan",
                NumeroTelefono = 123456789,
                SaldoTelefono = 0,
                MinutosTelefono = 100,
                NumCuenta = 1,
                SaldoTotal = 0
            };

            servicioTelefono.RecargarSaldo(200);
            servicioTelefono.Llamar(50);
            Assert.AreEqual(150, servicioTelefono.SaldoTelefono);
            Assert.AreEqual(50, servicioTelefono.MinutosTelefono);
        }
    }
}