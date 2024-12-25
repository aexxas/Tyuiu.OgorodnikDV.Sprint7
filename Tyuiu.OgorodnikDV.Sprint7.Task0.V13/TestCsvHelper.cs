using Tyuiu.OgorodnikDV.Sprint7.Lib;

namespace Tyuiu.OgorodnikDV.Sprint7.V13.Test;

    [TestClass]
public class CSVHelperTests
{
    [TestMethod]
    public void LoadFromCsv_ShouldLoadCountriesFromFile()
    {
        // Тест: проверяем загрузку данных из CSV.
        var filePath = "test.csv";

        // Создаем временный файл
        File.WriteAllLines(filePath, new[]
        {
                "Россия,Москва,17098242,146000000,Русские,true",
                "Франция,Париж,551695,67000000,Французы,true"
            });

        // Загружаем данные
        var countries = CSVHelper.LoadFromCsv(filePath);

        // Удаляем временный файл
        File.Delete(filePath);

        // Проверяем результат
        Assert.AreEqual(2, countries.Count);
        Assert.AreEqual("Россия", countries[0].Name);
        Assert.AreEqual("Франция", countries[1].Name);
    }

    [TestMethod]
    public void SaveToCsv_ShouldSaveCountriesToFile()
    {
        // Тест: проверяем сохранение данных в CSV.
        var filePath = "test_output.csv";
        var countries = new List<Country>
            {
                new Country { Name = "Германия", Capital = "Берлин", Area = 357022, Population = 83000000, PredominantNationality = "Немцы", IsDeveloped = true }
            };

        // Сохраняем данные
        CSVHelper.SaveToCsv(countries, filePath);

        // Проверяем, что файл создан и данные корректны
        var lines = File.ReadAllLines(filePath);
        File.Delete(filePath);

        Assert.AreEqual(1, lines.Length);
        Assert.AreEqual("Германия,Берлин,357022,83000000,Немцы,True", lines[0]);
    }
}
