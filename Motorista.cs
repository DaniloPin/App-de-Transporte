public class Motorista
{
    public string NomeMotorista { get; set; }
    public string Carro { get; set; }
    public double Saldo { get; set; }


    public void AceitarCorrida(Corrida corrida)
    {
        if(corrida.Status == "Solicitada")
        {
            corrida.Status = "Aceita";
            corrida.Motorista = this;
            Console.WriteLine($"\nCorrida aceita pelo motorista {NomeMotorista}");
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine("\nNão foi possível aceitar a corrida");
            Thread.Sleep(4000);
            Console.Clear();
        }
    }

    public void FinalizarCorrida(Corrida corrida)
    {
        if (corrida.Status == "Em andamento")
        {
            Saldo += corrida.Preco;
            corrida.Status = "Finalizada";
            Console.WriteLine($"\n{NomeMotorista} finalizou uma corrida de {corrida.DistanciaKm} Km.");
            Thread.Sleep( 4000 );
            Console.Clear();
        }
        else
        {
            Console.WriteLine("\nNão foi possível finalizar a corrida..");
            Thread.Sleep(4000);
            Console.Clear();
        }
    }
}