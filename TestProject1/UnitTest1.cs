using ConsoleApp1;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void PassingIShouldReturns1()
        {
            var translate = new Translate();

            var result = translate.TranslateToArabic("I");
            
            Assert.AreEqual(1,result);
        }
        
        [Test]
        public void PassingVIShouldReturns6()
        {
            var translate = new Translate();

            var result = translate.TranslateToArabic("VI");
            
            Assert.AreEqual(6, result);
        }
        
        [Test]
        public void PassingMCCShouldReturns1200()
        {
            var translate = new Translate();

            var result = translate.TranslateToArabic("MCC");
            
            Assert.AreEqual(1200, result);
        }
        
        [Test]
        public void PassingIVShouldReturns4()
        {
            var translate = new Translate();

            var result = translate.TranslateToArabic("IV");
            
            Assert.AreEqual(4, result);
        }
        
        [Test]
        public void PassingXCShouldReturns90()
        {
            var translate = new Translate();

            var result = translate.TranslateToArabic("XC");
            
            Assert.AreEqual(90, result);
        }
        
        [Test]
        public void PassingXCVShouldReturns95()
        {
            var translate = new Translate();

            var result = translate.TranslateToArabic("XCV");
            
            Assert.AreEqual(95, result);
        }
        
        [Test]
        public void PassingXCIXShouldReturns99()
        {
            var translate = new Translate();

            var result = translate.TranslateToArabic("XCIX");
            
            Assert.AreEqual(99, result);
        }
    }
}