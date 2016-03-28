using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A2cal;

namespace EasonLee
{
    public class SimpleCal
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiplication(double num1, double num2)
        {
            return Convert.ToDouble(num1) * num2;
        }
        public double Division(double num1, double num2)
        {
            return Convert.ToDouble(num1) / num2;
        }
    }
    public class ComplexCal
    {
        public ComplexNumber Add(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.real + num2.real, num1.imaginary + num2.imaginary);
        }
        public ComplexNumber Subtraction(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.real - num2.real, num1.imaginary - num2.imaginary);
        }
        public ComplexNumber Multiplication(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.real * num2.real - num1.imaginary * num2.imaginary, num1.real * num2.imaginary + num1.imaginary * num2.real);
        }
        public ComplexNumber Division(ComplexNumber num1, ComplexNumber num2)
        {
            return Multiplication(num1, num2.Reciprocal());
        }

    }
}

