﻿
using Secao4_ExerciciosFixacao1_1;
using System.Globalization;

Retangulo retangulo = new Retangulo();
Console.WriteLine("Digite a largura e a altura do retângulo:");
retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Area = " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Perímetro = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Diagonal = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));