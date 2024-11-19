// See https://aka.ms/new-console-template for more information

using NetCsharpStructComplexNumbers;
using System.Numerics;

ComplexNums c1 = new ComplexNums(3, "4i");
ComplexNums c2 = new ComplexNums(1, "-2i");

ComplexNums.Add(c1, c2);
ComplexNums.Substract(c1, c2);
ComplexNums.Mult(c1, c2);
ComplexNums.Div(c1, c2);
