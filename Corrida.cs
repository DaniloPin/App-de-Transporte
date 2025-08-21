public class Corrida
{
    public Passageiro Passageiro { get; set; }
    public Motorista Motorista { get; set; }
    public double DistanciaKm { get; set; }
    public double Preco { get; set; }
    public string Status { get; set; }


    public void CalcularCorrida()
    {
        double valorDaDistancia = 2.50;
        Preco = DistanciaKm * valorDaDistancia;

        Console.WriteLine($"\nO preço da corrida será de R$ {Preco:F2} reais");
        Thread.Sleep(4000);
        Console.Clear();
    }

    public void Iniciar()
    {
        if( Motorista != null && Passageiro != null && Status == "Aceita")
        {
            Status = "Em andamento";
            Console.WriteLine($"\nA corrida foi iniciado com passageiro {Passageiro.Nome} e o motorista é o {Motorista.NomeMotorista}");
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine("\nNão foi possível iniciar a corrida.");
            Thread.Sleep(4000);
            Console.Clear();
        }
    }

    public void FinalizarCorrida()
    {
        if (Status == "Em andamento" && Passageiro != null && Motorista != null)
        {
            Status = "Finalizada";
            Passageiro.Saldo -= Preco;
            Console.WriteLine($"\nCorrida do(a) {Passageiro.Nome} com motorista {Motorista.NomeMotorista} foi finalizada com sucesso.");
            Thread.Sleep(4000);
            Console.Clear();
        }
        else {
            Console.WriteLine("Não foi possível finalizar a corrida.");
            Thread.Sleep(4000);
            Console.Clear();
        }
    }

    public void CancelarCorrida()
    {
        if (Status == "Solicitada" && Passageiro != null && Motorista != null)
        {
            Status = "Cancelada";
            Console.WriteLine($"\nCorrida do(a) {Passageiro.Nome} com motorista {Motorista.NomeMotorista} foi cancelada com sucesso.");
            Console.WriteLine($"\n===== Nenhum valor foi debitado da conta do passageiro =====");
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Não foi possível cancelar a corrida.");
            Thread.Sleep(4000);
            Console.Clear();
        }

    }
}
 
