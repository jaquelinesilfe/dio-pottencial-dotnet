using System.Text;
using desafio__hospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

//Criar lista

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hospede 1");
Pessoa p2 = new Pessoa(nome: "Hospede 2");

hospedes.Add(p1);
hospedes.Add(p2);

//Cria suite

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

//Cria uma nova reserva

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

 //Exibe quantidade de hospedes e valor da diaria
 Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
 Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");