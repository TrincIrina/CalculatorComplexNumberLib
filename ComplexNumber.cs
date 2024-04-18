using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorComplexNumberLib
{
    // Калькулятор комплексных чисел
    // ComplexNumber - класс - представление комплексного числа
    public class ComplexNumber
    {
        // Действительная часть комплексного числа
        public double Re { get; set; }
        // Коэфициент при мнимой части
        public double Im { get; set; }
        // Конструктор
        public ComplexNumber(double re, double im)
        {
            Re = re;
            Im = im;
        }
        // Изменение знака
        public ComplexNumber invert()
        {
            return new ComplexNumber(-Re, -Im);
        }
        // Инкремент & Декремент
        public ComplexNumber increment()
        {
            return new ComplexNumber(Re++, Im++);
        }
        public ComplexNumber decrement()
        {
            return new ComplexNumber(Re--, Im--);
        }
        // Нахождение модуля 
        public double module()
        {
            return Math.Sqrt(Re * Re + Im * Im);
        }
        // Вывод комплексного числа
        public override string ToString()
        {
            return $"{Re} + {Im}i";
        }
    }
}
