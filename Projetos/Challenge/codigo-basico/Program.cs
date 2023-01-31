using System.IO;
using System.Linq;

class DIO {

    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
        string[] v = new string[2];

        for (int i = 0; i < qt; ++i)                
        {
            v = Console.ReadLine().Split("");   
            string a = v[0];
            string b = v[1];

            if (b.Length > a.Length)
                Console.WriteLine("nao encaixa");
            else if (a.EndsWith(b))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");

        }

    }

}






























// using System;

// class DIO {
        
// static void Main(string[] args){

//     //variaveis
//     int numero = 0;
//     int digito = 0;
//     int soma = 0;
//     int produto = 1;
    

//     //mostra mensagem ao usuario e guarda variavel
//     Console.WriteLine("Digite um numero ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     //calculo
//             while (numero > 0){
//                 digito = numero % 10;//ultimo digito
//                 soma = soma + digito;
//                 produto = produto * digito;
//                 numero = numero / 10;
//             }
//             Console.WriteLine("Soma entre os digitos é: " + soma);

//         Console.WriteLine("Produto entre os digitos é: " + produto);

//         Console.WriteLine("Resultado da diferença entre Produto e Soma é: " + (produto-soma));
//     }
// }


