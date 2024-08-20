using Katas.GoodVsEvil;
using System.Diagnostics;

namespace KataTest
{
    public class GoodVsEvilTest
    {

        [Test]
        public void TwoList_GoodWins()
        {
            //Arrenge
            string result = string.Empty;

            int[] goods = { 4, 2, 3, 3, 4, 10 };
            int[] evil = { 1, 2, 2, 2, 3, 2, 10 };

            //Act

            result = GoodVsEvilKata.GoodVsEvil(goods, evil);

            //Assert
            Assert.That(result, Is.EqualTo("Battle Result: Good triumphs over Evil"));
        }

        [Test]
        public void TwoList_EvilWins()
        {
            //Arrenge
            string result = string.Empty;

            int[] goods = { 1, 2, 3, 3, 4, 10 };
            int[] evil = { 1, 2, 2, 2, 3, 5, 10 };

            //Act

            result = GoodVsEvilKata.GoodVsEvil(goods, evil);

            //Assert
            Assert.That(result, Is.EqualTo("Battle Result: Evil eradicates all trace of Good"));
        }

        [Test]
        public void TwoList_TieResult()
        {
            //Arrenge
            string result = string.Empty;

            int[] goods = { 2, 2, 3, 4, 4, 10};
            int[] evil = { 1, 2, 2, 2, 3, 5, 10 };

            //Act

            result = GoodVsEvilKata.GoodVsEvil(goods, evil);

            //Assert
            Assert.That(result, Is.EqualTo("Battle Result: No victor on this battle field"));
        }
    }
}