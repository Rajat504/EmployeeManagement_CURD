using NUnit.Framework;
using QualityMeasurement;

namespace NUnit_QualityMeasurement
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        /// <summary>
        /// Give_0_Feet_and_0_Feet_Should_Return_Equal.
        /// </summary>

        [Test]
        public void WhenGiven0FeetAnd0FeetShouldReturnEqual()
        {
            Feet feet = new Feet(0);
            int expected = feet.EqualsValue();
            int actual = 0;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// PerForm_Test_For_Equality_Null_Check.
        /// </summary>

        [Test]
        public void TestForEqualityNullCheck()
        {
            Feet feet = new Feet();
            bool expected = feet.Equals(null);
            Assert.IsTrue(expected);

        }
        /// <summary>
        /// Perform_Test_For_Equality_Ref_Check.
        /// </summary>

        [Test]
        public void TestForEqualityREfCheck()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(feet);
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Perform_Test_For_Equality_Type_Check.
        /// </summary>

        [Test]
        public void TestForEqualityTypeCheck()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(new Feet());
            Assert.IsTrue(result);
        }
        /// <summary>
        /// perform test for Value Check
        /// </summary>
        [Test]
        public void WhenGiven3FeetAnd3FeetShouldReturnEqual()
        {
            Feet feet = new Feet(3);
            int expected = feet.EqualsValue();
            int actual = 3;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Give_0_Inch_and_0_Inch_Should_Return_Equal.
        /// </summary>
        public void WhenGiven0InchAnd0InchShouldReturnEqual()
        {
            Inch inch = new Inch(0);
            int expected = inch.EqualsValue();
            int actual = 0;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// PerForm_Test_For_Equality_Null_Check.
        /// </summary>
        [Test]
        public void Test4()
        {
            Inch inch = new Inch();
            bool expected = inch.Equals(null);
            Assert.IsTrue(expected);
        }
        /// <summary>
        /// Perform_TestCase_For_Equality_Ref_Check.
        /// </summary>
        [Test]
        public void Test5()
        {
            Inch inch = new Inch();
            bool result = inch.Equals(inch);
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Perform_TestCase_For_Equality_Type_Check.
        /// </summary>
        public void Test6()
        {
            Inch inch = new Inch();
            bool result = inch.Equals(new Inch());
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Perform_TestCase_For_Equality_Ref_Check.
        /// </summary>
        [Test]
        public void WhenGiven3InchAnd3INCHShouldReturnEqual()
        {
            Inch inch = new Inch(3);
            int expected = inch.EqualsValue();
            int actual = 3;
            Assert.AreEqual(expected, actual);
        }
        ///<summary>
        ///Comparison check Given 0 Feet and 0 inch Should return equal
        ///</summary>
        [Test]
        public void WhenGiven0FeetAnd0InchShouldReturnEqual()
        {
            Feet feet = new Feet(0);
            int expected = feet.EqualsValue();
            Inch inch = new Inch(0);
            int actual = inch.EqualsValue();
            Assert.AreEqual(expected, actual);
        }
        ///<summary>
        ///compare 1st test case in which 1feet is not equal to 1inch
        ///</summary>
        [Test]
        public void WhenGiven1FeetIsNotEqualTo1inch()
        {
            Feet feet = new Feet(1);
            int actual = feet.EqualsValue();
            Inch inch = new Inch();
            int expected = inch.EqualsValue();
            Assert.AreNotEqual(expected, actual);

        }
        ///<summary>
        ///compare 2nd test case where 1inch is not equal to 1 feet
        ///</summary>
        [Test]
        public void WhenGiven1inchIsNotEqualTo1Feet()
        {
            Inch inch = new Inch(1);
            int actual = inch.EqualsValue();
            Feet feet = new Feet();
            int expected = feet.EqualsValue();
            Assert.AreNotEqual(expected, actual);
        }
        ///<summary>
        ///compare 3rd test case where 1Feet is equal to 12inch
        ///</summary>
        [Test]
        public void When1FeetIsEqualTo12Inch()
        {
            Feet feet = new Feet(1);
            int actual = feet.EqualsValue();
            Inch inch = new Inch(1);
            int expected = inch.EqualsValue();
            Assert.AreEqual(expected, actual);
        }
        ///<summary>
        ///compare 4th test case where 12inch is equal to 1 feet
        ///</summary>
        [Test]
        public void When12InchIsEqualTo1Feet()
        {
            Inch inch = new Inch(12);
            int actual = inch.EqualsValue();
            Feet feet = new Feet(1);
            int expected = inch.EqualsValue();
            Assert.AreEqual(expected, actual);
        }
        ///<summary>
        ///compare 1kG equals to 1000Gram
        ///</summary>
        [Test]
        public void When1KGISEqualTo1000Gram()
        {
            Kilogram kg = new Kilogram(1000);
            int actual = kg.EqualsValue();
            Gram gram = new Gram(1000);
            int expected = gram.EqualsValue();
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Compare 1Gram Equals to 1Gram
        /// </summary>
        [Test]
        public void When1GramEqualsTo1Gram()
        {
            Gram gram = new Gram(1);
            int actual = gram.EqualsValue();
            Gram gram1 = new Gram(1);
            int expected = gram1.EqualsValue();
            Assert.AreEqual(expected, actual);
        }
        ///<summary>
        ///compare 1Celcius Equals to 1Celcius 
        ///</summary>
        [Test]
        public void When1CelciusEqualsTo2Gram()
        {
            Celcius celcius = new Celcius(1);
            double actual = celcius.EqualsValue();
            Gram gram = new Gram(1);
            int expected = gram.EqualsValue();
            Assert.AreEqual(expected, actual);
        }
        ///<summary>
        ///1 celcius not equal 2C Celcius
        ///</summary>
        public void When1CelciusNotEqualTo50Fh()
        {
            Celcius celcius = new Celcius(1);
            double actual = celcius.EqualsValue();
            Celcius celcius1 = new Celcius(2);
            double expected = celcius1.EqualsValue();
            Assert.AreNotEqual(expected, actual);
        }
        ///<summary>
        ///When  1Celcius is not equal to 50Farenheit
        ///</summary>
        [Test]
        public void When1CelciusIsNotEqualTo50Farenheit()
        {
            Celcius celcius = new Celcius(1);
            double actual = celcius.EqualsValue();
            Farenheit farenheit = new Farenheit(50);
            double expected = farenheit.EqualsValue();
            Assert.AreNotEqual(expected, actual);
        }
        ///<summary>
        ///When 1Celcius is equal to 33Farenheit
        ///</summary>
        [Test]
        public void When1CelciusIsEqualTo33Farenheit()
        {
            Celcius celcius = new Celcius(33);
            double actual = celcius.EqualsValue();
            Farenheit farenheit = new Farenheit(33.0);
            double expected = farenheit.EqualsValue();
            Assert.AreEqual(expected, actual);
        }
        ///<summary>
        ///perform test for gram equality null check
        ///</summary>
        [Test]
        public void TestForGramEqualityNullCheck()
        {
            Gram gram = new Gram();
            bool result = gram.Equals(null);
            Assert.IsTrue(result);
        }
        ///<summary>
        ///perform test for Gram Equality ref.check
        ///</summary>
        [Test]
        public void TestForGramEqualityRefCheck()
        {
            Gram gram = new Gram();
            bool result = gram.Equals(gram);
            Assert.IsTrue(result);
        }
        ///<summary>
        ///Test for Equality Type check
        ///</summary>
        [Test]
        public void TestFOrEqualityTypeCheck()
        {
            Gram gram = new Gram();
            bool result = gram.Equals(new Gram());
            Assert.IsTrue(result);
        }
        ///<summary>
        ///Test For Equalty Value Check
        ///</summary>
        [Test]
        public void TestForEqualityValueCheck()
        {
            Gram gram = new Gram(3);
            int actual = gram.EqualsValue();
            Gram gram1 = new Gram(3);
            int Expected = gram1.EqualsValue();
            Assert.AreEqual(Expected, actual);
        }
        ///<summary>
        ///Test For kilogram Equality Null Check
        ///</summary>
        [Test]
        public void TestForKilogramEqualityNullCheck()
        {
            Kilogram kilogram = new Kilogram();
            bool result = kilogram.Equals(null);
            Assert.IsTrue(result);
        }
        ///<summary>
        ///Test For kilogram Equality Ref Check
        ///</summary>
        [Test]
        public void TestForKilogramEqualityRefCheck()
        {
            Kilogram kilogram = new Kilogram();
            bool result = kilogram.Equals(kilogram);
            Assert.IsTrue(result);
        }
        ///<summary>
        ///Test For Kilogram Equality Type Check
        ///</summary>
        [Test]
        public void TestForKilogramEqualityTypeCheck()
        {
            Kilogram kilogram = new Kilogram();
            bool result = kilogram.Equals(new Kilogram());
            Assert.IsTrue(result);
        }
        ///<summary>
        ///test for equality value check
        ///</summary>
        [Test]
        public void TestForKilogramEqualityValueCheck()
        {
            Kilogram kilogram = new Kilogram();
            int actual = kilogram.EqualsValue();
            Kilogram kilogram1 = new Kilogram();
            int expected = kilogram.EqualsValue();
            Assert.AreEqual(expected, actual);
        }
        ///<summary>
        ///Test For Equality Celicius Equality null Check
        ///</summary>
        [Test]
        public void TestFOrEqualityCelciusNullCheck()
        {
            Celcius celcius = new Celcius();
            bool result = celcius.Equals(null);
            Assert.IsTrue(result);
        }
        ///<summary>
        ///Test For Equality Celcius Ref Check
        ///</summary>
        [Test]
        public void TestForEqualityCelciusRefCheck()
        {
            Celcius celcius = new Celcius();
            bool result = celcius.Equals(celcius);
            Assert.IsTrue(result);
        }
        ///<summary>
        ///Test for Equality Type Check
        ///</summary>
        [Test]
        public void TestForEqualityCelciusTypeCheck()
        {
            Celcius celcius = new Celcius();
            bool result = celcius.Equals(new Celcius());
            Assert.IsTrue(result);
        }
        ///<summary>
        ///Test For Equality Celcius Value Check
        ///</summary>
        [Test]
        public void TestForEqualityCelciusValueCheck()
        {
            Celcius celcius = new Celcius(3);
            double actual = celcius.EqualsValue();
            Celcius celcius1 = new Celcius(3);
            double expected = celcius.EqualsValue();
            Assert.AreEqual(expected, actual);
        }
        ///<summary>
        ///Test For Equality Farenheit Null Check
        ///</summary>
        [Test]
        public void TestForEqualityFareneitNullCheck()
        {
            Farenheit farenheit = new Farenheit();
            bool result = farenheit.Equals(null);
            Assert.IsTrue(result);
        }
        ///<summary>
        ///Test For Equality farenheit Ref.Check
        ///</summary>
        [Test]
        public void TestForEqualityRefCheck()
        {
            Farenheit farenheit = new Farenheit();
            bool result = farenheit.Equals(farenheit);
            Assert.IsTrue(result);
        }
        ///<summary>
        ///Test For Equality Farenheit Type Check
        ///</summary>
        [Test]
        public void TestForEqualityFarenheitTypeCheck()
        {
            Farenheit farenheit = new Farenheit();
            bool result = farenheit.Equals(new Farenheit());
            Assert.IsTrue(result);
        }
        ///<summary>
        ///Test For Equality Farenheit Value Check
        ///</summary>
        [Test]
        public void TestForEqualityFarenheitValueCheck()
        {
            Farenheit farenheit = new Farenheit(3);
            double actual = farenheit.EqualsValue();
            Farenheit farenheit1 = new Farenheit();
            double expected = farenheit.EqualsValue();
            Assert.AreEqual(expected, actual);



        }
    }
}