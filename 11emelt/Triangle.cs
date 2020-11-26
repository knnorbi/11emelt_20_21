using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11emelt
{
    class Triangle
    {
        int a;
        int b;
        int c;

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void SetSides(int _a, int _b, int _c)
        {
            if (_a <= 0 || _b <= 0 || _c <= 0 || !IsValid(_a, _b, _c))
            {
                return;
            }

            a = _a;
            b = _b;
            c = _c;
        }

        public int Perimeter()
        {
            return a + b + c;
        }

        public bool IsValid()
        {
            return IsValid(a, b, c);
        }

        public bool IsValid(int a, int b, int c)
        {
            bool aValid = a > b + c;
            bool bValid = b > a + c;
            bool cValid = c > b + a;

            return aValid && bValid && cValid;
        }

    }
}
