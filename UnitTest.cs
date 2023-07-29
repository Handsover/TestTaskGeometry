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
            // ���������
            double a = 10;
            double result = 314;

            // ����� ������ �� ������
            Figure figure = new(a);
            double answer = figure.GetSquare();

            // ��������� ���������� ���������� � ����������
            if (result == answer)
                Assert.Pass();
            else Assert.Fail();
        }

        [Test]
        public void SecondTest()
        {
            // ���������
            double a = 12;
            double b = 13;
            double c = 14;
            double result = 72;

            // ����� ������ �� ������
            Figure figure = new(a, b, c);
            double answer = figure.GetSquare();

            // ��������� ���������� ���������� � ����������
            if (result == answer)
                Assert.Pass();
            else Assert.Fail();
        }

        [Test]
        public void ThirdTest()
        {
            // ���������
            double a = 3;
            double b = 4;
            double c = 5;
            bool result = true; // ����������� �������� �������������

            // ����� ������ �� ������
            Figure figure = new(a, b, c);
            bool answer = figure.IsRightTriangle();

            // ��������� ���������� ���������� � ����������
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
            StringAssert.Contains("������� ������ ��������.", ex.Message.ToString());
        }

        [Test]
        public void FiveTest()
        {
            double a = 3;
            double b = 10;
            double c = 5;

            var ex = Assert.Throws<ArgumentException>(() => { Figure figure = new(a, b, c); });
            StringAssert.Contains("���������� ������� ������������ ������ ���� ������ ����� ������ ������.", ex.Message.ToString());
        }
    }
}