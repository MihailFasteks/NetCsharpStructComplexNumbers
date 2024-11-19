using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCsharpStructComplexNumbers
{
    struct ComplexNums
    {
        public  int real {  get; set; }
        public string imaginary { get; set; }
    
        public ComplexNums(int real, string imag)
        {
            this.real = real;
            this.imaginary = imag;
        }
        public static int ToReal(string im)
        {

            int tempreal = int.Parse(im.Replace(" ", "").Replace("i", "").Trim());
          
            return tempreal;

        }
        public static void Add(ComplexNums c1, ComplexNums c2)
        {
            int resReal = c1.real + c2.real;
            int resImag=ToReal(c1.imaginary)+ToReal(c2.imaginary);
            if (resImag >= 0)
            {
                Console.WriteLine(resReal + " " + "+" + " " + resImag + "i");
            }
            else
            {
                Console.WriteLine(resReal + " "+resImag + "i");
            }
        }
        public static void Substract(ComplexNums c1, ComplexNums c2)
        {
            int resReal = c1.real - c2.real;
            int resImag = ToReal(c1.imaginary) - ToReal(c2.imaginary);
            if (resImag >= 0)
            {
                Console.WriteLine(resReal + " " + "+" + " " + resImag + "i");
            }
            else
            {
                Console.WriteLine(resReal + " " + resImag + "i");
            }
        }
        public static void Mult(ComplexNums c1, ComplexNums c2)
        {
            int resReal = (c1.real*c2.real)-(ToReal(c1.imaginary) * ToReal(c2.imaginary));
            int resImag = (c1.real * ToReal(c2.imaginary)) + (ToReal(c1.imaginary) * c2.real);
            if (resImag >= 0)
            {
                Console.WriteLine(resReal + " " + "+" + " " + resImag + "i");
            }
            else
            {
                Console.WriteLine(resReal + " " + resImag + "i");
            }
        }
        public static void Div(ComplexNums c1, ComplexNums c2)
        {
            int a = c1.real;
            int b = ToReal(c1.imaginary);
            int c = c2.real;
            int d = ToReal(c2.imaginary);
            int detorminator = (c * c + d + d);
            int resReal = (a * c + b * d) / detorminator;
            int resImag = (b * c - a * d) / detorminator;
            if (resImag >= 0)
            {
                Console.WriteLine(resReal + " " + "+" + " " + resImag + "i");
            }
            else
            {
                Console.WriteLine(resReal + " " + resImag + "i");
            }
        }

    }
    
}
