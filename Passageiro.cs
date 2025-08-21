public class Passageiro
{
    public string Nome { get; set; }
    public double Saldo { get; set; }


    public void PegarCorrida(Corrida corrida)
    {
        if(corrida.Status == "Solicitada" && Saldo >= corrida.Preco)
        {
            corrida.Passageiro = this;
            corrida.Status = "Em andamento";
            Console.WriteLine($"\n{Nome} iniciou uma corrida de {corrida.DistanciaKm} Km.");
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Não foi possível solicitar a corrida.");
            Thread.Sleep(4000);
            Console.Clear();
        }
    }

    public void DevolverCorrida(Corrida corrida)
    {
        if (corrida.Status == "Em andamento")
        {
            corrida.Status = "Finalizada";
            Console.WriteLine($"\n{Nome} finalizou uma corrida de {corrida.DistanciaKm} Km.");
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Não foi possível finalizar a corrida.");
            Thread.Sleep(4000);
            Console.Clear();
        }
    }
}