﻿// somar args + args

var operacao = args[0];
var n1 = Convert.ToDouble(args[1]);
var n2 = Convert.ToDouble(args[2]);

// dotnet run -- ['Somar' '1,2' '3,4']

if (operacao == "Somar")
{
    Console.WriteLine(n1 + n2);
}

// subtrair

if (operacao == "Subtrair")
{
    Console.WriteLine(n1 - n2);
}

// multiplicar

Console.WriteLine("Obrigado por usar o programa.");

if (operacao == "Multiplicar")
{
    Console.WriteLine(n1 * n2);
}

// dividir

if (operacao == "Dividir")
{
    Console.WriteLine(n1 / n2);
}