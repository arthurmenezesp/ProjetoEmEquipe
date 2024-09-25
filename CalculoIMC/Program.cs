using System;
class Program
{
static void Main()
{
Console.WriteLine("Insira a sua altura: ");
double altura = double.Parse(Console.ReadLine());
Console.WriteLine("Insira seu peso: ");
double peso = double.Parse(Console.ReadLine());
double imc = peso / (altura * altura);
Console.WriteLine($"Seu IMC é {imc}");
}
}
