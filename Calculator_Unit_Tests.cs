namespace TDD_SQA
{
    public class Tests
    {
        private Calculator cal;
        [SetUp]
        public void Setup()
        {
            cal = new Calculator();
        }

        // Add case unit tests
        [Test]
        public void Add_Two_Integers_Test()
        {
            Assert.AreEqual(2, cal.add_integers(1,1));
        }

        [Test]
        public void Add_Two_Doubles_Test()
        {
            Assert.AreEqual(20.2, cal.add_doubles(9.4, 10.8), 0.01);
        }

        [Test]
        public void Add_Two_Floats_Test()
        {
            Assert.AreEqual(12.2, cal.add_floats(9.4f, 2.8f), 0.001f);
        }

        [Test]
        public void Add_Float_And_Zero_Test()
        {
            Assert.AreEqual(9.4f, cal.add_floats(9.4f, 0));
        }

        [Test]
        public void Add_Float_And_Integer_Test()
        {
            Assert.AreEqual(8.6f, cal.add_floats(5.6f, 3), 0.001f);
        }

        [Test]
        public void Add_Double_And_Float_Test()
        {
            Assert.AreEqual(8.7, cal.add_doubles(3.5, 5.2f), 0.001);
        }

        // Subtract case unit tests
        [Test]
        public void Subtract_Two_Integers_Test()
        {
            Assert.AreEqual(5, cal.subtract_integers(17, 12));
        }

        [Test]
        public void Subtract_Two_Doubles_Test()
        {
            Assert.AreEqual(1.6, cal.subtract_doubles(10.8, 9.2), 0.001);
        }

        [Test]
        public void Subtract_Two_Floats_Test()
        {
            Assert.AreEqual(-0.1f, cal.subtract_floats(2.8f, 2.9f), 0.01f);
        }

        [Test]
        public void Subtract_Double_And_Float_Test()
        {
            Assert.AreEqual(1.6, cal.subtract_doubles(10.8, 9.2f), 0.001);
        }

        [Test]
        public void Subtract_Float_And_Double_Test()
        {
            Assert.AreEqual(-0.1f, cal.subtract_floats(2.8f, 2.9f), 0.01f);
        }

        [Test]
        public void Subtract_Two_Negative_Numbers_Test()
        {
            Assert.AreEqual(-1, cal.subtract_integers(-2, -1));
        }

        // Multiply case unit cases
        [Test]
        public void Multiply_Two_Integers_Test()
        {
            Assert.AreEqual(24, cal.multiply_integers(2, 12));
        }

        [Test]
        public void Multiply_Two_Doubles_Test()
        {
            Assert.AreEqual(2.88, cal.multiply_doubles(1.2, 2.4), 0.001);
        }

        [Test]
        public void Multiply_Two_Floats_Test()
        {
            Assert.AreEqual(9.8f, cal.multiply_floats(2.8f, 3.5f), 0.001f);
        }

        [Test]
        public void Multiply_Floats_By_Zero_Test()
        {
            Assert.AreEqual(0.0, cal.multiply_floats(28.2f, 0.0f));
        }

        [Test]
        public void Multiply_Double_By_Float()
        {
            Assert.AreEqual(0.621, cal.multiply_doubles(2.7, 0.23f), 0.001f);
        }
        // Divison test cases
        [Test]
        public void Divide_Two_Integers_Test()
        {
            Assert.AreEqual(5, cal.divide_integers(60, 12));
        }

        [Test]
        public void Divide_Two_Doubles_Test()
        {
            Assert.AreEqual(5, cal.divide_doubles(2.5, 0.5));
        }

        [Test]
        public void Divide_Two_Floats_Test()
        {
            Assert.AreEqual(5, cal.divide_floats(3.5f, 0.7f));
        }

        [Test]
        public void Divide_Double_By_Integer_Test()
        {
            Assert.AreEqual(0.5, cal.divide_doubles(2.5, 5));
        }

        [Test]
        public void Divide_Float_By_Double_Test()
        {
            Assert.AreEqual(1277.5, cal.divide_floats(255.5f, 0.2f));
        }

        [Test]
        public void Divide_Double_By_Zero_Test()
        {
            Assert.Throws<DivideByZeroException>(() => cal.divide_by_zero(5.0, 0));
        }

        [Test]
        public void Divide_Integer_By_Zero_Test()
        {
            Assert.Throws<DivideByZeroException>(() => cal.divide_by_zero(25, 0));
        }

    }
}