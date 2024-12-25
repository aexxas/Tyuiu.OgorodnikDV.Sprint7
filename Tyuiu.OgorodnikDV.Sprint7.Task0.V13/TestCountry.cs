using Tyuiu.OgorodnikDV.Sprint7.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.OgorodnikDV.Sprint7.Task0.V13
{using Tyuiu.OgorodnikDV.Sprint7.Lib;
    [TestClass]
    public class CountryTests
    {
        [TestMethod]
        public void Country_ShouldInitializeCorrectly()
        {
            // Тест: проверяем правильную инициализацию объекта Country.
            var country = new Country
            {
                Name = "Россия",
                Capital = "Москва",
                Area = 17098242,
                Population = 146000000,
                PredominantNationality = "Русские",
                IsDeveloped = true
            };

            // Проверяем свойства
            Assert.AreEqual("Россия", country.Name);
            Assert.AreEqual("Москва", country.Capital);
            Assert.AreEqual(17098242, country.Area);
            Assert.AreEqual(146000000, country.Population);
            Assert.AreEqual("Русские", country.PredominantNationality);
            Assert.IsTrue(country.IsDeveloped);
        }

        [TestMethod]
        public void Country_ShouldAllowPropertyChanges()
        {
            // Тест: проверяем, что свойства Country можно изменять.
            var country = new Country
            {
                Name = "Россия",
                Capital = "Москва",
                Area = 17098242,
                Population = 146000000,
                PredominantNationality = "Русские",
                IsDeveloped = true
            };

            // Изменяем свойства
            country.Name = "Франция";
            country.Capital = "Париж";
            country.Area = 551695;
            country.Population = 67000000;
            country.PredominantNationality = "Французы";
            country.IsDeveloped = true;

            // Проверяем изменения
            Assert.AreEqual("Франция", country.Name);
            Assert.AreEqual("Париж", country.Capital);
            Assert.AreEqual(551695, country.Area);
            Assert.AreEqual(67000000, country.Population);
            Assert.AreEqual("Французы", country.PredominantNationality);
            Assert.IsTrue(country.IsDeveloped);
        }
    }
}