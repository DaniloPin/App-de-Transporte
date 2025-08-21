public class AppCorrida
{
    public List<Passageiro> Passageiros { get; set; } = new List<Passageiro>();
    public List<Motorista> Motoristas { get; set; } = new List<Motorista>();
    public List<Corrida> Corridas { get; set; } = new List<Corrida>();


    public void CadastrarPassageiro(Passageiro passageiro)
    {
        Passageiros.Add(passageiro);
 
    }

    public void CadastrarMotorista(Motorista motorista)
    {
        Motoristas.Add(motorista);
        Console.WriteLine($"\nMotorista {motorista.NomeMotorista} cadastrado com sucesso.");
        Thread.Sleep(2000);
        Console.Clear();
    }

    public void SolicitarCorrida(Passageiro passageiro, double distancia)
    {
        Corrida corrida = new Corrida();
        corrida.Passageiro = passageiro;
        corrida.DistanciaKm = distancia;
        corrida.Status = "Solicitada";

        corrida.CalcularCorrida();
        Corridas.Add(corrida);

        Console.WriteLine($"Corrida solicitada com sucesso pelo passageiro {passageiro.Nome}");
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void ListarCorridas(List<Corrida> corridas)
    {
        Corridas = corridas;

        if (corridas == null || corridas.Count == 0)
        {
            Console.WriteLine("Não há histórico de corridas no momento.");
            Thread.Sleep(2000);
            Console.Clear();
            return;
        }

        foreach(var c in corridas)
        {
            string motorista;
            string passageiro;

            if (c.Motorista != null)
            {
                motorista = c.Motorista.NomeMotorista;
            }
            else
            {
                motorista = "Não definido";
            }

            if (c.Passageiro != null)
            {
                passageiro = c.Passageiro.Nome;
            }
            else
            {
                passageiro = "Não definido";
            }
            Console.WriteLine($"\nPassageiro: {passageiro} | Motorista: {motorista} | Distância: {c.DistanciaKm} km | Preço: R$ {c.Preco:F2} | Status: {c.Status}");
            
            Console.Clear();
        }
    }
}

