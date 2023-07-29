using Geometry;
using NUnit.Framework;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Geometry.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FirstTest()
        {
            // Параметры
            double a = 10;
            double result = 314;

            // Вызов метода из класса
            Figure figure = new(a);
            double answer = figure.GetSquare();

            // Сравнение ожидаемого результата с полученным
            if (result == answer)
                Assert.Pass();
            else Assert.Fail();
        }

        [Test]
        public void SecondTest()
        {
            // Параметры
            double a = 12;
            double b = 13;
            double c = 14;
            double result = 72;

            // Вызов метода из класса
            Figure figure = new(a, b, c);
            double answer = figure.GetSquare();

            // Сравнение ожидаемого результата с полученным
            if (result == answer)
                Assert.Pass();
            else Assert.Fail();
        }

        [Test]
        public void ThirdTest()
        {
            // Параметры
            double a = 3;
            double b = 4;
            double c = 5;
            bool result = true; // Треугольник является прямоугольным

            // Вызов метода из класса
            Figure figure = new(a, b, c);
            bool answer = figure.IsRightTriangle();

            // Сравнение ожидаемого результата с полученным
            if (result == answer)
                Assert.Pass();
            else Assert.Fail();
        }

        [Test]
        public void FourthTest()
        {
            double a = 3;
            double b = 0;
            double c = 5;


            var ex = Assert.Throws<ArgumentException>(() => { Figure figure = new(a, b, c); });
            StringAssert.Contains("Неверно указан параметр.", ex.Message.ToString());
        }

        [Test]
        public void FiveTest()
        {
            double a = 3;
            double b = 10;
            double c = 5;

            var ex = Assert.Throws<ArgumentException>(() => { Figure figure = new(a, b, c); });
            StringAssert.Contains("Наибольшая сторона треугольника должна быть меньше суммы других сторон.", ex.Message.ToString());
        }
    }
}