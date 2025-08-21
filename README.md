App de Corridas

Este projeto é um simulador de aplicativo de transporte, desenvolvido em C#. Ele permite que passageiros solicitem corridas, motoristas aceitem, e o sistema gerencie o saldo de cada usuário. O projeto foi desenvolvido como prática de orientação a objetos, classes, métodos e interação com o console.

Funcionalidades
- Cadastrar Passageiro: Adicione um passageiro com nome e saldo inicial.
- Cadastrar Motorista: Adicione um motorista com nome e carro.
- Solicitar Corrida: Passageiro escolhe motorista disponível e define a distância. O preço é calculado automaticamente.
- Finalizar Corrida: Finaliza a corrida, atualizando o saldo do passageiro e do motorista.
- Listar Corridas: Exibe todas as corridas cadastradas com detalhes como passageiro, motorista, distância, preço e status.

Tecnologias
- C#
- .NET
- Console Application

Estrutura de Classes:
- Passageiro
  - Nome (string)
  - Saldo (double)
  - Métodos: PegarCorrida(), DevolverCorrida()

- Motorista
  - NomeMotorista (string)
  - Carro (string)
  - Saldo (double)
  - Métodos: AceitarCorrida(), FinalizarCorrida()

- Corrida
  - Passageiro (Passageiro)
  - Motorista (Motorista)
  - DistanciaKm (double)
  - Preco (double)
  - Status (string)
  - Métodos: CalcularCorrida(), FinalizarCorrida(), CancelarCorrida()

- AppCorrida
  - List<Passageiro>
  - List<Motorista>
  - List<Corrida>
  - Métodos: CadastrarPassageiro(), CadastrarMotorista(), SolicitarCorrida(), ListarCorridas()
