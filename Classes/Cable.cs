namespace ServiciosTiTests.Classes
{
    internal class Cable : ServiciosTi
    {
        public required int IdCable { get; set; }
        public required float SaldoCable { get; set; } = 0;
        public required string Empresa { get; set; }
        public required bool EsHD { get; set; }

        public void CambiarPlanHD(bool esHD)
        {
            if (esHD != EsHD)
            {
                EsHD = esHD;
                Console.WriteLine($"Se ha cambiado el plan HD a {esHD}");
            }
            else
            {
                Console.WriteLine("El plan HD ingresado es el mismo que el actual.");
            }
        }

        public void CambiarEmpresa(string nuevaEmpresa)
        {
            if (nuevaEmpresa != Empresa)
            {
                Empresa = nuevaEmpresa;
                Console.WriteLine($"Se ha cambiado la empresa de cable a {nuevaEmpresa}");
            }
            else
            {
                Console.WriteLine("La empresa ingresada es la misma que la actual.");
            }
        }
    }
}
