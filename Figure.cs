using System;

namespace Geometry
{
    public class Figure : IFigure
    {
        internal double SideA { get; }
        private double SideB { get; }
        private double SideC { get; }
        private double Radius { get; }

        /// <summary>
        /// Конструктор класса, производит проверку и запись вошедших данных
        /// </summary>
        /// <param name="parametrA">Радиус круга</param>
        /// <exception cref="ArgumentException">Передаваемый параметр не может быть меньше нуля</exception>
        public Figure(double parametrA)
        {
            if (parametrA < 0)
                throw new ArgumentException("Неверно указан параметр.", nameof(parametrA));
            Radius = parametrA;
            SideB = 0;
            SideC = 0;
        }

        /// <summary>
        /// Конструктор класса, производит проверку и запись вошедших данных
        /// </summary>
        /// <param name="parametrA">Сторона А</param>
        /// <param name="parametrB">Сторона В</param>
        /// <param name="parametrC">Сторона С</param>
        /// <exception cref="ArgumentException">Передаваемый параметр не может быть меньше нуля</exception>
        public Figure(double parametrA, double parametrB, double parametrC)
        {
            if (parametrA <= 0)
                throw new ArgumentException("Неверно указан параметр.", nameof(parametrA));

            if (parametrB <= 0)
                throw new ArgumentException("Неверно указан параметр.", nameof(parametrB));

            if (parametrC <= 0)
                throw new ArgumentException("Неверно указан параметр.", nameof(parametrC));

            var maxEdge = Math.Max(parametrA, Math.Max(parametrB, parametrC));
            if (((parametrA + parametrB + parametrC) - maxEdge) - maxEdge < 0)
                throw new ArgumentException("Наибольшая сторона треугольника должна быть меньше суммы других сторон.");

            SideA = parametrA;
            SideB = parametrB;
            SideC = parametrC;
        }

        /// <summary>
        /// Расчёт площади фигуры по введенным параметрам
        /// </summary>
        /// <returns></returns>
        public double GetSquare()
        {
            if (SideB != 0 && SideC != 0)
            {
                var halfP = (SideA + SideB + SideC) / 2;
                var square = Math.Sqrt(halfP * (halfP - SideA) * (halfP - SideB) * (halfP - SideC));
                return Math.Round(square);
            }
            return Math.Round(Math.PI * Math.Pow(Radius, 2));
        }

        /// <summary>
        /// Определение, является ли треугольник прямоугольным или нет
        /// </summary>
        /// <returns>True - если является, False - если не является </returns>
        public bool IsRightTriangle()
        {
            if (SideB == 0 && SideC == 0)
            {
                throw new ArgumentException("Неверно указан параметр.");
            }
            if (Math.Pow(SideC, 2) + Math.Pow(SideB, 2) == Math.Pow(SideA, 2))
                return true;
            if (Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2))
                return true;
            if (Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2))
                return true;

            return false;
        }
    }
}