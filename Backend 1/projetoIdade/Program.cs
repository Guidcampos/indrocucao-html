﻿Console.WriteLine($"Insira seu ano de nascimento:");
int nascimento = int.Parse(Console.ReadLine());

int anos = 2023 - nascimento;
int semanas = anos * 52;

Console.WriteLine($"Seu ano de nascimento é {nascimento}, sua idade é {anos} anos, que é igual a {semanas} semanas");
