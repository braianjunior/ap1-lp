using System;
int continuar = 1;
do
{
    Console.WriteLine("----digite seu nome----");
    string nome = Convert.ToString(Console.ReadLine());
    Console.WriteLine("-----digite sua idade peso e altura-----");
    int idade = Convert.ToInt32(Console.ReadLine());
    double peso = Convert.ToDouble(Console.ReadLine());
    double altura = Convert.ToDouble(Console.ReadLine());
    double imc = peso / (altura * altura);
    Console.WriteLine($"seu imc sera{Math.Cos(imc)}");
    if (idade <= 10)
    {
        Console.WriteLine("criança");
    }
    else if (idade <= 18)
    {
        Console.WriteLine("adolecente");
    }
    else if (idade <= 18)
    {
        Console.WriteLine("adulto");
    }
    if (imc <= 18.5)
    {
        Console.WriteLine($"nome: {nome}.");
        Console.WriteLine($"sua idade :{idade}");
        Console.WriteLine($"seu peso:{peso}");
        Console.WriteLine($"sua altura:{altura}");
        Console.WriteLine("magreza");

    }
    else if (imc <= 24.9)
    {
        Console.WriteLine($"nome: {nome}.");
        Console.WriteLine($"sua idade :{idade}");
        Console.WriteLine($"seu peso:{peso}");
        Console.WriteLine($"sua altura:{altura}");
        Console.WriteLine("normal");
    }
    else if (imc <= 29.9)
    {
        Console.WriteLine($"nome: {nome}.");
        Console.WriteLine($"sua idade :{idade}");
        Console.WriteLine($"seu peso:{peso}");
        Console.WriteLine($"sua altura:{altura}");
        Console.WriteLine("sobrepeso");
    }
    else if (imc < 34.9)
    {
        Console.WriteLine($"nome: {nome}.");
        Console.WriteLine($"sua idade :{idade}");
        Console.WriteLine($"seu peso:{peso}");
        Console.WriteLine($"sua altura:{altura}");
        Console.WriteLine("obsidade grau 1");
    }
    else if (imc <= 39.9)
    {
        Console.WriteLine($"nome: {nome}.");
        Console.WriteLine($"sua idade :{idade}");
        Console.WriteLine($"seu peso:{peso}");
        Console.WriteLine($"sua altura:{altura}");
        Console.WriteLine("obesidade grau 2");
    }
    else
    {
        Console.WriteLine($"nome: {nome}.");
        Console.WriteLine($"sua idade :{idade}");
        Console.WriteLine($"seu peso:{peso}");
        Console.WriteLine($"sua altura:{altura}");
        Console.WriteLine("obesidade grau 3");

    }
    Console.WriteLine("quer ver outro imc? 1:para sim, 0:para não");
    continuar = Convert.ToInt32(Console.ReadLine());
} while (continuar != 0);