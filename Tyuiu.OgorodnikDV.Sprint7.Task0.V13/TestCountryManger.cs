using System.ComponentModel;
using Tyuiu.OgorodnikDV.Sprint7.Lib;

namespace Tyuiu.OgorodnikDV.Sprint7.V13.Test
{
    [TestClass]
    public class CountryManagerTests
    {
        private CountryManager _manager;                                                                                                                                  //private ����������� �������, �����������, ��� ���������� �������� ������ ������ ������� ������.

        [TestInitialize]
        public void Setup()
        {
            // ������������� ����� ������ ������
            _manager = new CountryManager();
            _manager.Countries = new BindingList<Country>
            {
                new Country { Name = "USA", Capital = "Washington", Area = 9833517, Population = 331000000, PredominantNationality = "American", IsDeveloped = true },                    //�������� ������ �������� `Country`, ������ �� ������� ���������������� � ��������� ����������
                new Country { Name = "Canada", Capital = "Ottawa", Area = 9984670, Population = 38000000, PredominantNationality = "Canadian", IsDeveloped = true },
                new Country { Name = "Brazil", Capital = "Brasilia", Area = 8515767, Population = 212000000, PredominantNationality = "Brazilian", IsDeveloped = false }
            };
        }

        // ���� �� ����� �� ��������
        [TestMethod]
        public void SearchByName_ShouldReturnCorrectCountry()                                                                                                                          
        {
            var result = _manager.SearchByName("Canada");
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Canada", result[0].Name);
        }

        [TestMethod]
        public void SearchByName_ShouldReturnEmptyList_IfNotFound()
        {
            var result = _manager.SearchByName("Mexico");
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void SearchByName_ShouldIgnoreCase()
        {
            var result = _manager.SearchByName("canada");
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Canada", result[0].Name);
        }

        // ���� �� ���������� �� �������
        [TestMethod]
        public void FilterByMinArea_ShouldReturnCountriesLargerThanMinArea()
        {
            var result = _manager.FilterByMinArea(9000000);
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void FilterByMinArea_ShouldReturnEmptyList_IfNoneMatch()
        {
            var result = _manager.FilterByMinArea(10000000);
            Assert.AreEqual(0, result.Count);
        }

        // ���� �� ���������� �������� ���������
        [TestMethod]
        public void CalculateAveragePopulation_ShouldReturnCorrectAverage()
        {
            var average = _manager.CalculateAveragePopulation();
            Assert.AreEqual(193666666.67, average, 0.01); // ����������� ����������� 0.01
        }

        [TestMethod]
        public void CalculateAveragePopulation_ShouldReturnZero_IfNoCountries()
        {
            _manager.Countries.Clear();                                                                                         //Clear();: �����, ������� ������� ������ �����, ������ ��� ��������.Countries: �������� Countries ������� _manager, �������������� ������ �����.
            var average = _manager.CalculateAveragePopulation();
            Assert.AreEqual(0, average);
        }

        // ����� �� ���������� �� ��������� (�����������, ��������)
        [TestMethod]
        public void SortByPopulation_ShouldSortAscending()
        {
            var result = _manager.SortByPopulation();
            Assert.AreEqual("Canada", result[0].Name);
            Assert.AreEqual("Brazil", result[1].Name);
            Assert.AreEqual("USA", result[2].Name);
        }

        [TestMethod]
        public void SortByPopulation_ShouldSortDescending()
        {
            var result = _manager.SortByPopulation(true);
            Assert.AreEqual("USA", result[0].Name);
            Assert.AreEqual("Brazil", result[1].Name);
            Assert.AreEqual("Canada", result[2].Name);
        }

        // ����� �� ���������� ������
        [TestMethod]
        public void AddCountry_ShouldAddNewCountry()
        {
            var newCountry = new Country { Name = "Mexico", Capital = "Mexico City", Area = 1964375, Population = 126000000, PredominantNationality = "Mexican", IsDeveloped = false };
            _manager.AddCountry(newCountry);

            Assert.AreEqual(4, _manager.Countries.Count);
            Assert.IsTrue(_manager.Countries.Contains(newCountry));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddCountry_ShouldThrowException_IfCountryExists()
        {
            var duplicateCountry = new Country { Name = "Canada", Capital = "Toronto", Area = 9984670, Population = 40000000, PredominantNationality = "Canadian", IsDeveloped = true };
            _manager.AddCountry(duplicateCountry);
        }

        // ����� �� �������������� ������
        [TestMethod]
        public void EditCountry_ShouldUpdateCountryDetails()
        {
            var updatedCountry = new Country { Name = "Canada", Capital = "Toronto", Area = 9985000, Population = 40000000, PredominantNationality = "Canadian", IsDeveloped = true };
            var result = _manager.EditCountry("Canada", updatedCountry);

            Assert.IsTrue(result);
            var country = _manager.SearchByName("Canada")[0];
            Assert.AreEqual("Toronto", country.Capital);
            Assert.AreEqual(40000000, country.Population);
        }

        [TestMethod]
        public void EditCountry_ShouldReturnFalse_IfCountryNotFound()
        {
            var updatedCountry = new Country { Name = "Mexico", Capital = "Mexico City", Area = 1964375, Population = 126000000, PredominantNationality = "Mexican", IsDeveloped = false };
            var result = _manager.EditCountry("Mexico", updatedCountry);

            Assert.IsFalse(result);
        }

        // ����� �� �������� ������
        [TestMethod]
        public void RemoveCountry_ShouldRemoveCountry_IfExists()
        {
            var result = _manager.RemoveCountry("Canada");                                                                                     //���������� ����� RemoveCountry ��� �������� ������ "Canada".
            Assert.IsTrue(result);
            Assert.AreEqual(2, _manager.Countries.Count);                                                                                      //�����������, ��� ���������� ����� ����������� �� 2.
        }

        [TestMethod]
        public void RemoveCountry_ShouldReturnFalse_IfCountryNotFound()
        {
            var result = _manager.RemoveCountry("Mexico");
            Assert.IsFalse(result);
        }
    }
}
