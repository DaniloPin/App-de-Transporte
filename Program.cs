AppCorrida app = new AppCorrida();
int opcao;

do
{
    Console.WriteLine("===== APP DE CORRIDAS =====");
    Console.WriteLine("\n1 - Cadastrar Passageiro");
    Console.WriteLine("2 - Cadastrar Motorista");
    Console.WriteLine("3 - Solicitar Corrida");
    Console.WriteLine("4 - Finalizar Corrida");
    Console.WriteLine("5 - Listar Corridas");
    Console.WriteLine("0 - Sair");
    Console.Write("\nEscolha uma opção: ");
    opcao = int.Parse(Console.ReadLine()!);
    Console.Clear();

    switch (opcao)
    {
        case 1:
            Console.WriteLine("===== Cadastro de Passageiro =====");
            Console.Write("\nNome do Passageiro: ");
            string nomePassageiro = Console.ReadLine()!;
            Console.Write("Saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine()!);
            Console.Clear();

            Passageiro passageiro = new Passageiro { Nome = nomePassageiro, Saldo = saldo };
            app.CadastrarPassageiro(passageiro);
            break;

        case 2:
            Console.WriteLine("===== Cadastro de Motorista =====");
            Console.Write("\nNome do(a) Motorista: ");
            string nomeMotorista = Console.ReadLine()!;
            Console.Write("Carro: ");
            string carro = Console.ReadLine()!;

            Motorista motorista = new Motorista { NomeMotorista = nomeMotorista, Carro = carro, Saldo = 0 };
            app.CadastrarMotorista(motorista);
            break;

        case 3:
            if (app.Passageiros.Count == 0 || app.Motoristas.Count == 0)
            {
                Console.WriteLine("Cadastre pelo menos um passageiro ou um motorista antes de solicitar a corrida.");
                Thread.Sleep(3000);
                Console.Clear();
                break;
            }

            Console.WriteLine("===== Solicitação de Corrida =====");
            Console.WriteLine("\nPassageiros disponíveis:\n");

            for (int i = 0; i < app.Passageiros.Count; i++)
            
                Console.WriteLine($"{i + 1} - {app.Passageiros[i].Nome}");
                Console.Write("\nEscolha o passageiro (número): ");
                int idxPassageiro = int.Parse(Console.ReadLine()!) - 1;
            

            Console.WriteLine("\nMotoristas disponíveis:\n");

            for (int i = 0; i < app.Motoristas.Count; i++)
            
                Console.WriteLine($"{i + 1} - {app.Motoristas[i].NomeMotorista} - {app.Motoristas[i].Carro}");
                Console.Write("\nEscolha o motorista (número): ");
                int idxMotorista = int.Parse(Console.ReadLine()!) - 1;
            

            Console.Write("\nDistância da corrida (km): ");
            double distancia = double.Parse(Console.ReadLine()!);

            Corrida corrida = new Corrida 
            {
                Passageiro = app.Passageiros[idxPassageiro],
                Motorista = app.Motoristas[idxMotorista],
                DistanciaKm = distancia,
                Status = "Em andamento"
            };
            corrida.CalcularCorrida();
            app.Corridas.Add(corrida);
            Console.WriteLine($"Corrida criada! Preço: R$ {corrida.Preco:F2}");
            Thread.Sleep(2000);
            Console.Clear();
            break;

        case 4:
            if (app.Corridas.Count == 0)
            {
                Console.WriteLine("\nNão há corridas para finalizar.");
                Thread.Sleep(3000);
                Console.Clear();
                break;
            }

            Console.WriteLine("===== Finalizar Corrida =====");
            for (int i = 0; i < app.Corridas.Count; i++)
                Console.WriteLine($"\n{i + 1} - {app.Corridas[i].Passageiro.Nome} | {app.Corridas[i].Motorista.NomeMotorista} | Status: {app.Corridas[i].Status}");
            Console.Write("\nEscolha a corrida a finalizar (número): ");
            int idxCorrida = int.Parse(Console.ReadLine()!) - 1;

            app.Corridas[idxCorrida].FinalizarCorrida();
            Thread.Sleep(4000);
            Console.Clear();
            break;

        case 5:
            app.ListarCorridas(app.Corridas);
            Thread.Sleep(4000);
            Console.Clear();
            break;

        case 0:
            Console.WriteLine("Saindo do aplicativo...");
            Thread.Sleep(2000);
            break;

        default:
            Console.WriteLine("\nOpção inválida. Tente novamente.");
            Thread.Sleep(2000);
            Console.Clear();
            break;
    }

} while (opcao != 0);