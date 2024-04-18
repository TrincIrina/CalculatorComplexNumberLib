using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorComplexNumberLib
{
    // OperationsNumbers - класс, описывающий операции над комплексными числами
    internal class OperationsNumbers
    {
        // Поля - комплексные числа
        public ComplexNumber Number_1 { get; set; }
        public ComplexNumber Number_2 { get; set; }
        // Конструктор
        public OperationsNumbers(ComplexNumber number_1, ComplexNumber number_2)
        {
            Number_1 = number_1;
            Number_2 = number_2;
        }
        // Сложение чисел
        public ComplexNumber Sum()
        {
            return new ComplexNumber(Number_1.Re + Number_2.Re, Number_1.Im + Number_2.Im);
        }
        // Вычистание
        public ComplexNumber Sub()
        {
            return new ComplexNumber(Number_1.Re - Number_2.Re, Number_1.Im - Number_2.Im);
        }
        // Умножение
        public ComplexNumber Mult()
        {
            double re = Number_1.Re * Number_2.Re - Number_2.Im * Number_2.Im;
            double im = Number_1.Re * Number_2.Im + Number_2.Im * Number_2.Re;
            return new ComplexNumber(re, im);
        }
        // Деление
        public ComplexNumber Division()
        {
            double de = (Number_2.Re + Number_2.Im) * (Number_2.Re + Number_2.Im);
            double re = Number_1.Re * Number_2.Re + Number_2.Im * Number_2.Im;
            double im = Number_1.Im * Number_2.Re - Number_2.Re * Number_2.Im;
            return new ComplexNumber(re/de, im/de);
        }
    }
}
