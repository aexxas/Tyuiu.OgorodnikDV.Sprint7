using Tyuiu.OgorodnikDV.Sprint7.Lib;

namespace Tyuiu.OgorodnikDV.Sprint7.V13.Test;

    [TestClass]
public class CSVHelperTests
{
    [TestMethod]
    public void LoadFromCsv_ShouldLoadCountriesFromFile()
    {
        // ����: ��������� �������� ������ �� CSV.
        var filePath = "test.csv";

        // ������� ��������� ����
        File.WriteAllLines(filePath, new[]
        {
                "������,������,17098242,146000000,�������,true",
                "�������,�����,551695,67000000,��������,true"
            });

        // ��������� ������
        var countries = CSVHelper.LoadFromCsv(filePath);

        // ������� ��������� ����
        File.Delete(filePath);

        // ��������� ���������
        Assert.AreEqual(2, countries.Count);
        Assert.AreEqual("������", countries[0].Name);
        Assert.AreEqual("�������", countries[1].Name);
    }

    [TestMethod]
    public void SaveToCsv_ShouldSaveCountriesToFile()
    {
        // ����: ��������� ���������� ������ � CSV.
        var filePath = "test_output.csv";
        var countries = new List<Country>
            {
                new Country { Name = "��������", Capital = "������", Area = 357022, Population = 83000000, PredominantNationality = "�����", IsDeveloped = true }
            };

        // ��������� ������
        CSVHelper.SaveToCsv(countries, filePath);

        // ���������, ��� ���� ������ � ������ ���������
        var lines = File.ReadAllLines(filePath);
        File.Delete(filePath);

        Assert.AreEqual(1, lines.Length);
        Assert.AreEqual("��������,������,357022,83000000,�����,True", lines[0]);
    }
}
