using System;
using System.Collections.Generic;
using System.IO;

namespace Tyuiu.OgorodnikDV.Sprint7.Lib
{
    public class CSVHelper
    {
        
        /// Загрузка данных из CSV файла.
        
        public static List<Country> LoadFromCsv(string filePath)
        {
            var countries = new List<Country>();

            try
            {
                var lines = File.ReadAllLines(filePath); // Считываем строки из файла

                foreach (var line in lines)                                                                                     //Цикл, который перебирает каждую строку в массиве `lines`. Каждая строка будет храниться в переменной `line`.
                {
                    var values = line.Split(',');

                    // Проверяем корректность данных
                    if (values.Length < 6)
                    {
                        throw new Exception("Некорректный формат файла!");
                    }

                    // Добавляем страну в список
                    countries.Add(new Country
                    {
                        Name = values[0],
                        Capital = values[1],
                        Area = double.Parse(values[2]),
                        Population = long.Parse(values[3]),
                        PredominantNationality = values[4],
                        IsDeveloped = bool.Parse(values[5])
                    });
                }
            }
            catch (Exception ex)                                                                                                                 // catch (Exception ex) Блок обработки исключений. Если возникает ошибка в блоке `try`, управление передается сюда.
            {
                throw new Exception("Ошибка при загрузке данных из файла: " + ex.Message);
            }

            return countries;
        }

        
        /// Сохранение данных в CSV файл.
        
      
        public static void SaveToCsv(List<Country> countries, string filePath)                                                             // List<Country> countries: Параметр метода. Это список объектов типа Country, который будет сохранен в файл
        {
            try
            {
                var lines = new List<string>();                                                                                                   //lines.Add() Добавление строки в список `lines`. Используется интерполяция строк для создания строки формата CSV с данными о стране.

                foreach (var country in countries)
                {
                    lines.Add($"{country.Name},{country.Capital},{country.Area},{country.Population},{country.PredominantNationality},{country.IsDeveloped}");            //$ перед строкой используется для создания интерполяции строк                           
                }                                                                                                                                                           //способ вставки значений переменных или выражений прямо в строку. Это делает код более читаемым

                File.WriteAllLines(filePath, lines); // Сохраняем строки в файл
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при сохранении данных в файл: " + ex.Message);
            }
        }
    }
}