using System;
class DIO {
        
static void Main(string[] args){

        //variaveis
    int numero = 0;
    int digito = 0;
    int soma = 0;
    int produto = 1;
    

    //mostra mensagem ao usuario e guarda variavel
    Console.WriteLine("Digite um numero");
    numero = Convert.ToInt32(Console.ReadLine());

    //calculo
            while (numero > 0){
                digito = numero % 10;//ultimo digito
                soma = soma + digito;
                produto = produto * digito;
                numero = numero / 10;
            }
        
        Console.WriteLine("Soma entre os digitos é: " + soma);

        Console.WriteLine("Produto entre os digitos é: " + produto);

        Console.WriteLine("Resultado da diferença entre Produto e Soma é: " + (produto-soma));
        }
    }