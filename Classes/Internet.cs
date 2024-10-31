namespace ServiciosTiTests.Classes
{
    internal class Internet : ServiciosTi
    {
        public required int IdInternet { get; set; }
        public required float SaldoInternet { get; set; } = 0;
        public required bool EsFibraOptica { get; set; }
        public required int Velocidad { get; set; }

        public void AumentarVelocidad(int cantidad)
        {
            if (cantidad > 0)
            {
                Velocidad += cantidad;
                Console.WriteLine($"Se ha aumentado la velocidad de internet en {cantidad} MB/s. Velocidad actual: {Velocidad} MB/s");
            }
            else
            {
                Console.WriteLine("La cantidad a aumentar debe ser mayor a cero.");
            }
        }

        public string ObtenerDescripcionInternet()
        {
            return $"ID de Internet: {IdInternet}, Saldo Total: ${SaldoInternet}, Es Fibra Óptica: {EsFibraOptica}, Velocidad: {Velocidad} MB/s";
        }
    }
}
