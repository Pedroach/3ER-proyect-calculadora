using NUnit.Framework;
using WebOperaciones.Properties.Controllers;

namespace NUnitTestCalculadora
{
    public class TestCalculadora
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSuma1()
        {
            //Arrange=preparacion
            int num1 = 5;
            int num2 = 7;
            int esperado = 12;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.sumar(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestSuma2()
        {
            //Arrange=preparacion
            int num1 = 3;
            int num2 = 3;
            int esperado = 6;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.sumar(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestSuma3()
        {
            //Arrange=preparacion
            int num1 = 5;
            int num2 = 5;
            int esperado = 10;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.sumar(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestSumar1()
        {
            //Arrange=preparacion
            int num1 = 4;
            int num2 = 5;
            int esperado = 9;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.suma(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestSumar2()
        {
            //Arrange=preparacion
            int num1 = 3;
            int num2 = 5;
            int esperado = 8;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.suma(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestSumar3()
        {
            //Arrange=preparacion
            int num1 = 10;
            int num2 = 10;
            int esperado = 20;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.suma(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        
        [Test]
        public void TestResta1()
        {
            //Arrange=preparacion
            int num1 = 10;
            int num2 = 5;
            int esperado = 5;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.resta(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestResta2()
        {
            //Arrange=preparacion
            int num1 = 100;
            int num2 = 10;
            int esperado = 90;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.resta(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestResta3()
        {
            //Arrange=preparacion
            int num1 = 10;
            int num2 = 20;
            int esperado = -10;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.resta(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestRestar1()
        {
            //Arrange=preparacion
            int num1 = 50;
            int num2 = 25;
            int esperado = 25;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.restar(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestRestar2()
        {
            //Arrange=preparacion
            int num1 = 15;
            int num2 = 7;
            int esperado = 8;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.restar(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestRestar3()
        {
            //Arrange=preparacion
            int num1 = 60;
            int num2 = 25;
            int esperado = 35;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.restar(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }/*
        [Test]
        public void TestMultiplicacion1()
        {
            //Arrange=preparacion
            int num1 = 3;
            int num2 = 3;
            int esperado = 9;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.multiplicacion(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestMultiplicacion2()
        {
            //Arrange=preparacion
            int num1 = 4;
            int num2 = 4;
            int esperado = 16;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.multiplicacion(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestMultiplicacion3()
        {
            //Arrange=preparacion
            int num1 = 10;
            int num2 = 10;
            int esperado = 100;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.multiplicacion(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestMulti1()
        {
            //Arrange=preparacion
            int num1 = 2;
            int num2 = 8;
            int esperado = 16;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.multi(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestMulti2()
        {
            //Arrange=preparacion
            int num1 = 7;
            int num2 = 7;
            int esperado = 49;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.multi(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestMulti3()
        {
            //Arrange=preparacion
            int num1 = 5;
            int num2 = 3;
            int esperado = 15;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.multi(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestDividir1()
        {
            //Arrange=preparacion
            int num1 = 4;
            int num2 = 2;
            int esperado = 2;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.dividir(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestDividir2()
        {
            //Arrange=preparacion
            int num1 = 10;
            int num2 = 2;
            int esperado = 5;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.dividir(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestDividir3()
        {
            //Arrange=preparacion
            int num1 = 15;
            int num2 = 5;
            int esperado = 3;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.dividir(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestDivide1()
        {
            //Arrange=preparacion
            int num1 = 40;
            int num2 = 4;
            int esperado = 10;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.divide(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestDivide2()
        {
            //Arrange=preparacion
            int num1 = 70;
            int num2 = 2;
            int esperado = 35;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.divide(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestDivide3()
        {
            //Arrange=preparacion
            int num1 = 100;
            int num2 = 20;
            int esperado = 5;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.divide(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }*/

    }
}