using project1.common.Models;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("GO");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens da minha lista : {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("BA");

Console.WriteLine($"Itens da minha lista : {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("GO");

Console.WriteLine($"Itens da minha lista : {listaString.Count} - Capacidade: {listaString.Capacity}");




// for(int contador = 0; contador < listaString.Count; contador++) {
//     Console.WriteLine(listaString[contador]);

// }

// int contadorforeach = 0;
// foreach(string contador in listaString) {
//     Console.WriteLine($"Estado: {contadorforeach} - {contador}");
//     contadorforeach ++;

// }

// int [] arrayInteiros = new int [3];

// arrayInteiros[0]= 72;
// arrayInteiros[1]= 64;
// arrayInteiros[2]= 50;

// Console.WriteLine("Percorrendo Array com for");
// for( int contador = 0; contador < arrayInteiros.Length; contador ++) {
//     Console.WriteLine($"Posição nº{contador} - {arrayInteiros[contador]}" );
// }

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// Console.WriteLine("Percorrendo Array com FOREACH");
// foreach (int valor in arrayInteiros) {
//     Console.WriteLine(valor);
// }
























// Person person1 = new Person();

// person1.Name = "John";
// person1.Age = 21;

// person1.Show();
