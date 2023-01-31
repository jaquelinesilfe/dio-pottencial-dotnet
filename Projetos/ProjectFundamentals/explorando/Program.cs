using Newtonsoft.Json;
using explorando.Models;
using Models;
using System;
using System.Globalization;
using Models.MeuArray;


MeuArray<int> arrayInteiro = new MeuArray<int>();


arrayInteiro.AdicionarElementoArray(30);

Console.WriteLine(arrayInteiro[0]);





// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda){
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preco: {venda.Preco}, Data: {venda.DataVenda.toString("dd/MM/yyyy HH:mm")}");
// }


// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licenca de software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);



// Console.WriteLine(serializado);





// Pessoa p1 = new Pessoa("Jaqueline", "Silfe");

// Pessoa p2 = new Pessoa("Eduardo", "Neves");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Sobrenome = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1, p2);
// cursoDeIngles.ListasAlunos();

// try
// {

//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (Exception ex)
// {

//     Console.WriteLine($"Ocorreu uma excecao generica {ex.Message}");
// }

// Console.WriteLine("Você chegou ate aqui");