// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace explorando.Models
// {
//     public class Curso
//     {
//         public string Nome { get; set; }
//         public List<Pessoa> Alunos { get; set; }

//         public void AdicionarAluno(Pessoa aluno)
//         {
//             Alunos.Add(aluno);
//         }

//         public int ObterQuantidadeDeAlunosMatriculados(){
//             int quantidade = Alunos.Count();
//             return quantidade;
//         }

//         public bool RemoverAluno(Pessoa aluno){
//             return Alunos.Remove(aluno);
//         }

//         public void ListasAlunos(){

//             Console.WriteLine($"Alunos do Curso de: {Nome}");
//             for (int count = 0; count < Alunos.Count; count++)
//             {
//                 //string texto = "Nº" + count + " " + Alunos[count].NomeCompleto;
//                 string texto = $"Nº {count + 1} - {Alunos[count].NomeCompleto}";
//                 Console.WriteLine(texto);
//             }

//         }
//     }
// }