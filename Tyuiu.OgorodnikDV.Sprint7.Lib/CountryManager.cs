using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Tyuiu.OgorodnikDV.Sprint7.Lib
{
    // Класс для управления списком стран и выполнения операций с ним
    public class CountryManager
    {
        // Динамический Список стран                                                                                          //`= new BindingList<Country>();`  - Создаёт новый пустой список при инициализации свойства `Countries`. 

        public BindingList<Country> Countries { get; set; } = new BindingList<Country>();                                    //- `BindingList` — класс, представляющий список с поддержкой уведомлений об изменениях.  
                                                                                                                             //- Преимущество: можно привязать его к элементам пользовательского интерфейса(например, таблице) для автоматического обновления.
                                                                                                                             //- `<Country>` — указание, что это список объектов типа `Country` (генерик).
                                                                                                                             //Создаёт новый пустой список при инициализации свойства `Countries`.
        // Поиск стран по названию 
        public List<Country> SearchByName(string name)                                                                     
        {
            if (string.IsNullOrWhiteSpace(name))                                                                              //Метод `IsNullOrWhiteSpace` из класса `string`, проверяющий Пустая ли строка,Содержит ли она только пробелы
            {
                return new List<Country>();
            }

            return Countries
            .Where(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase))                                              //`(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase))`  Лямбда-выражение `c` — текущая страна в коллекции
            .ToList();                                                                                                       //`c.Name` — имя страны.  `Equals` — сравнивает строки.  StringComparison.OrdinalIgnoreCase` — сравнение без учёта регистра
        }                                                                                                                     

        // Фильтрация стран по минимальной площади
        public List<Country> FilterByMinArea(double minArea)
        {
            return Countries                                                                                                  //`.Where(...)` - Метод LINQ, фильтрующий список на основе условия; Лямбда-выражение: `c` — текущая страна  `c.Area` — площадь страны                                                 
            .Where(c => c.Area > minArea)                                                                                    // `>` — условие: площадь должна быть больше заданной минимальной площади (**`minArea`**).
            .ToList();                                                                                                      //`.ToList()` Преобразует результат фильтрации в список `List<Country>`
        }

        // Вычисление среднего значения населения
        public double CalculateAveragePopulation()
        {
            return Countries.Any() ? Countries.Average(c => c.Population) : 0;              //Метод Any() проверяет, содержит ли коллекция Countries хотя бы один элемент
                                                                                            //Average(): Метод, который вычисляет среднее значение для последовательности.
                                                                                             //c => c.Population: Лямбда-выражение, которое указывает, что для каждого элемента c в коллекции
                                                                                           //Countries нужно взять значение Population (численность населения).
        }

        // Сортировка стран по населению
        public List<Country> SortByPopulation(bool descending = false)
        {
            return descending
            ? Countries.OrderByDescending(c => c.Population).ToList()
            : Countries.OrderBy(c => c.Population).ToList();
                                                                                        //descending ? Тернарный оператор. Если descending равно true,
                                                                                        //выполняется первое выражение; если false, выполняется второ
        }

        // Метод для добавления новой страны
        public void AddCountry(Country country)
        {
                                                                                                       // Проверяем, не существует ли уже страна с таким же именем
            if (Countries.Any(c => c.Name.Equals(country.Name, StringComparison.OrdinalIgnoreCase)))
                                                                                                       //Лямбда-выражение, которое проверяет, совпадает ли имя текущей страны c с именем страны, которую мы пытаемся добавить (country.Name).
                                                                                                        //StringComparison.OrdinalIgnoreCase: Указывает, что сравнение должно игнорировать регистр символов
            {
                //Генерация нового исключения с сообщением об ошибке.
                throw new InvalidOperationException("Страна с таким названием уже существует!");
            }
            Countries.Add(country); //Добавляет объект country в коллекцию Countries.
        }

        // Метод для редактирования существующей страны
        public bool EditCountry(string countryName, Country updatedCountry)
        {
            var country = Countries.FirstOrDefault(c => c.Name.Equals(countryName, StringComparison.OrdinalIgnoreCase));  //`FirstOrDefault` -Метод LINQ, возвращающий первый элемент, удовлетворяющий условию, или `null`, если такой элемент не найден.
            if (country != null)
            {
                // Обновляем данные страны
                country.Name = updatedCountry.Name;                                                                        //Каждая строка присваивает новое значение из объекта `updatedCountry` соответствующему полю найденной страны (**`country`**).  
                country.Capital = updatedCountry.Capital;
                country.Area = updatedCountry.Area;
                country.Population = updatedCountry.Population;
                country.PredominantNationality = updatedCountry.PredominantNationality;
                country.IsDeveloped = updatedCountry.IsDeveloped;
                return true;
            }
            return false; // Если страна не найдена
        }

        // Метод для удаления страны
        public bool RemoveCountry(string countryName)
        {
            var country = Countries.FirstOrDefault(c => c.Name.Equals(countryName, StringComparison.OrdinalIgnoreCase));          //FirstOrDefault(...): Метод, который возвращает первый элемент последовательности, удовлетворяющий заданному условию, или значение по
                                                                                                                                  //умолчанию (в данном случае null), если ни один элемент не соответствует условию. c.Name.Equals(countryName, StringComparison.OrdinalIgnoreCase): Метод Equals сравнивает два значения
            if (country != null)                                                                                                    //(имя страны и переданное имя) с учетом игнорирования регистра символов (StringComparison.OrdinalIgnoreCase).
            {
                Countries.Remove(country);
                return true; // Страна успешно удалена
            }
            return false; // Если страна не найдена
        }
    }
}