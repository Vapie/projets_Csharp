using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculatrice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Tests
{
    [TestClass()]
    public class CalculTests
    {
        [TestMethod()]
        public void AdditionTest_AvecValeur_1_2_Retourne3()
        {
            //Arrange
            Double a = 1.0;
            Double b = 2.0;
            //Act
            Double resultat = Calcul.Addition(a, b);
            //Assert
            Assert.AreEqual(3.0, resultat, "Test non OK. La valeur doit être égale à 3");
        }

        [TestMethod()]
        public void DivisionTest_1_2()
        {
            //Arrange
            Double a = 1.0;
            Double b = 2.0;
            //Act
            Double resultat = Calcul.Division(a, b);
            //Assert
            Assert.AreEqual(0.5, resultat, "Test non OK. La valeur doit être égale à 0.5");
        }

        [TestMethod()]
        public void DivisionTest_1_moins2()
        {
            //Arrange
            Double a = 1.0;
            Double b = -2.0;
            //Act
            Double resultat = Calcul.Division(a, b);
            //Assert
            Assert.AreEqual(-0.5, resultat, "Test non OK. La valeur doit être égale à -0.5");
        }

        [TestMethod()]
        public void DivisionTest_0_1()
        {
            //Arrange
            Double a = 0.0;
            Double b = 1.0;
            //Act
            Double resultat = Calcul.Division(a, b);
            //Assert
            Assert.AreEqual(0, resultat, "Test non OK. La valeur doit être égale à 0");
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionTest_DivByZero()
        {
            //Arrange
            Double a = 1.0;
            Double b = 0.0;
            //Act
            Double resultat = Calcul.Division(a, b);
         
        }
    }
}