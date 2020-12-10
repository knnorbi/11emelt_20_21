using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAndOOP
{
    class Triangle
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void SetSides(int _a, int _b, int _c)
        {
            if (_a <= 0 || _b <= 0 || _c <= 0 || !IsValid(_a, _b, _c))
            {
                return;
            }

            A = _a;
            B = _b;
            C = _c;
        }

        public int Perimeter
        {
            get 
            {
                return A + B + C;
            }
        }

        public bool IsValid()
        {
            return IsValid(A, B, C);
        }

        public bool IsValid(int a, int b, int c)
        {
            bool aValid = a > b + c;
            bool bValid = b > a + c;
            bool cValid = c > b + a;

            return aValid && bValid && cValid;
        }

        public override string ToString()
        {
            return $"A:{A} B:{B} C:{C}";
        }
    }
}
