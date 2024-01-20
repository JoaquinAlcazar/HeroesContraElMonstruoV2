using hVSmLib;
namespace HeroesContraElMonstruoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void statCheckerTest()
        {

            //Arrange
            int input = 20;
            int maxRange = 40;
            int minRange = 10;

            //Act
            
            bool isInRange = heroesContraMonstruoClass.statChecker(input, minRange, maxRange);

            //Assert

            Assert.IsTrue(isInRange);
        }

        [TestMethod]
        public void randomNumberGeneratorTest()
        {

            //Arrange
            int maxRange = 40;
            int minRange = 10;

            //Act

            int obtainedRandomNumber = heroesContraMonstruoClass.randomNumberGenerator(minRange, maxRange);

            //Ya que la función de statChecker me permite saber si un número se encuentra en un rango, la re-utilizo para saber si el numero generado está entre el valor máximo y el minimo
            bool isInRange = heroesContraMonstruoClass.statChecker(obtainedRandomNumber, minRange, maxRange);

            //Assert

            Assert.IsTrue(isInRange);
        }

        [TestMethod]
        public void nameArrayGeneratorTest()
        {

            //Arrange
            string names = "a,b,c,d";

            //Act

            string[] arrayNames = heroesContraMonstruoClass.nameArrayGenerator(names);

            //Assert

            Assert.AreEqual(arrayNames[0], "a");
            Assert.AreEqual(arrayNames[1], "b");
            Assert.AreEqual(arrayNames[2], "c");
            Assert.AreEqual(arrayNames[3], "d");
        }

        [TestMethod]
        public void damageCalculatorTest()
        {

            //Arrange
            int damage = 100;
            int damageReduction = 35;
           

            //Act
            //Para no tener problemas con la aleatoriedad de los criticos y fallos, haremos la prueba con la versión de la caluladora de daño del monstruo
            int damageDealt = heroesContraMonstruoClass.damageCalculator(damage, damageReduction, false);
            int damageDealtDefending = heroesContraMonstruoClass.damageCalculator(damage, damageReduction, true);
            
            //Assert
            Assert.AreEqual(damageDealt, 65);
            Assert.AreEqual(damageDealtDefending, 30);

        }

        [TestMethod]
        public void druidHealingTest()
        {

            //Arrange
            int actualHP = 1999;
            int maxHP = 2000;

            //Act
            actualHP = heroesContraMonstruoClass.druidHealing(actualHP, maxHP);

            //Assert
            Assert.AreEqual(actualHP, maxHP);

        }
    }
}