﻿// Programa IMC

// Faça um programa que calcule o imc de uma pessoa recebendo ow dados
// no console, ao final imprima o resultado no console

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine(@$"
.    ----------------   .    
.   / Programa para  \  .
.   \ calcular o IMC /  .
.    ----------------   .");
Console.ResetColor();

Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine($"Informe o nome do paciente: ");
string nome = Console.ReadLine();

Console.WriteLine($"Informe o peso atual do paciente: ");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a altura do paciente: ");
float altura = float.Parse(Console.ReadLine());
Console.ResetColor();

float imc = peso / ((float)Math.Pow(altura,2));

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"O paciente {nome} tem o imc igual á {imc}");
Console.ResetColor();
