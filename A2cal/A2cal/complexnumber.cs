using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2cal
{
   public class ComplexNumber
    {
        public float real    //property
        {
            get;
            set;
        }
        public float imaginary
       {
           get;
           set;
       }
        public ComplexNumber(float r, float i)
       {
           real = r;
           imaginary = i;
       }   
        public ComplexNumber Reciprocal()
       {
           float scale = real*real + imaginary*imaginary;
           return new ComplexNumber(real/scale , -imaginary/scale);
       }
    }
}
