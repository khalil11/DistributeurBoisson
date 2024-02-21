using System;
using DistributeurBoissonChaude;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDistributeurBoisson
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void DistributeurBoissonTest()
        {   //Arrange
            double prixBoissonT = 1.3 * (1 + 0.2);//le prix Expresso que on dois avoir
            //Act
            double prixBoissonP = DistributeurBoissonClass.CalculerPrixBoisson("Expresso");//Calculerprix Expresso de notre application
            //Assert
            Assert.AreEqual(prixBoissonT, prixBoissonP); //comparer les 2 resultat
        }
    }
}
