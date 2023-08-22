
using ConceitosBasicos;

int num1 = 20;
int num2 = 11, result;

somador soma;
soma = new somador();

result = soma.Soma(num1, num2);

Console.WriteLine($"A soma dos numeros {num1} + {num2} é { result}");

//A soma dos numeros __ + __ é __

//using ConceitosBasicos;

//Conversor conversor = new Conversor();
double metros = 1.76;
Console.WriteLine("A medida {0} metros corresponde a {1}",metros,Conversor.MetrosMilimetros(1.76));
//saida exibe A medida ___ metros corresponde a ___ miliometros